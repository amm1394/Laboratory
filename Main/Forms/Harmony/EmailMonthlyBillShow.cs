using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class EmailMonthlyBillShow : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public EmailMonthlyBillShow()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void EmailMonthlyBillShow_Load(object sender, EventArgs e)
        {

        }

        private void pickDate1_DateSelected(RASF.General.Events.ReturnSelectedDatesEventArgs e)
        {
            From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.emailMonthlyBillShowList1.Fill(Parameter);
                this.grdEmail.Refetch();
                From = e.From;
                To = e.To;
            }
        }

        private void grdEmail_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.emailMonthlyBillShowList1.Fill(Parameters);
            String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

            Aspose.Words.Document doc;

            doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.EmailMonthlyBill));
            Report2.Load(String.Format("{0}\\Report\\EmailMonthlyBillShow.mrt", Application.StartupPath));

            Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Bmp);
            SaveOption.PrettyFormat = true;
            SaveOption.UseAntiAliasing = true;
            SaveOption.UseHighQualityRendering = true;



            doc.Range.Bookmarks["CompanyName"].Text = this.grdEmail.CurrentRow.Cells["CompanyName"].Value.ToString();
            doc.Range.Bookmarks["date1"].Text = this.emailMonthlyBillShowList1[0].date1;
            doc.Range.Bookmarks["date2"].Text = this.emailMonthlyBillShowList1[0].date2;

            doc.Save(FileName, SaveOption);

            Report2["@Company_Invoice"] = this.grdEmail.CurrentRow.Cells["CompaniesCode"].Value;
            Report2["@From"] = From;
            Report2["@To"] = To;
            Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
            image.File = FileName;
            Report2.Render();
            // Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, @"c:\Scan\MyReport.pdf");

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                msg.To.Add(new System.Net.Mail.MailAddress(this.grdEmail.CurrentRow.Cells["Email"].Value.ToString()));
                msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                msg.Subject = "Razi Applied Science Foundation";
                msg.Body = "<h3>Please see the attachment</h3>";
                msg.Attachments.Add(new System.Net.Mail.Attachment(ms, @"Invoice.pdf"));
                msg.IsBodyHtml = true;
                SendSMS.Classes.Utility.Send(msg);
            }
        }
    }
}
