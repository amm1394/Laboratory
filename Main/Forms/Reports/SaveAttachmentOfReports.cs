using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class SaveAttachmentOfReports : RASF.General.Forms.Base.DockContentForm
    {
        public SaveAttachmentOfReports()
        {
            InitializeComponent();
            ShowpnlSave = false;
            ShowpnlExit = false;

            this.contractsBaseEditList1.spName = "SaveAttachments";            
        }
         Guid ContractCode;
         private RASF.General.Data.Contracts_Base Contracts_Base = new General.Data.Contracts_Base();

        private void EditContract_Load(object sender, EventArgs e)
        {

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsBaseEditList1.Fill(Parameters);

            this.grdEditContract.Refetch();
        }
               
        protected virtual void grdEditContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ContractCode = (Guid)(this.grdEditContract.CurrentRow.Cells["ContractsCode"].Value);
            RASF.Main.Forms.Reports.SaveAttachmentFile SaveAttachmentFile = new RASF.Main.Forms.Reports.SaveAttachmentFile(ContractCode);
            SaveAttachmentFile.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       
      
    }
}
