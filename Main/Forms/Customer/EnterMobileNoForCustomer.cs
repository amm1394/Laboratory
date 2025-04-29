using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Customer
{
    [System.ComponentModel.Category("RASF")]
    public partial class EnterMobileNoForCustomer : RASF.General.Forms.Base.DockContentForm
    {
        public EnterMobileNoForCustomer()
        {
            InitializeComponent();
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            this.enterMobileNoForCustomerList1.Fill();
            this.grdCompany.Refetch();

            this.grdCompany.RemoveBindingContextChanged();

       }

        private void Banks_Save(object sender, EventArgs e)
        {
            this.enterMobileNoForCustomerList1.Update();
        }
    }
}
