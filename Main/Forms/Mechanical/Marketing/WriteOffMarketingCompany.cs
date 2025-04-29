using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class WriteOffMarketingCompany : RASF.General.Forms.Base.DockContentForm
    {
        public WriteOffMarketingCompany()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void WriteOffMarketingCompany_Load(object sender, EventArgs e)
        {
            this.writeOffMarketingCompanyList1.Fill();
            this.grdcompany.Refetch();
        }

        private void grdcompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdcompany.SelectedItems.Count > 0)
            {
                RASF.General.Data.MarketingActivity CurrentRow = (RASF.General.Data.MarketingActivity)this.grdcompany.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.writeOffMarketingCompanyList1.Update();
            }
        }

        private void grdcompany_SelectionChanged(object sender, EventArgs e)
        {
           
            RASF.General.Data.MarketingActivity CurrentCompany = (RASF.General.Data.MarketingActivity)this.grdcompany.CurrentRow.DataRow;
            if (CurrentCompany != null)
            {
                this.grpcompany.Text = "نام شرکت جهت صدور صورت حساب  " + CurrentCompany.CompanyName;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.writeOffMarketingCompanyList1.Fill();
            this.grdcompany.Refetch();
        }
    }
}
