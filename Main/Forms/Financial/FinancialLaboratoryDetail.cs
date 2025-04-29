using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinancialLaboratoryDetail : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Guid LaboratoryCode;
        private String LaboratoryName;
        public FinancialLaboratoryDetail(String LaboratoryName, Guid LaboratoryCode, DateTime from, DateTime to)
        {
            InitializeComponent();

            this.LaboratoryCode = LaboratoryCode;
            this.From = from;
            this.To = to;
            this.LaboratoryName = LaboratoryName;
        }

        private void FinancialOfficesDetail_Load(object sender, EventArgs e)
        {
            this.grpChart.Text = String.Format("نمودار کارکرد آزمایشگاه {0}", this.LaboratoryName);
            this.grpOffices.Text = String.Format("کارکرد آزمایشگاه {0}", this.LaboratoryName);
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", this.LaboratoryCode));

            this.amountChartLaboratoryDetailList1.Fill(Parameters2);
            this.grdLaboratory.Refetch();
            this.chartLaboratory.DrawLineChart("Date", "Amount", "Test");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdLaboratory.ExportToExcel(this.LaboratoryName);
        }
    }
}
