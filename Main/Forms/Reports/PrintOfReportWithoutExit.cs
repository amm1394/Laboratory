using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace RASF.Main.Forms.Reports
{
    public partial class PrintOfReportWithoutExit : RASF.General.Forms.Base.DockContentForm
    {
        public string ReportsType;
        private Boolean TestPresence;
        public PrintOfReportWithoutExit()
        {
            InitializeComponent();
            this.ShowpnlButton = false;

            this.partsMasterPrintReportList1.spName = "PartsMasterPrintReportWithoutExit";
        }
       
   
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                try
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.findContractNoList1.Fill(Parameter);

                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.partsMasterPrintReportList1.Fill(Parameter1);
                    this.grdMaster.Refetch();

                    TestPresence = findContractNoList1[0].TestForThePresence;
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("اطلاعات وارد شده صحیح نمی یاشد");
                }
              
            }
        }

        public void grdMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).PartsMasterCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ReportType", ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType));
                this.getDocumentForPrintList1.Fill(Parameter);
            

                ReportsType = (string)this.grdMaster.CurrentRow.Cells["ReportType"].Value;
                
                Boolean RType = ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType;
                Int32 TotalPage = this.getDocumentForPrintList1.Sum(row => row.TotalPage);
                Int32 StartPage = 1;

               using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
                {
                    List<String> ManagerName = new List<String>();
                    List<String> ScienceName = new List<String>();
                    List<String> LaboratoryType = new List<String>();
                    List<Byte[]> Sgin1 = new List<Byte[]>();
                    List<Byte[]> Sgin2 = new List<Byte[]>();

                    int Pagenumber = 1;

                    foreach (RASF.General.Data.GetDocumentForPrint Document in this.getDocumentForPrintList1)
                    {
                        Document.Content = RASF.General.Classes.BookMarks.SetBookMarks(Document.PartsTestMasterCode, Document.Content, General.Enums.BookMark.EditState, RType);
                        Document.Content = RASF.General.Classes.BookMarks.SetTotalPage(Document.Content, StartPage, TotalPage, RType);

                        System.IO.MemoryStream ms = new System.IO.MemoryStream(Document.Content);
                        Aspose.Pdf.Document LoadedDocument = new Aspose.Pdf.Document(ms);
                        //Sgin1.Add(Document.Sgin1);
                        //Sgin2.Add(Document.Sgin2);

//                        AddSign(Document.Sgin1, Document.Sgin2, ms);
                        foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                        {
                            if (((this.printDialog1.PrinterSettings.FromPage == 0) && (this.printDialog1.PrinterSettings.ToPage == 0)) || ((Pagenumber >= this.printDialog1.PrinterSettings.FromPage) && (Pagenumber <= this.printDialog1.PrinterSettings.ToPage)))
                            {
                                if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                                {
                                    LaboratoryType.Add(Document.LaboratoryType);
                                }
                                ManagerName.Add(Document.ManagerName);
                                ScienceName.Add(Document.ScienceName);
                                Sgin1.Add(Document.Sgin1);
                                Sgin2.Add(Document.Sgin2);
                                PdfDocument.Pages.Add(page);
                            }
                            Pagenumber++;
                        }
                        StartPage += Document.TotalPage;
                    }
                 

                 ////   PdfDocument.Save();
                    if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).IsNew == false)
                    {
                        using (System.IO.MemoryStream BackgroundImage = new System.IO.MemoryStream())
                        {
                            if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
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
                            int i = 0;
                            //foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                            //{
                            //    //forWorkFlow
                            //    using (System.IO.MemoryStream backImage = new MemoryStream())
                            //    {
                            //        using (Aspose.Pdf.BackgroundArtifact background = new Aspose.Pdf.BackgroundArtifact())
                            //        {
                            //            using (Bitmap BackImage = new Bitmap(BackgroundImage))
                            //            {
                            //                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(BackImage))
                            //                {
                            //                    if (RType == false)
                            //                    {
                            //                        using (System.Drawing.Bitmap img_1 = new System.Drawing.Bitmap(new System.IO.MemoryStream(Sgin1[i])))
                            //                        {
                            //                            g.DrawImage(img_1, new System.Drawing.Point((int)((395 - (img_1.Width * 2.7)) / 2.0) + 35, 1600));
                            //                        }
                            //                        using (System.Drawing.Bitmap img_2 = new System.Drawing.Bitmap(new System.IO.MemoryStream(Sgin2[i])))
                            //                        {
                            //                            g.DrawImage(img_2, new System.Drawing.Point((int)((395 - (img_2.Width * 2.7)) / 2.0) + 35, 2010));
                            //                        }
                            //                    }
                            //                    else
                            //                    {
                            //                        using (System.Drawing.Bitmap img_1 = new System.Drawing.Bitmap(new System.IO.MemoryStream(Sgin1[i])))
                            //                        {
                            //                            g.DrawImage(img_1, new System.Drawing.Point((int)((395 - (img_1.Width * 2.7)) / 2.0) + 3000, 1600));
                            //                        }
                            //                        using (System.Drawing.Bitmap img_2 = new System.Drawing.Bitmap(new System.IO.MemoryStream(Sgin2[i])))
                            //                        {
                            //                            g.DrawImage(img_2, new System.Drawing.Point((int)((395 - (img_2.Width * 2.7)) / 2.0) + 3000, 2010));
                            //                        }
                            //                    }
                            //                }
                            //                  BackImage.Save(backImage, System.Drawing.Imaging.ImageFormat.Png);//w
                            //              //  BackImage.Save(@"D:\Users\knabavi\Desktop\Test1.Png", System.Drawing.Imaging.ImageFormat.Png);
                            //            }

                            //    background.BackgroundImage = backImage;//w

                            if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                            {
                                foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                                {
                                    AddText(page, String.Format("مدیر فنی {0}", LaboratoryType[i]), new Aspose.Pdf.Text.Position(16, 210), ReportsType);
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(37, 195), ReportsType);
                                    // AddText(page, ScienceName[i], new Aspose.Pdf.Text.Position(37, 105), ReportsType );//w

                                    page.Artifacts.Add(background);
                                    i++;
                                }
                            }
                            ////  PdfDocument.Save();

                            else
                            {
                                foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                                {
                                    AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(750, 158), ReportsType);
                                    page.Artifacts.Add(background);
                                    PdfDocument.Save();
                                    i++;
                                }
                            }
                            //        }//w
                            //    }//w
                            //}//w

                        }
                    }

                    using (System.IO.MemoryStream SavedPdf = new System.IO.MemoryStream())
                    {
                       // PdfDocument.Save(@"D:\Users\knabavi\Desktop\Test.pdf");
                        PdfDocument.Save(SavedPdf);
                        SavedPdf.Flush();
                        using (TallComponents.PDF.Document document1 = new TallComponents.PDF.Document(SavedPdf))
                        {
                            TallComponents.PDF.Printing.PrintSettings PrintSettings = new TallComponents.PDF.Printing.PrintSettings();

                            PrintSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                            PrintSettings.PagePrintSettings.Landscape = true;
                            PrintSettings.PagePrintSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                            PrintSettings.PagePrintSettings.ScaleToFit = true;
                            PrintSettings.PagePrintSettings.UsePrintableArea = true;
                            document1.Print(PrintSettings);
                        }
                    }
                }
                this.btnSearch_Click(sender, new EventArgs());
            }
            }

        private static void AddText(Aspose.Pdf.Page page, String Text, Aspose.Pdf.Text.Position Pos, string ReportsType)
        {
            if (Text != null)
            {
                Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(Text);
                textFragment.Position = Pos;
                if (ReportsType == "فارسي")
                {
                    textFragment.TextState.FontSize = 9;//9
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

     
        private static void AddSign(byte[] img1, byte[] img2, System.IO.MemoryStream SavedPdf)
        {
            System.Drawing.Bitmap img_1 = new System.Drawing.Bitmap(new System.IO.MemoryStream(img1));
            System.Drawing.Bitmap img_2 = new System.Drawing.Bitmap(new System.IO.MemoryStream(img2));

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                            
                using (System.Drawing.Bitmap img3 = MergedBitmaps(img_1, img_2))
                {
                    img3.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    //img3.Save(@"D:\Users\knabavi\Desktop\Test.Png");
                }

                int PageCount;
                using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document(SavedPdf))
                {
                    PageCount = PdfDocument.Pages.Count;
                    using (Aspose.Pdf.Facades.PdfFileMend mender = new Aspose.Pdf.Facades.PdfFileMend())
                    {
                        mender.BindPdf(PdfDocument);
                        for (int i = 1; i <= PageCount; i++)
                        {
                            mender.AddImage(ms, i, 25, 80, 100, 240);
                        }
                        SavedPdf = new System.IO.MemoryStream();
                        mender.Save(SavedPdf);
                        //System.IO.File.WriteAllBytes(@"D:\Users\knabavi\Desktop\ali.pdf", SavedPdf.ToArray());
                    }
                }
            }
        }
        private static System.Drawing.Bitmap MergedBitmaps(System.Drawing.Bitmap bmp1, System.Drawing.Bitmap bmp2)
        {
            System.Drawing.Bitmap result = new System.Drawing.Bitmap(Math.Max(bmp1.Width, bmp2.Width),
                                       (Math.Max(bmp1.Height, bmp2.Height) * 2) + 75);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(result))
            {
                g.DrawImage(bmp2, System.Drawing.Point.Empty);
                g.DrawImage(bmp1, new System.Drawing.Point(0, bmp2.Height + 75));
            }
            return result;
        }
    }
}
