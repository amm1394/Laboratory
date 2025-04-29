using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SendEmailFinancialSuport : RASF.General.Forms.Base.DockContentForm
    {
        public SendEmailFinancialSuport()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.costomerCostList1.spName = "FinancialSuportEmail";
        }

        public void grdCostomerCost_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value));
            this.costomerCostList1.Fill(Parameters);
            String FileName = System.IO.Path.ChangeExtension(System.IO.Path.Combine(System.IO.Path.GetTempPath() + System.IO.Path.GetRandomFileName()), "Bmp");

            Aspose.Words.Document doc;

            doc = new Aspose.Words.Document(new System.IO.MemoryStream(global::RASF.General.Resource.Documents.FinancialSupportEmail));
            Report2.Load(String.Format("{0}\\Report\\FinancialSuportEmail.mrt", Application.StartupPath));
       
            Aspose.Words.Saving.SaveOptions SaveOption = Aspose.Words.Saving.SaveOptions.CreateSaveOptions(Aspose.Words.SaveFormat.Bmp);
            SaveOption.PrettyFormat = true;
            SaveOption.UseAntiAliasing = true;
            SaveOption.UseHighQualityRendering = true;

            if (this.costomerCostList1.list[0].Delivery >DateTime.MinValue)
            {
                doc.Range.Bookmarks["DeliveryString"].Text = this.costomerCostList1[0].DeliveryString.ToString();
            }
            else 
            {
                doc.Range.Bookmarks["DeliveryString"].Text = "";
            }

            doc.Range.Bookmarks["CompanyName"].Text = this.costomerCostList1[0].CompanyName;
            doc.Range.Bookmarks["LetterDate"].Text = this.costomerCostList1[0].LetterDate;
            doc.Range.Bookmarks["LetterNo"].Text = this.costomerCostList1[0].LetterNo;
            doc.Range.Bookmarks["ContractNo"].Text = this.costomerCostList1[0].ContractNo.ToString();
            doc.Range.Bookmarks["ConnectorName"].Text = this.costomerCostList1[0].ConnectorName.ToString();
            doc.Range.Bookmarks["EXT"].Text = this.costomerCostList1[0].EXT.ToString();
           //doc.Range.Bookmarks["DateOfDay"].Text = this.costomerCostList1[0].DateOfDay;

            doc.Save(FileName, SaveOption);

            Report2["@Code"] = this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value;
            Stimulsoft.Report.Components.StiImage image = Report2.GetComponents()["Image1"] as Stimulsoft.Report.Components.StiImage;
            image.File = FileName;
            Report2.Render();
           // Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, @"c:\Scan\MyReport.pdf");

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            Report2.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, ms);
            ms.Seek(0, System.IO.SeekOrigin.Begin);

            using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
            {
                msg.To.Add(new System.Net.Mail.MailAddress(this.txtEmail.Text));
                msg.From = new System.Net.Mail.MailAddress("Invoice@razi-foundation.com");
                msg.Subject = string.Format("تایید مالی قرارداد {0}", this.costomerCostList1[0].ContractNo.ToString());
                msg.Body = String.Format("<p dir{0}>تایید مالی قرارداد {1} به پیوست ارسال می گردد.</p>", "rtl", this.costomerCostList1[0].ContractNo.ToString());
                msg.Attachments.Add(new System.Net.Mail.Attachment(ms, string.Format(@"تایید مالی قرارداد  {0}.pdf", this.costomerCostList1[0].ContractNo.ToString())));
                msg.IsBodyHtml = true;
                SendSMS.Classes.Utility.Send(msg);
            }

            //List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.grdCostomerCost.CurrentRow.Cells["ContractsCode"].Value));
            //Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            //Parameter.Add(new System.Data.SqlClient.SqlParameter("@EmailAddFaxNo", this.txtEmail.Text));
            //RASF.General.Lists.Base.BaseList<Object>.FillScalar("EmailCost_Select", Parameter);
         
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
            this.sendEmailOfCostOfCustomerList1.Fill(Parameter);

            if (this.sendEmailOfCostOfCustomerList1.list.Count > 0)
            {
                this.grdCostomerCost.Refetch();

                this.txtEmail.Text = this.sendEmailOfCostOfCustomerList1[0].Email;
            }

        }

    }
}
