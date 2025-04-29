using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class OrderStatuseCashCompany : RASF.General.Forms.Base.DockContentForm
    {
        public OrderStatuseCashCompany()
        {
            InitializeComponent();
        }

        private void OrderStatuseCashCompany_Load(object sender, EventArgs e)
        {
            FillGrid();
            this.cashOrderStatusList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdcash.RootTable.Columns["OrderStatus"], this.cashOrderStatusList1, "Id", "StatusOrder");
            this.grdcash.RootTable.Columns["OrderStatus"].DefaultValue = "";

            General.Classes.Utility.Create_DropDown(this.grdCredit.RootTable.Columns["OrderStatus"], this.cashOrderStatusList1, "Id", "StatusOrder");
            this.grdCredit.RootTable.Columns["OrderStatus"].DefaultValue = "";
        }

        private void FillGrid()
        {
            this.orderStatusCashCompanyList1.Fill();
            this.orderStatusCreditCompanyList1.Fill();

            this.grdcash.Refetch();
            this.grdCredit.Refetch();

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.orderStatusCashCompanyList1.Update();
            this.orderStatusCreditCompanyList1.Update();

            FillGrid();
        }
    }
}
