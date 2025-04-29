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
    public partial class FinancialLaboratoryNumberOfTestsDeliveryDay : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public FinancialLaboratoryNumberOfTestsDeliveryDay()
        {
            InitializeComponent();
            this.financialLaboratoryNumberOfTestsDetailList1.spName = "FinancialLaboratoryMasterTestDeliveryDay";
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.financialLaboratoryNumberOfTestsDeliveryDayList1.Fill(Parameters1);
            grdTotal.Refetch();
            this.chartTotal.DrawBarChart("NumberOfTests", "LaboratoryName", String.Format("گزارش از تاریخ {0}  لغایت {1}", RASF.General.Classes.Utility.DateConvertor(e.From), RASF.General.Classes.Utility.DateConvertor(e.To)));
        }

        private void FinancialOffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTotal.ExportToExcel("کارکرد آزمایشگاه ها");
        }

       private void grdTotal_SelectionChanged(object sender, EventArgs e)
        {
         RASF.General.Data.FinancialLaboratoryNumberOfTests CurrentRow = (RASF.General.Data.FinancialLaboratoryNumberOfTests)this.grdTotal.CurrentRow.DataRow;

            if (CurrentRow.LaboratoryCode != Guid.Empty)
            {
                List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", CurrentRow.LaboratoryCode));
                this.financialLaboratoryNumberOfTestsDetailList1.Fill(Parameters2);
                this.ChartDetail.DrawBarChart("NumberOfTests", "MainTestName", "Test");
            }
            else
            {
                this.financialLaboratoryNumberOfTestsDetailList1.Clear();
               this.ChartDetail.Series.Clear();
            }
            this.grdDetail.Refetch();
        }

       private void button1_Click(object sender, EventArgs e)
       {
           if (printDialog1.ShowDialog() == DialogResult.OK)
           {
               printPreviewDialog1.Document = gridEXPrintDocument1;
               printPreviewDialog1.ShowInTaskbar = true;
               printPreviewDialog1.MinimizeBox = true;
               printPreviewDialog1.PrintPreviewControl.Zoom = 1;
               printPreviewDialog1.WindowState = FormWindowState.Maximized;
               gridEXPrintDocument1.DefaultPageSettings.Landscape = true;
               gridEXPrintDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
               gridEXPrintDocument1.PrinterSettings.Copies = printDialog1.PrinterSettings.Copies;
               gridEXPrintDocument1.Print();
           }
       }
        }
    }

