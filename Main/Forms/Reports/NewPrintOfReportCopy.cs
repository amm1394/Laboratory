using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class NewPrintOfReportCopy : RASF.General.Forms.Base.DockContentForm
    {
        public string ReportsType;
        private Boolean TestPresence;
        private Bitmap image;
        private Bitmap imageEN;
        public NewPrintOfReportCopy()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.showSaveCostPaperList1.spName = "ShowSavedAttachmentFile";
         //   this.letter_Scan1.o

            //System.IO.MemoryStream stream = new System.IO.MemoryStream();
            //image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
            //Byte[] bytes = stream.ToArray();

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
                    this.newPartsMasterPrintReportList1.Fill(Parameter1);
                    this.grdMaster.Refetch();

                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.showSaveCostPaperList1.Fill(Parameter2);
                    if (this.showSaveCostPaperList1.list.Count > 0)
                    {
                        this.letter_Scan1.Document = this.showSaveCostPaperList1.list[0].CostPaper;
                    }

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

                Boolean RType = ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType;

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", this.getDocumentForPrintList1.First().PartsTestMasterCode));
                string Pic = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic2_Select", Parameter2);

                List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter3.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", this.getDocumentForPrintList1.First().PartsTestMasterCode));
                string Pic1 = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic1_Select", Parameter3);

                //  Int32 StartPage = 1;

                if (Pic == "true")
                {
                    this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture2.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
                    if (RType == false)
                    {
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin1 = this.getDocumentForPrintList1.LastOrDefault().Sgin1;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin2 = this.getDocumentForPrintList1.LastOrDefault().Sgin2;
                    }
                    else
                    {
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin3 = this.getDocumentForPrintList1.LastOrDefault().Sgin3;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin4 = this.getDocumentForPrintList1.LastOrDefault().Sgin4;
                    }
                    this.getDocumentForPrintList1.FirstOrDefault().TotalPage = 1;
                    //StartPage++;
                }

                image = RASF.General.Resource.Documents.CopyAslPersian;
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                Byte[] Almosanna = stream.ToArray();

                imageEN = RASF.General.Resource.Documents.CopyAslEnglish;
                System.IO.MemoryStream stream1 = new System.IO.MemoryStream();
                imageEN.Save(stream1, System.Drawing.Imaging.ImageFormat.Bmp);
                Byte[] ENAlmosanna = stream1.ToArray();

                if (Pic1 == "true")
                {
                    this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
                    if (RType == false)
                    {
//                        this.getDocumentForPrintList1.FirstOrDefault().Sgin1 = this.getDocumentForPrintList1.LastOrDefault().Sgin1;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin1 = null;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin2 = this.getDocumentForPrintList1.LastOrDefault().Sgin2;
                    }
                    else
                    {
                        //this.getDocumentForPrintList1.FirstOrDefault().Sgin3 = this.getDocumentForPrintList1.LastOrDefault().Sgin3;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin3 = null;
                        this.getDocumentForPrintList1.FirstOrDefault().Sgin4 = this.getDocumentForPrintList1.LastOrDefault().Sgin4;
                    }
                    this.getDocumentForPrintList1.FirstOrDefault().TotalPage = 1;
                    // StartPage++;
                }


                ReportsType = (string)this.grdMaster.CurrentRow.Cells["ReportType"].Value;
                Int32 StartPage = 1;

                Int32 TotalPage = this.getDocumentForPrintList1.Sum(row => row.TotalPage);
                using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
                {
                    List<String> ManagerName = new List<String>();
                    List<String> LaboratoryType = new List<String>();

                    int Pagenumber = 1;


                    foreach (RASF.General.Data.GetDocumentForPrint Document in this.getDocumentForPrintList1)
                    {
                        Document.Content = RASF.General.Classes.BookMarks.SetBookMarks(Document.PartsTestMasterCode, Document.Content, General.Enums.BookMark.EditState, RType);

                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Document.Content))
                        {
                            Aspose.Words.Document document = new Aspose.Words.Document(ms);

                            foreach (Aspose.Words.Section section in document)
                            {
                                //  section.PageSetup.TopMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(60);
                                section.PageSetup.BottomMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(25.4);
                                section.PageSetup.FooterDistance = Aspose.Words.ConvertUtil.MillimeterToPoint(2);
                                if (RType == false)
                                {
                                    section.PageSetup.HeaderDistance = Aspose.Words.ConvertUtil.MillimeterToPoint(5.75);
                                    section.PageSetup.TopMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(60);
                                    section.PageSetup.RightMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(22);
                                    section.PageSetup.LeftMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(50);
                                }
                                else
                                {
                                    section.PageSetup.HeaderDistance = Aspose.Words.ConvertUtil.MillimeterToPoint(5.75);//8,75
                                    section.PageSetup.TopMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(60);
                                    section.PageSetup.RightMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(50);//50.5
                                    section.PageSetup.LeftMargin = Aspose.Words.ConvertUtil.MillimeterToPoint(22);
                                }

                            }

                            using (System.IO.MemoryStream doc = new System.IO.MemoryStream())
                            {
                                document.Save(doc, Aspose.Words.SaveFormat.Docx);
                                Document.Content = doc.ToArray();
                            }
                        }
                        Document.Content = RASF.General.Classes.BookMarks.SetTotalPage(Document.Content, StartPage, TotalPage, RType);


                        Aspose.Pdf.Document LoadedDocument = new Aspose.Pdf.Document(new System.IO.MemoryStream(Document.Content));
                        foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                        {
                            if (((this.printDialog1.PrinterSettings.FromPage == 0) && (this.printDialog1.PrinterSettings.ToPage == 0)) || ((Pagenumber >= this.printDialog1.PrinterSettings.FromPage) && (Pagenumber <= this.printDialog1.PrinterSettings.ToPage)))
                            {
                                LaboratoryType.Add(Document.LaboratoryType);
                                if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                                {
                                    AddSign(Almosanna, new Aspose.Pdf.Rectangle(210, 100, 120, 60), page);

                                    if (Document.Sgin1 != null)
                                    {
                                        AddSign(Document.Sgin1, new Aspose.Pdf.Rectangle(2, 150, 128, 213), page);
                                        AddText(page, String.Format("مدیر {0}", Document.LaboratoryType), new Aspose.Pdf.Text.Position(16, 210), ReportsType);
                                        AddText(page, Document.ManagerName, new Aspose.Pdf.Text.Position(37, 195), ReportsType);
                                    }

                                    AddSign(Document.Sgin2, new Aspose.Pdf.Rectangle(2, 70, 128, 133), page);
                                    AddText(page, "مدیر فنی آزمایشگاه ها", new Aspose.Pdf.Text.Position(16, 130), ReportsType);
                                    AddText(page, "بهنام رحمانی", new Aspose.Pdf.Text.Position(30, 115), ReportsType);
                                }
                                else
                                {

                                    //                                         AddText(page, Document.ManagerName, new Aspose.Pdf.Text.Position(750, 158), ReportsType);

                                    AddSign(ENAlmosanna, new Aspose.Pdf.Rectangle(20, 70, 128, 133), page);

                                    if (Document.Sgin3 != null)
                                    {
                                        AddSign(Document.Sgin3, new Aspose.Pdf.Rectangle(730, 150, 830, 213), page);
                                        AddText(page, "Laboratory Manager", new Aspose.Pdf.Text.Position(750, 210), ReportsType);
                                        AddText(page, Document.ManagerName, new Aspose.Pdf.Text.Position(760, 195), ReportsType);
                                    }

                                    AddSign(Document.Sgin4, new Aspose.Pdf.Rectangle(730, 70, 830, 133), page);
                                    AddText(page, "Technical Manager", new Aspose.Pdf.Text.Position(750, 130), ReportsType);
                                    AddText(page, "B.Rahmani", new Aspose.Pdf.Text.Position(755, 115), ReportsType);

                                    // AddText(page, Document.EnglishManagerName, new Aspose.Pdf.Text.Position(750, 158), ReportsType);
                                }

                                PdfDocument.Pages.Add(page);
                            }
                            Pagenumber++;
                        }
                        StartPage += Document.TotalPage;
                    }


                    PdfDocument.Save();

                    using (System.IO.MemoryStream pdfArray = new System.IO.MemoryStream())
                    {
                        PdfDocument.Save(pdfArray);
                        pdfArray.Flush();
                        using (Foxit.PDF.Printing.InputPdf inputPdf = new Foxit.PDF.Printing.InputPdf(pdfArray.ToArray()))
                        {
                            using (Foxit.PDF.Printing.PrintJob printJob = new Foxit.PDF.Printing.PrintJob(printDialog1.PrinterSettings.PrinterName, inputPdf))
                            {
                                printJob.PrintOptions.VerticalAlign = Foxit.PDF.Printing.VerticalAlign.Top;
                                printJob.PrintOptions.HorizontalAlign = Foxit.PDF.Printing.HorizontalAlign.Left;
                                printJob.PrintOptions.Orientation.Type = Foxit.PDF.Printing.OrientationType.Auto;
                                printJob.PrintOptions.Scaling = Foxit.PDF.Printing.PageScaling.ActualSize;
                                printJob.PrintOptions.PaperSize = printJob.Printer.PaperSizes.A4;// ["A4"];
                                printJob.PrintOptions.PrintAnnotations = false;
                                if (printJob.Printer.Resolutions.Count > 0)
                                {
                                    printJob.PrintOptions.Resolution = printJob.Printer.Resolutions.Last();
                                }

                                printJob.Print();
                            }
                        }
                    }
                }
                this.btnSearch_Click(sender, new EventArgs());
            }
        }

        private static void AddSign(byte[] img1,Aspose.Pdf.Rectangle rectangle,  Aspose.Pdf.Page page)
        {
            if (img1 != null)
            {
                Aspose.Pdf.ImageStamp imageStamp = new Aspose.Pdf.ImageStamp(new System.IO.MemoryStream(img1));
                imageStamp.Background = false;
                imageStamp.XIndent = rectangle.LLX;
                imageStamp.YIndent = rectangle.LLY;
                imageStamp.Height = rectangle.URY - rectangle.LLY;
                imageStamp.Width = rectangle.URX - rectangle.LLX;
                page.AddStamp(imageStamp);
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
    }
}
