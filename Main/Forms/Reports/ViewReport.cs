using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class ViewReport : RASF.General.Forms.Base.DockContentForm
    {
        public ViewReport(System.IO.MemoryStream PdfStrem, Boolean AllowPrint)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.radPdfViewer1.LoadDocument(PdfStrem);

            this.radPdfViewerNavigator1.AssociatedViewer.RadContextMenu.Items[1].Enabled = false;
            this.radPdfViewerNavigator1.AssociatedViewer.RadContextMenu.Items[2].Enabled = false;
            this.radPdfViewerNavigator1.AssociatedViewer.RadContextMenu.Items[5].Enabled = false;
            this.radPdfViewerNavigator1.AssociatedViewer.RadContextMenu.Items[10].Enabled = false;
            this.radPdfViewerNavigator1.CommandBarElement.Rows[0].Strips[0].Items[0].Enabled = false;
            this.radPdfViewerNavigator1.CommandBarElement.Rows[0].Strips[0].Items[9].Enabled = false;
            this.radPdfViewerNavigator1.CommandBarElement.Rows[0].Strips[0].Items[1].Enabled = AllowPrint;
        }
    }
}
