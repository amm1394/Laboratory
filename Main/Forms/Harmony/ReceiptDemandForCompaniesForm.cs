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
    public partial class ReceiptDemandForCompaniesForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReceiptDemandForCompaniesForm()
        {
            InitializeComponent();
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCompanies.CurrentRow != null) && (this.grdCompanies.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "شرکت" + " " + this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {           
            this.receiptDemandForCompaniesList1.Fill();
            this.grdCompanies.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdCompanies.SelectedItems.Count > 0)
            {
                RASF.General.Data.ReceiptDemandForCompanies Current_Contract = (RASF.General.Data.ReceiptDemandForCompanies)this.grdCompanies.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.receiptDemandForCompaniesList1.Update();

                    FillGrid();

                    this.txtReason.Text = String.Empty;
                }
            }
        }


    }
}
