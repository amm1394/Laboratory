using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class RepotOfGrant : RASF.General.Forms.Base.DockContentForm
    {
        public RepotOfGrant()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void RepotOfGrant_Load(object sender, EventArgs e)
        {
            this.repotOfGrantList1.Fill();
            this.grdgrant.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdgrant.ExportToExcel("گرنت های ثبت شده");
        }
    }
}
