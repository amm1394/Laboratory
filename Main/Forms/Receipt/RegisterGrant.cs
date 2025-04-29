using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class RegisterGrant : RASF.General.Forms.Base.DockContentForm
    {
        public RegisterGrant()
        {
            InitializeComponent();
        }

        private void RegisterGrant_Load(object sender, EventArgs e)
        {
            this.registerGrantForViewList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.DebtorCreditorContractBase rowUser in registerGrantForViewList1)
            {
                rowUser.UserId = RASF.General.Classes.Global.CurrentUserCode;
            }

                this.registerGrantForViewList1.Update();
                this.registerGrantForViewList1.Fill();
                this.grdContracts.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.registerGrantForViewList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("گزارش گرنت");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DebtorCreditorContractBase CurrentRow = (RASF.General.Data.DebtorCreditorContractBase)this.grdContracts.SelectedItems[0].GetRow().DataRow;
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", CurrentRow.ContractsCode));
            RASF.General.Lists.BanksList.FillScalar("RegisterGrantForView_Delete", Parameter);

            this.registerGrantForViewList1.Fill();
            this.grdContracts.Refetch();
        }
    }
}
