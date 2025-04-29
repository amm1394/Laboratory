using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace RASF.Main.Forms.Laboratory
{
    public partial class SendToContractors : RASF.General.Forms.Base.DockContentForm
    {
        public SendToContractors()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        public SendToContractors(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }
        Guid contractsCode;
        private void SendToContractors_Load(object sender, EventArgs e)
        {
            this.constractorsList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdContractors.RootTable.Columns["countractorsCode"], this.constractorsList1, "ContractorCode", "Name");
            this.grdContractors.RootTable.Columns["countractorsCode"].DefaultValue = this.constractorsList1[0].ContractorCode;
            General.Classes.Utility.Create_DropDown(this.GrdEdit.RootTable.Columns["countractorsCode"], this.constractorsList1, "ContractorCode", "Name");
            this.GrdEdit.RootTable.Columns["countractorsCode"].DefaultValue = this.constractorsList1[1].ContractorCode;
                    
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            RefetchGrid(e);
            contractsCode = e.ContractsCode;

        }

        private void RefetchGrid(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("userId",RASF.General.Classes.Global.CurrentUserCode));
            this.sertPartToContractorsList1.Fill(Parameter);
            this.grdContractors.Refetch();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach (RASF.General.Data.SentPartToContractors sertPartToContractors in this.sertPartToContractorsList1.Where(p=>p.Check == true).ToList())
            {
                sertPartToContractors.UserIdSelect = RASF.General.Classes.Global.CurrentUserCode;
            }
            this.sertPartToContractorsList1.Update();

           
            foreach (RASF.General.Data.SentPartToContractors SertPartToContractors in this.editContractorsForLabList1.Where(p=>p.CheckForEdit==true).ToList())
            {
                if ( SertPartToContractors.countractorsCode != Guid.Empty)
                {
                    this.editContractorsForLabList1.Update();
                }
            }
                                  
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("userId", RASF.General.Classes.Global.CurrentUserCode));
            this.sertPartToContractorsList1.Fill(Parameter);
            this.grdContractors.Refetch();
        }

        private void grdContractors_SelectionChanged(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("PartsTestMasterCode", this.grdContractors.CurrentRow.Cells["PartsTestMasterCode"].Value));
            this.editContractorsForLabList1.Fill(Parameter);
            this.GrdEdit.Refetch();
        }

        private void grdContractors_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }


  }
}
