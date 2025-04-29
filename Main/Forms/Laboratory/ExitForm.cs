using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Laboratory
{
    public partial class ExitForm : RASF.General.Forms.Base.DockContentForm
    {
        public ExitForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {
            this.testExecutersLaboratorysList1.FillList2();
            FillContract();                                                                                                                                                                                                                                              
        }

        private void FillContract()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.contractsNotExitedList1.Fill(Parameter);
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.contractsNotExitedList1.Update();
            FillContract();

        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                if (this.grdContracts.CurrentRow.DataRow is RASF.General.Data.ContractsNotEntered)
                {
                    RASF.General.Data.ContractsNotEntered Row = (RASF.General.Data.ContractsNotEntered)this.grdContracts.CurrentRow.DataRow;
                    if (Row.PartsMasterNotEntered.Count() > 0)
                    {
                        if (Row.PartsMasterNotEntered[0].TestNameNotEntered.Count() > 0)
                        {
                            General.Classes.Utility.Create_DropDown(this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"], this.testExecutersLaboratorysList1.Where(row => row.LabId == Row.PartsMasterNotEntered[0].TestNameNotEntered[0].LaboratoryCode), "UserName", "UserName");
                            this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"].DefaultValue = this.testExecutersLaboratorysList1[2].UserId;
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                else if (this.grdContracts.CurrentRow.DataRow is RASF.General.Data.PartsMasterNotEntered)
                {
                    RASF.General.Data.PartsMasterNotEntered Row = (RASF.General.Data.PartsMasterNotEntered)this.grdContracts.CurrentRow.DataRow;

                    if (Row.TestNameNotEntered.Count() > 0)
                    {
                        General.Classes.Utility.Create_DropDown(this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"], this.testExecutersLaboratorysList1.Where(row => row.LabId == Row.TestNameNotEntered[0].LaboratoryCode), "UserName", "UserName");
                        this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"].DefaultValue = this.testExecutersLaboratorysList1[2].UserId;
                    }
                    else
                    {
                    }
                }
                else
                {
                    RASF.General.Data.TestNameNotEntered Row = (RASF.General.Data.TestNameNotEntered)this.grdContracts.CurrentRow.DataRow;

                    General.Classes.Utility.Create_DropDown(this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"], this.testExecutersLaboratorysList1.Where(row => row.LabId == Row.LaboratoryCode), "UserName", "UserName");
                    this.grdContracts.RootTable.ChildTables[0].ChildTables[0].Columns["TestExecutersCode"].DefaultValue = this.testExecutersLaboratorysList1[2].UserId;

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContract();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsNotEntered CurrentRow = (RASF.General.Data.ContractsNotEntered)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new Laboratory.ViewCostPaperLaboratory(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
