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
    public partial class PrintOfReportDuplicateEnglish : RASF.General.Forms.Base.DockContentForm
    {
        public string ReportsType;
        private Boolean TestPresence;
        public PrintOfReportDuplicateEnglish()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
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
                    List<String> LaboratoryType = new List<String>();

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
                                    PdfDocument.Pages.Add(page);
                                }
                                Pagenumber++;
                            }
                            StartPage += Document.TotalPage;
                        }
                 

                    PdfDocument.Save();

                    using (System.IO.MemoryStream BackgroundImage = new System.IO.MemoryStream())
                    {
                        if (((RASF.General.Data.PartsMasterPrintReport)this.grdMaster.CurrentRow.DataRow).RType == false)
                        {
                            RASF.General.Resource.Documents.TemplateDuplicate.MakeTransparent(System.Drawing.Color.White);
                            RASF.General.Resource.Documents.TemplateDuplicate.Save(BackgroundImage, System.Drawing.Imaging.ImageFormat.Png);
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
                                page.Artifacts.Add(background);
                                PdfDocument.Save();
                                i++;
                            }
                        }
                        else
                        {
                           
                            foreach (Aspose.Pdf.Page page in PdfDocument.Pages)
                            {
                                AddText(page, ManagerName[i], new Aspose.Pdf.Text.Position(758, 150), ReportsType);
                                page.Artifacts.Add(background);
                                PdfDocument.Save();
                                i++;
                            }
                        }
                    }
                  
                    using (System.IO.MemoryStream SavedPdf = new System.IO.MemoryStream())
                    {
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

        private static void AddText(Aspose.Pdf.Page page, String Text, Aspose.Pdf.Text.Position Pos,string ReportsType )
        {
            Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(Text);
            textFragment.Position = Pos;
            if (ReportsType == "فارسي")
            {
                textFragment.TextState.FontSize = 9;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("B Lotus");
           }
         else
            {
                textFragment.TextState.FontSize = 9;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("Calibri");
            }
            textFragment.TextState.Font.IsEmbedded = true;
            textFragment.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            Aspose.Pdf.Text.TextBuilder textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
            textBuilder.AppendText(textFragment);
        }
    }
}
