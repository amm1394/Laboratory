using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ManagerOfDiscount : RASF.General.Forms.Base.DockContentForm
    {
        public ManagerOfDiscount()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Data.DeliveryDay Current_Contract = (RASF.General.Data.DeliveryDay)this.grdDiscount.SelectedItems[0].GetRow().DataRow;

            Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
            this.managerOfDiscountList1.Update();

            this.managerOfDiscountList1.Fill();
            this.grdDiscount.Refetch();
        }

        private void ManagerOfDiscount_Load(object sender, EventArgs e)
        {
            this.managerOfDiscountList1.Fill();
            this.grdDiscount.Refetch();
        }
    }
}
