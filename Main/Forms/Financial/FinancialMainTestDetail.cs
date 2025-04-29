using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialMainTestDetail : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Guid MainCode;
        private String MainTestName;
        public FinancialMainTestDetail(String MainTestName, Guid MainCode, DateTime from, DateTime to)
        {
            InitializeComponent();

            this.MainCode = MainCode;
            this.From = from;
            this.To = to;
            this.MainTestName = MainTestName;
        }

        private void FinancialOfficesDetail_Load(object sender, EventArgs e)
        {
            this.grpChart.Text = String.Format("نمودار کارکرد آزمون {0}", this.MainTestName);
            this.grpOffices.Text = String.Format("کارکرد آزمون {0}", this.MainTestName);
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("MainCode", this.MainCode));

            this.amountChartMainTestDetailList1.Fill(Parameters2);
            this.grdMainTest.Refetch();
            this.chartMsinTest.DrawLineChart("Date", "Amount", "Test");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdMainTest.ExportToExcel(this.MainTestName);
        }
    }
}
