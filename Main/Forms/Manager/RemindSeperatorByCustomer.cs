using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class RemindSeperatorByCustomer : RASF.General.Forms.Base.DockContentForm
    {
        public RemindSeperatorByCustomer()
        {
            InitializeComponent();
        }

        private void RemindSeperatorByCustomer_Load(object sender, EventArgs e)
        {
            this.remindSeparatedbycustomerCashList1.Fill();
            this.grdCash.Refetch();

            this.remindSeparatedbycustomerCreditorList1.Fill();
            this.grdCredit.Refetch();

        }
    }
}
