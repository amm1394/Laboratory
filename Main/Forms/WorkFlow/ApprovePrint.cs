using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Main.Forms.WorkFlow
{
    public partial class ApprovePrint : RASF.General.Forms.Base.DockContentForm
    {
        public ApprovePrint()
        {
            InitializeComponent();
        }

        private void ApprovePrint_Load(object sender, EventArgs e)
        {
            this.approvePrintList1.Fill();
            this.grdapprove.Refetch();
        }
    }
}
