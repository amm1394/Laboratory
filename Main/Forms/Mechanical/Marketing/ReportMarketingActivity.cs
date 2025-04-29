using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Marketing
{
    
    public partial class ReportMarketingActivity : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime to, from;
        private DateTime to1, from1;
        Int64 CodeMarketing;
        public ReportMarketingActivity()
        {
            InitializeComponent();
            
            this.ShowpnlSave = false;
            if (RASF.General.Classes.Global.CurrentUserCode.ToString() == ("e1a9b385-c1f8-4be0-9130-11d8f4057987"))
            {
               this.ShowpnlExit = true;
            }
            else
            {
              this.ShowpnlExit = false;
            }
            pickDate2_DateSelected(new RASF.General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            pickDate1_DateSelected(new RASF.General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void ReportMarketingActivity_Load(object sender, EventArgs e)
        {
            pickDate2_DateSelected(new RASF.General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            pickDate1_DateSelected(new RASF.General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));


            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.reportOfMarketingActivityKolList1.Fill(Parameters1);
            this.grdCompany.Refetch();

        }

        private void pickDate2_DateSelected(RASF.General.Events.ReturnSelectedDatesEventArgs e)
        {
             this.from =e.From;
             this.to=e.To;
             if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
             {
                 from = DateTime.Now; to = DateTime.Now;
             }
             else
             {
                 List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                 Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", from));
                 Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", to));
                 Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                 this.reportOfMarketingActivityList1.Fill(Parameters1);
                 this.grdReport.Refetch();

             }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", from));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", to));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.reportOfMarketingActivityList1.Fill(Parameters1);
            this.grdReport.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameters3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters3.Add(new System.Data.SqlClient.SqlParameter("From", from1));
            Parameters3.Add(new System.Data.SqlClient.SqlParameter("To", to1));
            Parameters3.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.reportOfMarketingActivityTrackingDateList1.Fill(Parameters3);
            this.grdReport2.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.reportOfMarketingActivityKolList1.Fill(Parameters2);
            this.grdCompany.Refetch();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "Description":
                    if (this.grdReport.SelectedItems.Count > 0)
                    {
                        RASF.General.Data.MarketingActivity CurrentRow = (RASF.General.Data.MarketingActivity)this.grdReport.SelectedItems[0].GetRow().DataRow;
                        CurrentRow.RowState = General.Enums.RowState.Updated;
                        this.reportOfMarketingActivityList1.Update();
                    }

                    List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", from));
                    Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", to));
                    Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                    this.reportOfMarketingActivityList1.Fill(Parameters1);
                    this.grdReport.Refetch();
                    break;
                case "CompanyName":
                    Guid CodeCompany = (Guid)(this.grdReport.CurrentRow.Cells["CompaniesCode"].Value);
                    RASF.Main.Forms.Marketing.ShowMarketingActivity ShowMarket = new RASF.Main.Forms.Marketing.ShowMarketingActivity(CodeCompany);
                    ShowMarket.Show();
                    break;

            }
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.from1 = e.From;
            this.to1 = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                from1 = DateTime.Now; to1 = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", from1));
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", to1));
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.reportOfMarketingActivityTrackingDateList1.Fill(Parameters1);
                this.grdReport2.Refetch();


            }
        }

        private void grdReport2_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Guid CodeCompany = (Guid)(this.grdReport.CurrentRow.Cells["CompaniesCode"].Value);
            RASF.Main.Forms.Marketing.ShowMarketingActivity ShowMarket = new RASF.Main.Forms.Marketing.ShowMarketingActivity(CodeCompany);
            ShowMarket.Show();
        }

        private void grdReport_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdReport.SelectedItems.Count > 0 && this.grdReport.CurrentRow.Cells["Code"].Value != null)
            {
                textBox1.Text = (string)this.grdReport.CurrentRow.Cells["Description"].Value;
                CodeMarketing = (Int64)this.grdReport.CurrentRow.Cells["Code"].Value;
            }
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Code", CodeMarketing));
            this.showMessagingMarketingList1.Fill(Parameter);
            this.grdMessage.Refetch();

            if (this.showMessagingMarketingList1.Count() >0)
            {
                this.txtSender.Text = (string)this.grdMessage.CurrentRow.Cells["MessageSender"].Value;
                this.txtReceiver.Text = (string)this.grdMessage.CurrentRow.Cells["MessageReceiver"].Value;
            }

        }

        private void grdReport2_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdReport2.SelectedItems.Count > 0 && this.grdReport2.CurrentRow.Cells["Code"].Value != null)
            {
                textBox1.Text = (string)this.grdReport2.CurrentRow.Cells["Description"].Value;
                CodeMarketing = (Int64)this.grdReport2.CurrentRow.Cells["Code"].Value;
            }

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Code", CodeMarketing));
            this.showMessagingMarketingList1.Fill(Parameter);
            this.grdMessage.Refetch();

            if (this.showMessagingMarketingList1.Count() > 0)
            {
                this.txtSender.Text = (string)this.grdMessage.CurrentRow.Cells["MessageSender"].Value;
                this.txtReceiver.Text = (string)this.grdMessage.CurrentRow.Cells["MessageReceiver"].Value;
            }
        }

        private void grdCompany_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdCompany.SelectedItems.Count > 0 && this.grdCompany.CurrentRow.Cells["Code"].Value != null)
            {
                textBox1.Text = (string)this.grdCompany.CurrentRow.Cells["Description"].Value;
                CodeMarketing = (Int64)this.grdCompany.CurrentRow.Cells["Code"].Value;
            }

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("Code", CodeMarketing));
            this.showMessagingMarketingList1.Fill(Parameter);
            this.grdMessage.Refetch();

            if (this.showMessagingMarketingList1.Count() > 0)
            {
                this.txtSender.Text = (string)this.grdMessage.CurrentRow.Cells["MessageSender"].Value;
                this.txtReceiver.Text = (string)this.grdMessage.CurrentRow.Cells["MessageReceiver"].Value;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //RASF.Main.Forms.Marketing.MessagingMarketing Marketing = new RASF.Main.Forms.Marketing.MessagingMarketing(CodeMarketing);
            //Marketing.Show();
        }

        private void groupBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Marketing.MessagingMarketing Marketing = new RASF.Main.Forms.Marketing.MessagingMarketing(CodeMarketing);
            Marketing.Show();
        }
    }
}

