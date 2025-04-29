using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class Debtors_AgeBalance : RASF.General.Forms.Base.DockContentForm
    {
        public Debtors_AgeBalance()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            
        }

        private void Debtors_AgeBalance_Load(object sender, EventArgs e)
        {
            this.bedBesCompaniesBaseFinancialYear_1393List1.Fill();
            this.grd93.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1394List1.Fill();
            this.grd94.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1395List1.Fill();
            this.grd95.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1396List1.Fill();
            this.grd96.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1397List1.Fill();
            this.grd97.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.bedBesCompaniesBaseFinancialYear_1393List1.Fill();
            this.grd93.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1394List1.Fill();
            this.grd94.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1395List1.Fill();
            this.grd95.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1396List1.Fill();
            this.grd96.Refetch();

            this.bedBesCompaniesBaseFinancialYear_1397List1.Fill();
            this.grd97.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سال 93");
            this.grd93.ExportToExcel("سال 93");

            MessageBox.Show("سال 94");
            this.grd94.ExportToExcel("سال 94");

            MessageBox.Show("سال 95");
            this.grd95.ExportToExcel("سال 95");

            MessageBox.Show("سال 96");
            this.grd96.ExportToExcel("سال 96");

            MessageBox.Show("سال 97");
            this.grd97.ExportToExcel("سال 97");

        }
    }
}
