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
    public partial class Grant : UserControl, RASF.General.InterFaces.IRecieption
    {
        private RASF.Main.Classes.Insert_ReceiptAmount_Master Insert_ReceiptAmount_Master;
        public Grant()
        {
            InitializeComponent();
        }
        private string Assno;

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
                this.Insert_ReceiptAmount_Master.ShowReport(ReceiptAmountMasterCode, String.Format("{0}\\Report\\ReceiptofGrant.mrt", Application.StartupPath));
            }
        
        }

        private void MoneyOrder_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            General.Classes.Utility.CreateDropDow(drpCash, "CashName", "CashCode", cashList1);
            this.drpCash.SelectedIndex = 0;

            this.banksList1.Fill();

            General.Classes.Utility.CreateDropDow(drpBank, "BanksName", "Code", banksList1);
            this.drpBank.SelectedIndex = 0;

            DatePickerMoneyOrder.IsNull = true;
            Insert_ReceiptAmount_Master = new RASF.Main.Classes.Insert_ReceiptAmount_Master();
        }

        public void Reset()
        {
            this.txtMoneyOrderNo.Text = "";
            this.nbReceiptAmount.Value = 0;
            this.drpBank.SelectedIndex = 0;
            this.drpCash.SelectedIndex = 0;
            this.DatePickerMoneyOrder.IsNull = true;
        }

        public Guid UpdateData(Guid CompanyId)
        {
            Guid ReceiptAmount_Master = Insert_ReceiptAmount_Master.Update(CompanyId, 16, (Guid)drpCash.SelectedValue, Convert.ToInt32(nbReceiptAmount.Value.ToString()));
            Insert_ReceiptAmount_Master.InsertReceiptAssignment(DatePickerMoneyOrder.SelectedDateTime, txtMoneyOrderNo.Text, String.Empty, (Guid)drpBank.SelectedValue, ReceiptAmount_Master);
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

 


        private void txtMoneyOrderNo_Leave(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("AssignmentNo", String.Format("{0}", this.txtMoneyOrderNo.Text)));
            Assno = (string)RASF.General.Lists.BanksList.FillScalar("FindAssignmentNo_Select", Parameter);
            string Asstxt = this.txtMoneyOrderNo.Text;

            if (Assno == Asstxt)
            {
                MessageBox.Show("شماره حواله تکراری می باشد");
                 this.txtMoneyOrderNo.Text = "";
            }
        }

    }
}
