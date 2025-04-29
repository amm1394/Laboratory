using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class SendGrantToNano : RASF.General.Forms.Base.DockContentForm
    {
        public SendGrantToNano()
        {
            InitializeComponent();
            this.registerGrantForViewList1.spName = "SendGrantToNano";
        }

        private void RegisterGrant_Load(object sender, EventArgs e)
        {
            this.registerGrantForViewList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.DebtorCreditorContractBase rowUser in registerGrantForViewList1)
            {
                if (rowUser.Cheched = true)
                {

                    this.registerGrantForViewList1.Update();
                }
            }
                this.registerGrantForViewList1.Fill();
                this.grdContracts.Refetch();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.registerGrantForViewList1.Fill();
            this.grdContracts.Refetch();
        }
    }
}
