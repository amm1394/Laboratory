using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Payment
{
    public partial class WageOfAgencyPay : UserControl, RASF.General.InterFaces.IPayment
    {
        private RASF.Main.Classes.Insert_PaymentAmount_Master Insert_PaymentAmount_Master;
        public WageOfAgencyPay()
        {
            InitializeComponent();
        }

        //public Int64 Remind
        //{
        //    set
        //    {
        //        this.nbRemind.Value = value;
        //    }
        //}

        public Guid CashCode
        {
            get { return (Guid)drpCash.SelectedValue; }
        }

        public void ShowReport(Guid ReceiptAmountMasterCode, Boolean InformalPayments)
        {
            //if (InformalPayments == false)
            //{
            //    this.Insert_PaymentAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\Paymentoffunds.mrt", Application.StartupPath));
            //}
            //else
            //{
            //    this.Insert_PaymentAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\Paymentoffunds-Informal.mrt", Application.StartupPath));
            //}
        }

        public Guid UpdateData(Guid CompanyId)
        {
            return Insert_PaymentAmount_Master.Update(CompanyId, 9, (Guid)drpCash.SelectedValue, Convert.ToInt32(nbReceiptAmount.Value.ToString()));
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCash, "CashName", "CashCode", cashList1);
            this.drpCash.SelectedIndex = 0;
            Insert_PaymentAmount_Master = new RASF.Main.Classes.Insert_PaymentAmount_Master();
        }


        public void Reset()
        {
            this.nbReceiptAmount.Value = 0;
            this.drpCash.SelectedIndex = 0;
        }


        public bool chekData(Int64 Total)
        {
            if (Total <= Convert.ToInt32(this.nbReceiptAmount.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}