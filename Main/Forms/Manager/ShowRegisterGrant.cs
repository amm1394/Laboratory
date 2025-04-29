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
    public partial class ShowRegisterGrant : RASF.General.Forms.Base.DockContentForm
    {
        public ShowRegisterGrant()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.viewGrantList1.spName = "ShowRegisterGrant";
        }

        private void ShowRegisterGrant_Load(object sender, EventArgs e)
        {
            this.viewGrantList1.Fill();
            this.grdGrant.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.viewGrantList1.Fill();
            this.grdGrant.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdGrant.ExportToExcel("گرنت");
        }
    }
}
