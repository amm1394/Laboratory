using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public class SendFax
    {
        public SendFax()
        {
        }
        public string ReportsType;
        private Boolean TestPresence;
        System.IO.MemoryStream PdfStrem = new System.IO.MemoryStream();
        public void MakeEmail(List<RASF.General.Data.PartsMasterPrintReport> parts, String to, Int16 ContractNo)
        {
            try
            {
                RASF.General.Lists.GetDocumentForPrintList getDocumentForPrintList1 = new RASF.General.Lists.GetDocumentForPrintList();
                String SourcePath = String.Format("{0}{1}\\", System.IO.Path.GetTempPath(), ContractNo);
                System.IO.Directory.CreateDirectory(SourcePath);
                foreach (RASF.General.Data.PartsMasterPrintReport part in parts.Where(row => row.Checked == true))
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", part.PartsMasterCode));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ReportType", part.RType));
                    getDocumentForPrintList1.Fill(Parameter);
                 
                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", part.PartsMasterCode));
                    TestPresence = Convert.ToBoolean(RASF.General.Lists.GetDocumentForPrintList.FillScalar("FindTestForThePresence_Select", Parameter3));

                    ReportsType = part.ReportType;

                    Int32 TotalPage = getDocumentForPrintList1.Sum(row => row.TotalPage);
                    Int32 StartPage = 1;

                    using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
                    {
                        List<String> ManagerName = new List<String>();
                        List<String> LaboratoryType = new List<String>();
                        foreach (RASF.General.Data.GetDocumentForPrint Document in getDocumentForPrintList1)
                        {
                            Document.Content = RASF.General.Classes.BookMarks.SetBookMarks(Document.PartsTestMasterCode, Document.Content, General.Enums.BookMark.EditState, part.RType);
                            Document.Content = RASF.General.Classes.BookMarks.SetTotalPage(Document.Content, StartPage, TotalPage, part.RType);

                            System.IO.MemoryStream ms = new System.IO.MemoryStream(Document.Content);
                            Aspose.Pdf.Document LoadedDocument = new Aspose.Pdf.Document(ms);
                            foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                            {
                                ManagerName.Add(Document.ManagerName);
                                LaboratoryType.Add(Document.LaboratoryType);
                                PdfDocument.Pages.Add(page);
                            }
                            StartPage += Document.TotalPage;
                        }

                        PdfDocument.Save();
                        int i = 0;
                        using (System.IO.MemoryStream BackgroundImage = new System.IO.MemoryStream())
                        {
                            if (part.RType == false)
                            {
                               RASF.General.Resource.Documents.Mail_Template.MakeTransparent(System.Drawing.Color.White);
                               RASF.General.Resource.Documents.Mail_Template.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                               
                            }
                            else 
                            {
                                if (TestPresence == false)
                                {
                                    RASF.General.Resource.Documents.Mail_EnglishTemplate.MakeTransparent(System.Drawing.Color.White);
                                    RASF.General.Resource.Documents.Mail_EnglishTemplate.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                                }
                                else
                                {
                                    RASF.General.Resource.Documents.Mail_EnglishTemplateTest.MakeTransparent(System.Drawing.Color.White);
                                    RASF.General.Resource.Documents.Mail_EnglishTemplateTest.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                                }
                            }
                            Aspose.Pdf.BackgroundArtifact background = new Aspose.Pdf.BackgroundArtifact();
                            background.BackgroundImage = BackgroundImage;
                            foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                            {
                                if (part.RType == false)
                                {
                                    AddText(page, String.Format("مدیر فنی {0}", LaboratoryType[i]), new Aspose.Pdf.Text.Position(16, 210),ReportsType);
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(37, 195),ReportsType);
                                }
                                else
                                {
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(745, 160),ReportsType);
                                }

                                page.Artifacts.Add(background);
                                PdfDocument.Save(PdfStrem);
                                i++;
                            }
                        }

                        //if (part.RType == false)
                        //{
                        //    PdfDocument.Save(String.Format("{0}{1}.Pdf", SourcePath, "PartNumber" + "-" + part.PartNumber + "-" + "PersianReport"));
                        //}
                        //else
                        //{
                        //    //RASF.General.Classes.Utility.CorrectFileName(part.Name)
                        //    PdfDocument.Save(String.Format("{0}{1}.Pdf", SourcePath, "PartNumber" + "-" + part.PartNumber + "-" + "EnglishReport"));
                        //}
                       // PdfDocument.Save(PdfStrem);
                   
                    using (Aspose.Email.Mail.MailMessage MailMessage = new Aspose.Email.Mail.MailMessage())
                    {
                        MailMessage.From = "labfax@razi-foundation.com";
                        MailMessage.To = String.Format("{0}@fax.ir", to);
                        if (part.RType == false)
                        {
                            MailMessage.Subject = String.Format("{0}.Pdf", "PartNumber" + "-" + part.PartNumber + "-" + "PersianReport");
                        }
                        else
                        {
                            MailMessage.Subject = String.Format("{0}.Pdf", "PartNumber" + "-" + part.PartNumber + "-" + "EnglishReport");
                        }
                        MailMessage.Attachments.Add(new Aspose.Email.Mail.Attachment(PdfStrem, MailMessage.Subject));
                       
                        this.Send(MailMessage);
                    }
                System.IO.Directory.Delete(SourcePath);
               
                 }
                    }
            }

            catch
            {
                //  MessageBox.Show("ایمیل شما ارسال گردید");
            }
        }

        private void Send(Aspose.Email.Mail.MailMessage msg)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
            Aspose.Email.Exchange.IEWSClient client = Aspose.Email.Exchange.EWSClient.GetEWSClient("https://mail.razi-foundation.com/ews/exchange.asmx", "LabFax", "RaziScience35741", "Razi-Foundation.com");

            client.Send(msg);

        }

        private bool RemoteCertificateValidationHandler(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void AddText(Aspose.Pdf.Page page, String Text, Aspose.Pdf.Text.Position Pos,string ReportsType)
        {
            Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(Text);
            textFragment.Position = Pos;
            if (ReportsType == "فارسی")
            {
                textFragment.TextState.FontSize = 9;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("B Lotus");
            }
            else
            {
                textFragment.TextState.FontSize = 7;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("Calibri");
            }
            textFragment.TextState.Font.IsEmbedded = true;
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            Aspose.Pdf.Text.TextBuilder textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
            textBuilder.AppendText(textFragment);
        }

    }
}
