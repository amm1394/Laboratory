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
    public partial class Cheque : UserControl, RASF.General.InterFaces.IRecieption
    {
        private RASF.Main.Classes.Insert_ReceiptAmount_Master Insert_ReceiptAmount_Master;
        public Cheque()
        {
            InitializeComponent();
            DatePickerBank.IsNull = true;
                      
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
                this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\ReceiptCheque.mrt", Application.StartupPath));
            }
            else
            {
                this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\ReceiptCheque-Informal.mrt", Application.StartupPath));

            }
        }


        public Guid UpdateData(Guid CompanyId)
        {
            Guid ReceiptAmount_MasterCode = Insert_ReceiptAmount_Master.Update(CompanyId, 2, (Guid)drpCash.SelectedValue, Convert.ToInt64(nbReceiptAmount.Value.ToString()));
            Insert_ReceiptAmount_Master.InsertReceiptAssignment(DatePickerBank.SelectedDateTime, txtNumCheck.Text, txtBank.Text, Guid.Empty, ReceiptAmount_MasterCode);
            return ReceiptAmount_MasterCode;
        }

        private void Cheque_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCash, "CashName", "CashCode", cashList1);
            this.drpCash.SelectedIndex = 0;
            Insert_ReceiptAmount_Master = new RASF.Main.Classes.Insert_ReceiptAmount_Master();
        }


        public void Reset()
        {
            this.txtNumCheck.Text = "";
            this.nbReceiptAmount.Value = 0;
            this.txtBank.Text = "";
            this.DatePickerBank.IsNull = true;
            this.drpCash.SelectedIndex = 0;
        }

        public bool chekData(Int64 Total)
        {
            if ((Total <= Convert.ToInt64(this.nbReceiptAmount.Value)) && (String.IsNullOrWhiteSpace(txtBank.Text) == false) && (String.IsNullOrWhiteSpace(txtNumCheck.Text) == false) && (DatePickerBank.IsNull == false))
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
