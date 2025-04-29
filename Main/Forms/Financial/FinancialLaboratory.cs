using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public FinancialLaboratory()
        {
            InitializeComponent();
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.financialLaboratoryList1.Fill(Parameters1);
            grdTotal.Refetch();
            this.chartTotal.DrawBarChart("Amount", "LaboratoryName", String.Format("گزارش از تاریخ {0}  لغایت {1}",RASF.General.Classes.Utility.DateConvertor(e.From),RASF.General.Classes.Utility.DateConvertor(e.To)));
        }

        private void FinancialOffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTotal.ExportToExcel("کارکرد آزمایشگاه ها");
        }

        private void grdTotal_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.FinancialLaboratory CurrentRow = (RASF.General.Data.FinancialLaboratory)this.grdTotal.CurrentRow.DataRow;
            if (CurrentRow.LaboratoryCode != Guid.Empty)
            {
                RASF.Main.Forms.Financial.FinancialLaboratoryDetail FinancialLaboratoryDetail = new FinancialLaboratoryDetail(CurrentRow.LaboratoryName, CurrentRow.LaboratoryCode, this.From, this.To);
                FinancialLaboratoryDetail.MdiParent = this.MdiParent;
                FinancialLaboratoryDetail.Show();
            }
        }

        private void grdTotal_SelectionChanged(object sender, EventArgs e)
        {
            RASF.General.Data.FinancialLaboratory CurrentRow = (RASF.General.Data.FinancialLaboratory)this.grdTotal.CurrentRow.DataRow;

            if (CurrentRow.LaboratoryCode != Guid.Empty)
            {
                List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", CurrentRow.LaboratoryCode));
                this.financialMainTestList1.Fill(Parameters2);
                this.chartMainTest.DrawBarChart("Amount", "MainTestName", "Test");
            }
            else
            {
                this.financialMainTestList1.Clear();
                this.chartMainTest.Series.Clear();
            }
            this.grdMainTest.Refetch();
        }

        private void grdMainTest_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.FinancialLaboratory CurrentRow = (RASF.General.Data.FinancialLaboratory)this.grdMainTest.CurrentRow.DataRow;
            if (CurrentRow.MainCode != Guid.Empty)
            {
                RASF.Main.Forms.Financial.FinancialMainTestDetail FinancialMainTestDetail = new FinancialMainTestDetail(CurrentRow.MainTestName, CurrentRow.MainCode, this.From, this.To);
                FinancialMainTestDetail.MdiParent = this.MdiParent;
                FinancialMainTestDetail.Show();
            }
        }
    }
}
