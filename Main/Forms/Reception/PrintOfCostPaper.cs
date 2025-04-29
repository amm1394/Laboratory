using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class PrintOfCostPaper : RASF.General.Forms.Base.DockContentForm
    {
        public PrintOfCostPaper()
        {
            InitializeComponent();
            ShowpnlSave = false;
            ShowpnlExit = false;
            ShowpnlUpdate = true;
            this.contractsBaseEditList1.spName = "PrintPaperContractsBase";
            
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
            report.Load(String.Format("{0}\\Report\\Report1.mrt", Application.StartupPath));
            report["@Code"] = ContractCode;
            report.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       
      
    }
}
