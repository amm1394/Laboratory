using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialOfficesDetail : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Guid OfficeCode;
        private String OfficeName;
        public FinancialOfficesDetail(String officeName, Guid officeCode, DateTime from, DateTime to)
        {
            InitializeComponent();

            this.OfficeCode = officeCode;
            this.From = from;
            this.To = to;
            this.OfficeName = officeName;
        }

        private void FinancialOfficesDetail_Load(object sender, EventArgs e)
        {
            this.grpChart.Text = String.Format("نمودار کارکرد دفتر {0}", this.OfficeName);
            this.grpOffices.Text = String.Format("کارکرد دفتر {0}", this.OfficeName);
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("OfficesCode", this.OfficeCode));

            this.amountChartDetailList1.Fill(Parameters2);
            this.grdOffice.Refetch();
            this.chartOffice.DrawLineChart("Date", "Amount", "Test");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdOffice.ExportToExcel(this.OfficeName);
        }

        private void chartOffice_Click(object sender, EventArgs e)
        {

        }
    }
}
