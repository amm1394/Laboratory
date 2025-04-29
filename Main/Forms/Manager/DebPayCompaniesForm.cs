using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class DebPayCompaniesForm : RASF.General.Forms.Base.DockContentForm
    {
        public DebPayCompaniesForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void DebPayCompaniesForm_Load(object sender, EventArgs e)
        {
            this.processOfCustomerList1.Fill();
            this.grid1.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grid1.ExportToExcel("گزارش عملکرد مشتری");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.processOfCustomerList1.Fill();
            this.grid1.Refetch();
        }

        private void grid1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }
    }
}
