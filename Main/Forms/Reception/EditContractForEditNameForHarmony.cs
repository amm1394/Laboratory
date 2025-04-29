using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class EditContractForEditNameForHarmony : RASF.General.Forms.Base.DockContentForm
    {
        public EditContractForEditNameForHarmony()
        {
            InitializeComponent();
            ShowpnlSave = false;
            ShowpnlExit = false;
            ShowpnlUpdate = true;
            this.contractsBaseEditList1.spName = "EditContractForEditNameForHarmony";
            
        }
         Guid ContractCode;
       public  Guid Executers;
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
            RASF.Main.Forms.Reception.EditPiecesName Reciption_Edit = new RASF.Main.Forms.Reception.EditPiecesName(ContractCode);
            Reciption_Edit.Show();

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@Description", "اصلاح نمونه - قراردادن عکس"));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("DescForEditContractBase_Insert", Parameter);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

       
      
    }
}
