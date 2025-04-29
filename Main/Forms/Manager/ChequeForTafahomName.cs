using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ChequeForTafahomName : RASF.General.Forms.Base.DockContentForm
    {
        public ChequeForTafahomName()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.tafahomNameList1.spName = "ChequeTafahomName";
        }

        private void ChequeForTafahomName_Load(object sender, EventArgs e)
        {
            this.tafahomNameList1.Fill();
            this.grdTafahom.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.tafahomNameList1.Fill();
            this.grdTafahom.Refetch();
        }
    }
}
