using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class DiscountOfCompanies : RASF.General.Forms.Base.DockContentForm
    {
        public DiscountOfCompanies()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void DiscountOfCompanies_Load(object sender, EventArgs e)
        {
            this.discountOfCompaniesList1.Fill();
            this.grddiscount.Refetch();
        }

        private void groupBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.discountOfCompaniesList1.Fill();
            this.grddiscount.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grddiscount.ExportToExcel("شرکت های شامل تخفیف");
        }
    }
}
