using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class FollowUpIsHoldContract : RASF.General.Forms.Base.DockContentForm
    {
        public FollowUpIsHoldContract()
        {
            InitializeComponent();
        }

        private void FollowUpIsHoldContract_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.followUpIsHoldContractList1.Fill();
            this.grdFlolow.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdFlolow.SelectedItems.Count > 0)
            {
                RASF.General.Data.FollowUpIsHoldContract Current_Contract = (RASF.General.Data.FollowUpIsHoldContract)this.grdFlolow.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.followUpIsHoldContractList1.Update();

                    RefreshGrid();

                    this.txtFollow.Text = String.Empty;
                }
            }
        }

        private void grdFlolow_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdFlolow.CurrentRow != null) && (this.grdFlolow.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpFollow.Text = "قرارداد" + " " + this.grdFlolow.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpFollow.Text = "";
            }
        }
    }
}
