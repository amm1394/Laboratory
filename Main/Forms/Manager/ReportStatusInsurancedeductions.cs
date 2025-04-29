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
    public partial class ReportStatusInsurancedeductions : RASF.General.Forms.Base.DockContentForm
    {
        public ReportStatusInsurancedeductions()
        {
            InitializeComponent();
            this.companiesCooperationTypeList1.spName = "ReportStatusInsurancedeductions";
            this.companiesCooperationTypeList2.spName = "InsuranceDeduction";
            this.ShowpnlExit = false;
        }

        private void ReportStatusInsurancedeductions_Load(object sender, EventArgs e)
        {
            this.companiesCooperationTypeList1.Fill();
            this.grdTypeDeductions.Refetch();

            this.companiesCooperationTypeList2.Fill();
            this.grdKol.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesCooperationTypeList1.Fill();
            this.grdTypeDeductions.Refetch();

            this.companiesCooperationTypeList2.Fill();
            this.grdKol.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTypeDeductions.ExportToExcel("وضعیت کسور بیمه مشتریان");

            this.grdKol.ExportToExcel("وضعیت کسور بیمه مشتریان2");
        }

        private void grdTypeDeductions_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdKol_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }
    }
}
