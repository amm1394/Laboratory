using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class EditContractDeclareCost : RASF.General.Forms.Base.DockContentForm
    {
        public EditContractDeclareCost()
        {
            InitializeComponent();
            ShowpnlSave = false;
            ShowpnlExit = false;
            ShowpnlUpdate = true; 
            
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
            this.contractsBaseEditDeclareCostList1.Fill(Parameters);

            grdEditContract.Refetch();
        }
               
        protected virtual void grdEditContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ContractCode = (Guid)(this.grdEditContract.CurrentRow.Cells["ContractsCode"].Value);
         //   RASF.Main.Forms.Reception.New_Reciption_Edit22 Reciption_EditDeclareCost = new RASF.Main.Forms.Reception.New_Reciption_Edit22(ContractCode);
         //   Reciption_EditDeclareCost.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       
      
    }
}
