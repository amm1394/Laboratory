using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class CancelReportWrite : RASF.General.Forms.Base.DockContentForm
    {
        public CancelReportWrite()
        {
            InitializeComponent();
          
        }

        public CancelReportWrite(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {


            this.yes_NoList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdReport.RootTable.Columns["HaveReport"], this.yes_NoList1, "Code", "YesNo");

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.cancelReportWriteList1.Fill(Parameter);


            this.grdReport.Refetch();
        }

        private void CancelReportWrite_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.cancelReportWriteList1.Update();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //RASF.General.Data.TestNameNotEntered CurrentRow = (RASF.General.Data.TestNameNotEntered)this.grdReport.CurrentRow.DataRow;

            //List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters1.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", CurrentRow.PartsTestMasterCode));
            //RASF.General.Lists.BanksList.FillScalar("InsPartTestDetail_Insert", Parameters1);
        }

        
    }
}
