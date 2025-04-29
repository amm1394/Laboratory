using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class TAX : RASF.General.Forms.Base.DockContentForm
    {
        public TAX()
        {
            InitializeComponent();
        }

        private void TAX_Load(object sender, EventArgs e)
        {
            this.taxList1.Fill();
            this.grdTax.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.taxList1.Update();
        }

      
    }
}
