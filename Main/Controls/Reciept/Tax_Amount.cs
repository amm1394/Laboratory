using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Reciept
{
    public partial class Tax_Amount : UserControl, RASF.General.InterFaces.IRecieption
    {
        private RASF.Main.Classes.Insert_ReceiptAmount_Master Insert_ReceiptAmount_Master;
        public Tax_Amount()
        {
            InitializeComponent();
        }

        public Int64 Remind
        {
            set
            {
                this.nbRemind.Value = value;
            }
        }

        public Guid CashCode
        {
            get { return (Guid)drpCash.SelectedValue; }
        }

        public void ShowReport(Guid ReceiptAmountMasterCode, Boolean InformalReceipt)
        {
            if (InformalReceipt == false)
            {
                this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\ReceiptofTax.mrt", Application.StartupPath));
            }
            else
            {
                this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\ReceiptofTax-Informal.mrt", Application.StartupPath));

            }
        }

        private void MoneyOrder_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCash, "CashName", "CashCode", cashList1);
            this.drpCash.SelectedIndex = 0;

            this.banksList1.Fill();

            DatePickerMoneyOrder.IsNull = true;
            Insert_ReceiptAmount_Master = new RASF.Main.Classes.Insert_ReceiptAmount_Master();
        }

        public void Reset()
        {
            this.txtMoneyOrderNo.Text = "";
            this.nbReceiptAmount.Value = 0;
            this.drpCash.SelectedIndex = 0;
            this.DatePickerMoneyOrder.IsNull = true;
        }

        public Guid UpdateData(Guid CompanyId)
        {
            Guid ReceiptAmount_Master = Insert_ReceiptAmount_Master.Update(CompanyId, 4, (Guid)drpCash.SelectedValue, Convert.ToInt32(nbReceiptAmount.Value.ToString()));
            Insert_ReceiptAmount_Master.InsertReceiptAssignment(DatePickerMoneyOrder.SelectedDateTime, txtMoneyOrderNo.Text, String.Empty, Guid.Empty, ReceiptAmount_Master);
            return ReceiptAmount_Master;
        }

        public bool chekData(Int64 Total)
        {
            if ((Total <= Convert.ToInt32(this.nbReceiptAmount.Value)) && (String.IsNullOrWhiteSpace(txtMoneyOrderNo.Text) == false) && (DatePickerMoneyOrder.IsNull == false))
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
