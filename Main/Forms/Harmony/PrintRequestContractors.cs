using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class PrintRequestContractors : RASF.General.Forms.Base.DockContentForm
    {
        public PrintRequestContractors()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            this.ShowpnlSave = false; 
        }
        Guid ContractCode;


        public PrintRequestContractors(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void PrintRequestContractors_Load(object sender, EventArgs e)
        {
        }

        private void grdcontractors_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            //((RASF.General.Data.SentPartToContractors)this.grdcontractors.CurrentRow.DataRow).RowState = General.Enums.RowState.Updated;
            //this.printOfRequestContractorsList1.Update();

            Report2.Load(String.Format("{0}\\Report\\RequestOfContractor.mrt", Application.StartupPath));
            Report2["@countractorsCode"] = (Guid)this.grdcontractors.CurrentRow.Cells["countractorsCode"].Value;
            Report2["@LaboratoryCode"] = (Guid)this.grdcontractors.CurrentRow.Cells["LaboratoryCode"].Value;
            Report2["@ContractCode"] = (Guid)this.grdcontractors.CurrentRow.Cells["ContractCode"].Value;
            Report2.Show();

            ((RASF.General.Data.SentPartToContractors)this.grdcontractors.CurrentRow.DataRow).RowState = General.Enums.RowState.Updated;
            this.printOfRequestContractorsList1.Update();

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", ContractCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("userId", RASF.General.Classes.Global.CurrentUserCode));
            this.printOfRequestContractorsList1.Fill(Parameter);
            this.grdcontractors.Refetch();
             
            
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("userId", RASF.General.Classes.Global.CurrentUserCode));
            this.printOfRequestContractorsList1.Fill(Parameter);
            this.grdcontractors.Refetch();

            ContractCode = e.ContractsCode;
        }


    }
}
