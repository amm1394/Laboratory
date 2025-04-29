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
    public partial class RemindCreditor : UserControl, RASF.General.InterFaces.IRecieption
    {
        private RASF.Main.Classes.Insert_ReceiptAmount_Master Insert_ReceiptAmount_Master;
        public RemindCreditor()
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
 //           this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\Receiptoffunds.mrt", Application.StartupPath));
        }

        public Guid UpdateData(Guid CompanyId)
        {
            return Guid.Empty;
        }

        private void Cash_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCash, "CashName", "CashCode", cashList1);
            this.drpCash.SelectedIndex = 0;
            Insert_ReceiptAmount_Master = new RASF.Main.Classes.Insert_ReceiptAmount_Master();
        }


        public void Reset()
        {
            this.drpCash.SelectedIndex = 0;
        }


        public bool chekData(Int64 Total)
        {
            if (Total <= Convert.ToInt64(this.nbRemind.Value))
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