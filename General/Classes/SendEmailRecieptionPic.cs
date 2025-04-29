using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Classes
{
    public class SendEmailRecieptionPic
    {
        public SendEmailRecieptionPic()
        {
        }
        public string ReportsType;
        private Boolean TestPresence;

        public void MakeEmail(List<RASF.General.Data.PartsMasterPrintReport> parts, String to, Int32 ContractNo)
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

                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", getDocumentForPrintList1.First().PartsTestMasterCode));
                    string Pic = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic2_Select", Parameter2);

                    List<System.Data.SqlClient.SqlParameter> Parameter4 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter4.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", getDocumentForPrintList1.First().PartsTestMasterCode));
                    string Pic1 = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic1_Select", Parameter4);

                    if (Pic == "true")
                    {
                        //  getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture2.MakePage(getDocumentForPrintList1.First().PartsTestMasterCode, part.RType, getDocumentForPrintList1.First().LaboratoryType, getDocumentForPrintList1.First().ManagerName, getDocumentForPrintList1.First().EnglishManagerName));
                        getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture2.MakePage(getDocumentForPrintList1.First().PartsTestMasterCode, part.RType, getDocumentForPrintList1.First().LaboratoryType, getDocumentForPrintList1.First().ManagerName, getDocumentForPrintList1.First().EnglishManagerName));
                    }
                    if (Pic1 == "true")
                    {
                        // getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture.MakePage(getDocumentForPrintList1.First().PartsTestMasterCode, part.RType, getDocumentForPrintList1.First().LaboratoryType, getDocumentForPrintList1.First().ManagerName, getDocumentForPrintList1.First().EnglishManagerName));
                        getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture.MakePage(getDocumentForPrintList1.First().PartsTestMasterCode, part.RType, getDocumentForPrintList1.First().LaboratoryType, getDocumentForPrintList1.First().ManagerName, getDocumentForPrintList1.First().EnglishManagerName));
                    }

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", part.PartsMasterCode));
                    TestPresence = Convert.ToBoolean(RASF.General.Lists.GetDocumentForPrintList.FillScalar("FindTestForThePresence_Select", Parameter3));

                    ReportsType = part.ReportType;

                    Int32 TotalPage = getDocumentForPrintList1.Sum(row => row.TotalPage);
                    Int32 StartPage = 1;
                    List<String> fileName = new List<string>();
                    //Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document();

                    using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
                    {
                        PdfDocument.OptimizeResources();

                        List<String> ManagerName = new List<String>();
                        List<String> LaboratoryType = new List<String>();
                        for (int j = getDocumentForPrintList1.Count() - 1; j >= 0; j--)
                            //foreach (RASF.General.Data.GetDocumentForPrint Document in getDocumentForPrintList1)
                        {
                            var Document = getDocumentForPrintList1[j];
                            Document.Content = RASF.General.Classes.BookMarks.SetBookMarks(Document.PartsTestMasterCode, Document.Content, General.Enums.BookMark.EditState, part.RType);
                            Document.Content = RASF.General.Classes.BookMarks.SetTotalPage(Document.Content, StartPage, TotalPage, part.RType);
                            
                            // گرفتن مسیر پوشه موقت سیستم
                            string tempPath = System.IO.Path.GetTempPath();
        
                            // گرفتن یک نام فایل تصادفی
                            string randomFileName = System.IO.Path.GetRandomFileName();
        
                            // ترکیب مسیر موقت و نام فایل تصادفی
                            string fullPath = System.IO.Path.Combine(tempPath, randomFileName);

                            string FileName = System.IO.Path.ChangeExtension(fullPath, ".Pdf");
                            System.IO.File.WriteAllBytes(FileName, Document.Content.ToArray());
//                            System.IO.MemoryStream ms = new System.IO.MemoryStream(Document.Content);
                            Aspose.Pdf.Document LoadedDocument = new Aspose.Pdf.Document(FileName);
                            foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                            {
                                ManagerName.Add(Document.ManagerName);
                                LaboratoryType.Add(Document.LaboratoryType);
                                PdfDocument.Pages.Add(page);
                            }
                            StartPage += Document.TotalPage;
                            PdfDocument.Save();
                            System.IO.File.Delete(FileName);
                            getDocumentForPrintList1.RemoveAt(j);

                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                        }

                        getDocumentForPrintList1.Clear();
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        //PdfDocument.Save();
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
                                    AddText(page, String.Format("مدیر {0}", LaboratoryType[i]), new Aspose.Pdf.Text.Position(16, 210), ReportsType);
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(37, 195), ReportsType);
                                }
                                else
                                {
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(745, 160), ReportsType);
                                }

                                page.Artifacts.Add(background);
                                i++;
                            }
                            //if (PdfDocument.Pages.Count > 0)
                            //{

                            //}
                            //PdfDocument.Save();
                        }

                        if (part.RType == false)
                        {
                            PdfDocument.Save(String.Format("{0}{1}.Pdf", SourcePath, "PartNumber" + "-" + part.PartNumber + "-" + "PersianReport"));
                            // PdfDocument.Save(@"D:\Users\knabavi\Desktop\Test.pdf");
                        }
                        else
                        {
                            //RASF.General.Classes.Utility.CorrectFileName(part.Name)
                            PdfDocument.Save(String.Format("{0}{1}.Pdf", SourcePath, "PartNumber" + "-" + part.PartNumber + "-" + "EnglishReport"));
                            //  PdfDocument.Save(@"D:\Users\knabavi\Desktop\Test.pdf");
                        }
                    }
                }
                List<RASF.General.Classes.CompressedFile> CompressedFile = RASF.General.Classes.Compressor.CompressFile(SourcePath, ContractNo.ToString());
                int count = 0;
                foreach (RASF.General.Classes.CompressedFile File in CompressedFile)
                {
                    count++;
                    //using (System.IO.MemoryStream SavedPdf = new System.IO.MemoryStream())
                    //{
                    //    SavedPdf.Save(@"D:\Users\knabavi\Desktop\Test.pdf");
                    //}
                    using (System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage())
                    {
                        foreach (string t in to.Split(','))
                        {
                            msg.To.Add(new System.Net.Mail.MailAddress(t));
                        }
                        msg.From = new System.Net.Mail.MailAddress("Reports@razi-foundation.com");
                        msg.Subject = String.Format("گزارش نتایج آرمون قرارداد {0}", ContractNo.ToString());
                        msg.Body = String.Format("<p dir={0}>مشتری گرامی <br />با سلام؛<br />احتراماً گزارش با شماره پیگیری {1} ؛ طی {2}  ایمیل جداگانه بصورت فایل های ZIP،ارسال می گردد<br />خواهشمند است جهت رؤیت گزارش ارسالی پس از دانلود و قراردادن کلیه فایل های Attach شده در کنار یکدیگر اقدام به Extract نمودن فایل های ZIP شده نمائید. <br />با احترام مجدد <br />بنیاد علوم کاربردی رازی <br />واحد هماهنگی امور مشتریان <br />تلفن : 021-49732 <br /> داخلی 3</p>", "rtl", ContractNo.ToString(), CompressedFile.Count);
                        msg.IsBodyHtml = true;
                        msg.Attachments.Add(new System.Net.Mail.Attachment(File.File, File.Name));
                        this.Send(msg);
                    }
                    File.Dispose();
                }

                foreach (RASF.General.Classes.CompressedFile File in CompressedFile)
                {
                    System.IO.File.Delete(System.IO.Path.Combine(SourcePath, File.Name));
                }
                System.IO.Directory.Delete(SourcePath);
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Send(System.Net.Mail.MailMessage msg)
        {
            try
            {
                if (System.Net.ServicePointManager.ServerCertificateValidationCallback == null)
                {
                    System.Net.ServicePointManager.ServerCertificateValidationCallback += RemoteCertificateValidationHandler;
                }

                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("administrator@razi-foundation.com", "Yekta@RaziFoundation232");
                client.Port = 25;
                client.Host = "mail.razi-foundation.com";
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Send(msg);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
