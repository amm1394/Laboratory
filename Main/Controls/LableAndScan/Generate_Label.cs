using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls 
{
    public partial class Generate_Label : UserControl
    {
        public Generate_Label()
        {
            InitializeComponent();

            this.radPdfViewer1.ShowThubnails();
            this.radPDFCommandBar1.ShowPrintPreview = false;
            Telerik.WinControls.UI.CommandBarButton Button = (Telerik.WinControls.UI.CommandBarButton)(this.radPDFCommandBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0));
            ((Telerik.WinControls.UI.RadCommandBarItemsPanel)(this.radPDFCommandBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(1))).Children.Remove(Button);
            this.radPDFCommandBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(0).GetChildAt(2).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
        }

        public void DoWork(RASF.General.Lists.GenerateLabelList LabelList)
        {
            Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document();

            foreach (RASF.General.Data.GenerateLabel Label in LabelList)
            {
                Aspose.Pdf.Page page = PdfDocument.Pages.Add();
                page.PageInfo.Margin.Bottom = 0;
                page.PageInfo.Margin.Top = 0;
                page.PageInfo.Margin.Left = 5;
                page.PageInfo.Margin.Right = 5;
                page.SetPageSize(500, 500);

                Aspose.Pdf.Text.TextFragment textFragment = new Aspose.Pdf.Text.TextFragment(Label.MasterName);
                textFragment.Position = new Aspose.Pdf.Text.Position(20, 10);
                textFragment.TextState.FontSize = 35;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                Aspose.Pdf.Text.TextBuilder textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
                textBuilder.AppendText(textFragment);

                textFragment = new Aspose.Pdf.Text.TextFragment(Label.AgencyName);
                textFragment.Position = new Aspose.Pdf.Text.Position(60, 100);
                textFragment.TextState.FontSize = 70;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
                textBuilder.AppendText(textFragment);

                textFragment = new Aspose.Pdf.Text.TextFragment(Label.PartNumber);
                textFragment.Position = new Aspose.Pdf.Text.Position(60, 200);
                textFragment.TextState.FontSize = 95;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
                textBuilder.AppendText(textFragment);

                textFragment = new Aspose.Pdf.Text.TextFragment(Label.UserName);
                textFragment.Position = new Aspose.Pdf.Text.Position(10, 400);
                textFragment.TextState.FontSize = 50;
                textFragment.TextState.Font = Aspose.Pdf.Text.FontRepository.FindFont("TimesNewRoman");
                textFragment.TextState.FontStyle = Aspose.Pdf.Text.FontStyles.Bold;
                textBuilder = new Aspose.Pdf.Text.TextBuilder(page);
                textBuilder.AppendText(textFragment);
            }

            System.IO.MemoryStream document = new System.IO.MemoryStream();
            PdfDocument.Save(document);
            this.radPdfViewer1.LoadDocument(document);
        }
    }
}
