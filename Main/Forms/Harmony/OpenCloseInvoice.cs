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
    public partial class OpenCloseInvoice : RASF.General.Forms.Base.DockContentForm
    {
        public OpenCloseInvoice()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdOpen.CurrentRow != null) && (this.grdOpen.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdOpen.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.openCloseInvoiceList1.Fill(Parameters);
            this.grdOpen.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdOpen.SelectedItems.Count > 0)
            {
                RASF.General.Data.OpenCloseBill Current_Contract = (RASF.General.Data.OpenCloseBill)this.grdOpen.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.openCloseInvoiceList1.Update();

                    FillGrid();

                    this.txtReason.Text = String.Empty;
                }
            }
        }

        private void grdIsHold_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

     

    }
}
