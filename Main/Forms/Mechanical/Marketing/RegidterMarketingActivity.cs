using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class RegidterMarketingActivity : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle PazireshFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TakhirFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle ImportantFormat;
        public RegidterMarketingActivity()
        {
            InitializeComponent();
            this.ShowpnlExit = false;

            this.PazireshFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.PazireshFormat.BackColor = Color.Purple;
            this.PazireshFormat.ForeColor = Color.Black;

            this.TakhirFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TakhirFormat.BackColor = Color.Red;
            this.TakhirFormat.ForeColor = Color.Black;

            this.ImportantFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.ImportantFormat.BackColor = Color.Goldenrod;
            this.ImportantFormat.ForeColor = Color.Black;

            this.activeNonActiveList1.spName = "ActionType";
        }

        private void RegidterMarketingActivity_Load(object sender, EventArgs e)
        {
            this.trackingStatusMarketingList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdcompany.RootTable.Columns["TrackingStatus"], this.trackingStatusMarketingList1, "CodeStatuse", "StatuseName");
            this.grdcompany.RootTable.Columns["TrackingStatus"].DefaultValue = this.trackingStatusMarketingList1[0].CodeStatuse;

            this.activeNonActiveList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdcompany.RootTable.Columns["ActionCode"], this.activeNonActiveList1, "ActionCode", "ActionName");
            this.grdcompany.RootTable.Columns["ActionCode"].DefaultValue = this.activeNonActiveList1[0].ActionCode;

            List<System.Data.SqlClient.SqlParameter> parameter = new List<System.Data.SqlClient.SqlParameter>();
            parameter.Add(new System.Data.SqlClient.SqlParameter("ConnectorId", RASF.General.Classes.Global.CurrentUserCode));
            this.marketingActivityList1.Fill(parameter);
            this.grdcompany.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdcompany.SelectedItems.Count > 0)
            {
                RASF.General.Data.MarketingActivity MarketingActivity = (RASF.General.Data.MarketingActivity)this.grdcompany.SelectedItems[0].GetRow().DataRow;
                if (MarketingActivity != null && string.IsNullOrWhiteSpace(MarketingActivity.Description) == false && MarketingActivity.TrackingStatus != 0  && faDatePicker1.SelectedDateTime != DateTime.MinValue && DatePickerReceptionDate.SelectedDateTime != DateTime.MinValue)
                {
                    MarketingActivity.RowState = General.Enums.RowState.Added;
                    MarketingActivity.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.marketingActivityList1.Update();

                    txtDesc.Text = "";
                }
                else
                {
                    MessageBox.Show("وضعیت پیگیری را مشخص و تاریخ و توضیحات را وارد نمایید");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> parameter = new List<System.Data.SqlClient.SqlParameter>();
            parameter.Add(new System.Data.SqlClient.SqlParameter("ConnectorId", RASF.General.Classes.Global.CurrentUserCode));
            this.marketingActivityList1.Fill(parameter);
            this.grdcompany.Refetch();
        }

        private void grdcompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MarketingActivity CurrentRow = (RASF.General.Data.MarketingActivity)this.grdcompany.CurrentRow.DataRow;
            RASF.Main.Forms.Marketing.ShowMarketingActivity ShowMarketingActivity = new Marketing.ShowMarketingActivity(CurrentRow.CompaniesCode);
            ShowMarketingActivity.Show();
        }

        private void grdcompany_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["StringdateRecieption"].Value) != "")
            {
                e.Row.Cells["StringdateRecieption"].FormatStyle = this.PazireshFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["DiffDate"].Value) >= 5)
            {
                e.Row.Cells["DiffDate"].FormatStyle = this.TakhirFormat;
            }

            if (Convert.ToBoolean(e.Row.Cells["ImportantCompany"].Value) == true)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.ImportantFormat;
            }
        }
    }
}