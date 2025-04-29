using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class TransferCompaniesToMarketing : RASF.General.Forms.Base.DockContentForm
    {
        public TransferCompaniesToMarketing()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void TransferCompaniesToMarketing_Load(object sender, EventArgs e)
        {
            this.transferCompaniesToMarketingList1.Fill();
            this.grdCimpany.Refetch();
        }

        private void grdCimpany_SelectionChanged(object sender, EventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentCompany = (RASF.General.Data.Companies_Base)this.grdCimpany.CurrentRow.DataRow;
            this.grpcompany.Text = CurrentCompany.CompanyName;

        }

        private void grdCimpany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentCompany = (RASF.General.Data.Companies_Base)this.grdCimpany.CurrentRow.DataRow;
            if (this.grdCimpany.SelectedItems.Count > 0)
            {
                CurrentCompany.RowState = General.Enums.RowState.Updated;
                this.transferCompaniesToMarketingList1.Update();

                this.transferCompaniesToMarketingList1.Fill();
                this.grdCimpany.Refetch();
            }
        }
    }
}
