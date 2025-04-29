using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class BeDestroyedReport1Form : RASF.General.Forms.Base.DockContentForm
    {
        public BeDestroyedReport1Form()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.cultchStoreList1.spName = "BeDestroyedReport1";
          //  this.ShowpnlSave = false;
        }

        private void CultchStore_Load(object sender, EventArgs e)
        {
            this.cultchStoreList1.Fill();
            this.grdContracts.Refetch();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.CultchStore CurrentRow = (RASF.General.Data.CultchStore)this.grdContracts.CurrentRow.DataRow;
            CurrentRow.RowState = RASF.General.Enums.RowState.Updated;
            this.cultchStoreList1.Update();

            this.cultchStoreList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.cultchStoreList1.Fill();
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("نمونه های انیارها");
        }
    }
}
