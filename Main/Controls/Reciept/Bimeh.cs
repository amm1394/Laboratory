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
    public partial class Bimeh : UserControl, RASF.General.InterFaces.IRecieption
    {
        private RASF.Main.Classes.Insert_ReceiptAmount_Master Insert_ReceiptAmount_Master;
        public Bimeh()
        {
            InitializeComponent();
        }

        public Int64 Remind
        {
            set
            {
            }
        }

        public Guid CashCode
        {
            get { return (Guid)drpCash.SelectedValue; }
        }

        public void ShowReport(Guid ReceiptAmountMasterCode, Boolean InformalReceipt)
        {
            //if (InformalReceipt == false)
            //{
            //    this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\Receiptoffunds.mrt", Application.StartupPath));
            //}
            //else
            //{
            //    this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\Receiptoffunds-Informal.mrt", Application.StartupPath));

            //}
        }

        public Guid UpdateData(Guid CompanyId)
        {
            return Insert_ReceiptAmount_Master.Update(CompanyId, 10, (Guid)drpCash.SelectedValue, Convert.ToInt32(nbReceiptAmount.Value.ToString()));
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
            this.nbReceiptAmount.Value = 0;
            this.drpCash.SelectedIndex = 0;
        }


        public bool chekData(Int64 Total)
        {
            if (Total > 0)
            {
                this.nbReceiptAmount.Value = Total;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}