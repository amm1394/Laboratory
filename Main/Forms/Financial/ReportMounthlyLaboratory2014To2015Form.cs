using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportMounthlyLaboratory2014To2015Form : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthlyLaboratory2014To2015Form()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
          //  this.ShowpnlSave = false;

        }

        private void ReportMounthlyLaboratoryForm_Load(object sender, EventArgs e)
        {
           this.reportMounthlyLaboratory2014To2015List1.Fill();
           this.grdReport.Refetch();

            this.monthlyReport2014To2015List1.Fill();
            this.grdkol.Refetch();

       }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2014To2015List1.Fill();
            this.grdReport.Refetch();

            this.monthlyReport2014To2015List1.Fill();
            this.grdkol.Refetch();

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ماهانه آزمایشگاه ها");
            this.grdReport.ExportToExcel("گزارش ماهانه آزمایشگاه ها");
            MessageBox.Show("ماهانه کل");
            this.grdkol.ExportToExcel("گزارش ماهانه کل");
          
        }

        private void grdkol_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MonthlyReport CurrentRow = (RASF.General.Data.MonthlyReport)this.grdkol.CurrentRow.DataRow;
            RASF.Main.Forms.Manager.DetaiolOfRecieptForm Detail = new Manager.DetaiolOfRecieptForm(CurrentRow.Id);
            Detail.Show();
        }

       
    }
}
