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
    public partial class OldPrintOfReportRecieptPic : RASF.General.Forms.Base.DockContentForm
    {
        public string ReportsType;
        private Boolean TestPresence;
        public OldPrintOfReportRecieptPic()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.showSaveCostPaperList1.spName = "ShowSavedAttachmentFile";
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

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter ("@PartsTestMasterCode",this.getDocumentForPrintList1.First().PartsTestMasterCode));
                string Pic = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic2_Select", Parameter2);

                List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter3.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", this.getDocumentForPrintList1.First().PartsTestMasterCode));
                string Pic1 = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic1_Select", Parameter3);

                if (Pic == "true")
                {
                    this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.OldMakePicture2.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
                }

                if (Pic1 == "true")
                {
                    this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.OldMakePicture.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
                }


                ReportsType = (string)this.grdMaster.CurrentRow.Cells["ReportType"].Value;
                
                Boolean RType = ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType;
                Int32 TotalPage = this.getDocumentForPrintList1.Sum(row => row.TotalPage);
                Int32 StartPage = 1;

                //RASF.General.Classes.MakePicture.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName);

                using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
                {
                    List<String> ManagerName = new List<String>();
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
                            foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                            {
                                if (((this.printDialog1.PrinterSettings.FromPage == 0) && (this.printDialog1.PrinterSettings.ToPage == 0)) || ((Pagenumber >= this.printDialog1.PrinterSettings.FromPage) && (Pagenumber <= this.printDialog1.PrinterSettings.ToPage)))
                                {
                                    if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                                    {
                                        LaboratoryType.Add(Document.LaboratoryType);
                                    }
                                    ManagerName.Add(Document.ManagerName);
                                    Sgin1.Add(Document.Sgin1);
                                    Sgin2.Add(Document.Sgin2);
                                    PdfDocument.Pages.Add(page);
                                }
                                Pagenumber++;
                            }
                            StartPage += Document.TotalPage;
                        }
                 

                 ////   PdfDocument.Save();

                    using (System.IO.MemoryStream BackgroundImage = new System.IO.MemoryStream())
                    {
                        if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                        {
                            RASF.General.Resource.Documents.Template.MakeTransparent(System.Drawing.Color.White);
                            RASF.General.Resource.Documents.Template.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else
                        {
                            if (TestPresence == false)
                            {
                                RASF.General.Resource.Documents.EnglishTemplate.MakeTransparent(System.Drawing.Color.White);
                                RASF.General.Resource.Documents.EnglishTemplate.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                            }
                            else
                            {
                                RASF.General.Resource.Documents.EnglishTemplateTest.MakeTransparent(System.Drawing.Color.White);
                                RASF.General.Resource.Documents.EnglishTemplateTest.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
                            }
                        }
                        Aspose.Pdf.BackgroundArtifact background = new Aspose.Pdf.BackgroundArtifact();
                        background.BackgroundImage = BackgroundImage;
                        int i = 0;
                        if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                        {
                          
                            foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                            {
                                AddText(page, String.Format("مدیر فنی {0}", LaboratoryType[i]), new Aspose.Pdf.Text.Position(16, 210), ReportsType);
                                AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(37, 195), ReportsType);
                               // AddText(page, Sgin1[i], new Aspose.Pdf.Text.Position(38, 196), ReportsType);
                                //add(page, Sgin2[i], new Aspose.Pdf.Text.Position(38, 196), ReportsType);
                                page.Artifacts.Add(background);
                                i++;
                            }
                      ////      PdfDocument.Save();
                        }
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
    }
}
