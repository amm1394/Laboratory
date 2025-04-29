using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class PiecesNotExitedBonyad : RASF.General.Forms.Base.DockContentForm
    {
        public PiecesNotExitedBonyad()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.cultchStoreList1.spName = "PiecesNotExitedBonyad";
        }

        private void CultchStore_Load(object sender, EventArgs e)
        {
            this.cultchStoreList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.cultchStoreList1.Fill();
            this.grdContracts.Refetch();
        }
    }
}
