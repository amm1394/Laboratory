using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class ChengeForAmountOfBill : RASF.General.Forms.Base.DockContentForm
    {
        public ChengeForAmountOfBill()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void ChengeForAmountOfBill_Load(object sender, EventArgs e)
        {
            this.chengeForAmountOfBillList1.Fill();
            this.grdChangeAmount.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdChangeAmount.ExportToExcel("صورت حساب هایی که مبلغ شان تغییر کرده است");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.chengeForAmountOfBillList1.Fill();
            this.grdChangeAmount.Refetch();
        }

      
    }
}
