using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class VoidContract : RASF.General.Forms.Base.DockContentForm
    {
        public VoidContract()
        {
            InitializeComponent();
        }

        private void VoidContract_Load(object sender, EventArgs e)
        {
            this.voidContractList1.Fill();

            grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = String.Format("قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value);
            }
            else
            {
                this.grpContracts.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.voidContract Current_Contract = (RASF.General.Data.voidContract)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.voidContractList1.Update();

                    FillContract();

                    this.txtVoid.Text = String.Empty;
                }
            }
            
        }

        private void FillContract()
        {
            this.voidContractList1.Fill();

            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.voidContractList1.Fill();

            this.grdContracts.Refetch();
        }
    }
}
