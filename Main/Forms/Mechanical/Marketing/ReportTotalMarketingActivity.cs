using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ReportTotalMarketingActivity : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle PazireshFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle BazaryabiFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TakhirFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ImportantFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TwoFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;

        public ReportTotalMarketingActivity()
        {
            InitializeComponent();
            this.ShowpnlExit = false;


            this.PazireshFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.PazireshFormat.BackColor = Color.Purple;
            this.PazireshFormat.ForeColor = Color.Black;

            this.BazaryabiFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.BazaryabiFormat.BackColor = Color.Green;
            this.BazaryabiFormat.ForeColor = Color.Black;

            this.TakhirFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TakhirFormat.BackColor = Color.Red;
            this.TakhirFormat.ForeColor = Color.Black;

            this.ImportantFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ImportantFormat.BackColor = Color.Goldenrod;
            this.ImportantFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;

            this.TwoFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TwoFormat.BackColor = Color.Yellow;
            this.TwoFormat.ForeColor = Color.Black;

            this.FourFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourFormat.BackColor = Color.Red;
            this.FourFormat.ForeColor = Color.Black;
        }

        private void ReportTotalMarketingActivity_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@MarketingExpert", RASF.General.Classes.Global.CurrentUserCode));
            this.reportTotalMarketingActivityList1.Fill(Parameter);
            this.grdReport.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReport.ExportToExcel("گزارش کل شرکت های بازاریابی");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@MarketingExpert", RASF.General.Classes.Global.CurrentUserCode));
            this.reportTotalMarketingActivityList1.Fill(Parameter);
            this.grdReport.Refetch();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MarketingActivity CurrentRow = (RASF.General.Data.MarketingActivity)this.grdReport.CurrentRow.DataRow;
            RASF.Main.Forms.Marketing.ShowMarketingActivity ShowMarketingActivity = new Marketing.ShowMarketingActivity(CurrentRow.CompaniesCode);
            ShowMarketingActivity.Show();
        }

        private void grdReport_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
          
            if (Convert.ToInt16(e.Row.Cells["DiffDate"].Value) >=5)
            {
                e.Row.Cells["DiffDate"].FormatStyle = this.TakhirFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["CodeStatuse"].Value) == 7)
            {
                e.Row.Cells["StatuseName"].FormatStyle = this.BazaryabiFormat;
            }

            if (Convert.ToBoolean(e.Row.Cells["ImportantCompany"].Value) == true)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.ImportantFormat;
            }

            if (Convert.ToString(e.Row.Cells["StringdateRecieption"].Value) != "")
            {
                e.Row.Cells["StringdateRecieption"].FormatStyle = this.PazireshFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 60)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.TwoFormat;
            }

            if (Convert.ToInt32(e.Row.Cells["Recdiif"].Value) > 120)
            {
                e.Row.Cells["ReceptionDate"].FormatStyle = this.FourFormat;
            }
        }
    }
}
