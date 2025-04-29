using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.PeymentAmount
{
    public partial class PayMentAmount : RASF.General.Forms.Base.DockContentForm
    {
        List<RASF.General.InterFaces.IPayment> PaymentControl = new List<General.InterFaces.IPayment>();
        public PayMentAmount()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void PayMentAmount_Load(object sender, EventArgs e)
        {
            this.PaymentControl.Add(new RASF.Main.Controls.Payment.CashPay());
            this.PaymentControl.Add(new RASF.Main.Controls.Payment.WageOfAgencyPay());

            this.copmanyPaymentList1.Fill();
            this.grdCompany.Refetch();

            this.paymentTypesList1.Fill();


            General.Classes.Utility.CreateDropDow(drppayment, "Name", "PaymentTypeCode", paymentTypesList1);
            this.drppayment.SelectedIndex = 0;

           // chkPrint.Checked = true;
        }

        private void drppayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlContain.Controls.Clear();
            this.pnlContain.Controls.Add((UserControl)this.PaymentControl[this.drppayment.SelectedIndex]);
            this.pnlContain.Controls[0].Dock = DockStyle.Right;
        }

        private void grdCompany_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCompany.CurrentRow != null) && (this.grdCompany.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpCompany.Text = this.grdCompany.CurrentRow.Cells["CompanyName"].Value.ToString();
            }

            ((RASF.General.InterFaces.IPayment)this.pnlContain.Controls[0]).Reset();
          //  this.chkPrint.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Guid ReciptCode = ((RASF.General.InterFaces.IPayment)this.pnlContain.Controls[0]).UpdateData((Guid)this.grdCompany.CurrentRow.Cells["CompaniesCode"].Value);
            Boolean InformalPayments = (Boolean)this.grdCompany.CurrentRow.Cells["InformalFactor"].Value;
            ((RASF.General.InterFaces.IPayment)this.pnlContain.Controls[0]).ShowReport(ReciptCode, InformalPayments);

            this.copmanyPaymentList1.Fill();
            this.grdCompany.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.copmanyPaymentList1.Fill();
            this.grdCompany.Refetch();

            this.paymentTypesList1.Fill();
        }
    }
}
