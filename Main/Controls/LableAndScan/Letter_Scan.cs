using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RASF.Main.Controls //Contracts_Letter_Scan
{
    public partial class Letter_Scan : UserControl
    {
        private delegate void MakePageDelegete(String FileName, Boolean DeleteFile);
        private System.IO.MemoryStream document;
        private Aspose.Pdf.Document PdfDocument;

        public Byte[] Document
        {
            get
            {
                if (this.document != null)
                {
                    return this.document.ToArray();
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.radPdfViewer1.UnloadDocument();
                if (value != null)
                {
                    this.document = new System.IO.MemoryStream(value);
                    this.PdfDocument = new Aspose.Pdf.Document(this.document);
                    this.radPdfViewer1.LoadDocument(this.document);
                }
            }
        }

        private System.IO.FileSystemWatcher watcher;
        public Letter_Scan()
        {
            InitializeComponent();

            this.radPdfViewer1.ShowThubnails();
            this.radPDFCommandBar1.ShowPrintPreview = false;

        }

        private void radPDFCommandBar1_OpenClick(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String FileName in openFileDialog1.FileNames)
                {
                    if (System.IO.Path.GetExtension(FileName).ToLower() == ".pdf")
                    {
                        this.MakePage(FileName, false);
                    }
                }
            }
        }

        private void MakePage(String FileName, Boolean DeleteFile)
        {
            try
            {
                Aspose.Pdf.Document Doc = new Aspose.Pdf.Document(FileName);
                foreach (Aspose.Pdf.Page page in Doc.Pages)
                {
                    this.PdfDocument.Pages.Add(page);
                }
                this.document = new System.IO.MemoryStream();
                PdfDocument.Save(this.document);
                this.radPdfViewer1.LoadDocument(this.document);
                if (DeleteFile == true)
                {
                    System.IO.File.Delete(FileName);
                }
            }
            catch
            {
            }

            this.radPdfViewer1.Refresh();
        }

        private void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            System.Threading.Thread.Sleep(5);
            if (this.InvokeRequired)
            {
                this.Invoke(new MakePageDelegete(this.MakePage), e.FullPath, true);
            }
            else
            {
                this.MakePage(e.FullPath, true);
            }
        }

        public new void Dispose()
        {
            if (this.watcher != null)
            {
                this.watcher.Dispose();
            }

            if (this.document != null)
            {
                this.document.Dispose();
            }

            if (this.PdfDocument != null)
            {
                this.PdfDocument.Dispose();
            }
        }

        private void Letter_Scan_Load(object sender, EventArgs e)
        {
            if (this.PdfDocument == null)
            {
                this.PdfDocument = new Aspose.Pdf.Document();
            }
        }

        public void Intial_Watcher()
        {
           // string scanpath = General.Resource.Documents.ScanPath;

            //string drive = System.IO.Path.GetPathRoot(@"D:\scan\");
            //if (System.IO.Directory.Exists(drive) == true)
            //{
            //    if (System.IO.Directory.Exists(@"D:\scan\") == false)
            //    {
            //        System.IO.Directory.CreateDirectory(@"D:\scan\");
            //    }

            //    this.watcher = new System.IO.FileSystemWatcher();
            //    this.watcher.Path = @"D:\scan\";
            //    this.watcher.NotifyFilter = System.IO.NotifyFilters.Size;
            //    this.watcher.Filter = "*.pdf";
            //    this.watcher.Changed += Watcher_Changed;
            //    this.watcher.EnableRaisingEvents = true;
            //}
        }
        public void Genrate_PartPic_Pdf(RASF.General.Lists.Part_PicList Part_PicList)
        {
            this.radPdfViewer1.UnloadDocument();
            this.document = new System.IO.MemoryStream();
            String FileName = String.Format("{0}{1}.pdf", System.IO.Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()));
            try
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(FileName, System.IO.FileMode.Create));
                    doc.SetMargins(5f, 5f, 5f, 5f);
                    doc.SetPageSize(new iTextSharp.text.Rectangle(650, 520));
                    doc.Open();
                    foreach (RASF.General.Data.Part_Pic PartPic in Part_PicList)
                    {
                        if (PartPic.Picture != null)
                        {
                            using (Image OriginalImage = Bitmap.FromStream(new System.IO.MemoryStream(PartPic.Picture)))
                            {
                                using (Bitmap Image = new Bitmap(640, 510))
                                {
                                    using (Graphics g = Graphics.FromImage(Image))
                                    {
                                        g.DrawImage(OriginalImage, new Rectangle(0, 30, 640, 480));

                                        using (System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                                        {
                                            g.FillRectangle(brush, 0, 0, 640, 30);
                                        }

                                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                                        RASF.General.Classes.CorrectString CorrectString = new General.Classes.CorrectString();
                                        CorrectString.Correction(PartPic.Name);

                                        int pos = 640;
                                        using (Font stringFont = new Font("Lotus", 9))
                                        {
                                            SizeF stringSize = new SizeF();
                                            string txt = String.Format("تنوع {0}", PartPic.PartNumber);
                                            stringSize = g.MeasureString(txt, stringFont);

                                            pos -= (int)stringSize.Width;

                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                        }

                                        int j = 0;

                                        foreach (String txt in CorrectString.CorrectedText)
                                        {
                                            if (String.IsNullOrEmpty(txt.Trim()) == false)
                                            {
                                                if ((int)txt[0] > 127)
                                                {
                                                    using (Font stringFont = new Font("Lotus", 9))
                                                    {
                                                        SizeF stringSize = new SizeF();
                                                        stringSize = g.MeasureString(txt, stringFont);

                                                        pos -= (int)stringSize.Width;

                                                        g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                    }
                                                }
                                                else
                                                {
                                                    if ((CorrectString.Max_list[j] < 58) && (CorrectString.IsComplex == false))
                                                    {
                                                        using (Font stringFont = new Font("Lotus", 9))
                                                        {
                                                            SizeF stringSize = new SizeF();
                                                            stringSize = g.MeasureString(txt, stringFont);

                                                            pos -= (int)stringSize.Width;

                                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                        }
                                                    }
                                                    else
                                                    {
                                                        using (Font stringFont = new Font("Calibri", 7))
                                                        {
                                                            SizeF stringSize = new SizeF();
                                                            stringSize = g.MeasureString(txt, stringFont);

                                                            pos -= (int)stringSize.Width;

                                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                        }
                                                    }
                                                }
                                            }
                                            g.Flush();
                                            j++;
                                        }


                                        g.Flush();
                                    }
                                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    image.Normalize();
                                    doc.Add(image);
                                }
                            }
                        }
                    }
                }

                this.document = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(FileName));
                System.IO.File.Delete(FileName);
                this.radPdfViewer1.LoadDocument(this.document);
            }
            catch
            {
            }
        }

        public void Genrate_PartPic2_Pdf(RASF.General.Lists.Part_Pic2Lis Part_Pic2List)
        {
            this.radPdfViewer1.UnloadDocument();
            this.document = new System.IO.MemoryStream();
            String FileName = String.Format("{0}{1}.pdf", System.IO.Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()));
            try
            {
                using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(FileName, System.IO.FileMode.Create));
                    doc.SetMargins(5f, 5f, 5f, 5f);
                    doc.SetPageSize(new iTextSharp.text.Rectangle(650, 520));
                    doc.Open();
                    foreach (RASF.General.Data.Part_Pic PartPic in Part_Pic2List)
                    {
                        if (PartPic.Picture2 != null)
                        {
                            using (Image OriginalImage = Bitmap.FromStream(new System.IO.MemoryStream(PartPic.Picture2)))
                            {
                                using (Bitmap Image = new Bitmap(640, 510))
                                {
                                    using (Graphics g = Graphics.FromImage(Image))
                                    {
                                        g.DrawImage(OriginalImage, new Rectangle(0, 30, 640, 480));

                                        using (System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White))
                                        {
                                            g.FillRectangle(brush, 0, 0, 640, 30);
                                        }

                                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                                        RASF.General.Classes.CorrectString CorrectString = new General.Classes.CorrectString();
                                        CorrectString.Correction(PartPic.Name);

                                        int pos = 640;
                                        using (Font stringFont = new Font("Lotus", 9))
                                        {
                                            SizeF stringSize = new SizeF();
                                            string txt = String.Format("تنوع {0}", PartPic.PartNumber);
                                            stringSize = g.MeasureString(txt, stringFont);

                                            pos -= (int)stringSize.Width;

                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                        }

                                        int j = 0;

                                        foreach (String txt in CorrectString.CorrectedText)
                                        {
                                            if (String.IsNullOrEmpty(txt.Trim()) == false)
                                            {
                                                if ((int)txt[0] > 127)
                                                {
                                                    using (Font stringFont = new Font("Lotus", 9))
                                                    {
                                                        SizeF stringSize = new SizeF();
                                                        stringSize = g.MeasureString(txt, stringFont);

                                                        pos -= (int)stringSize.Width;

                                                        g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                    }
                                                }
                                                else
                                                {
                                                    if ((CorrectString.Max_list[j] < 58) && (CorrectString.IsComplex == false))
                                                    {
                                                        using (Font stringFont = new Font("Lotus", 9))
                                                        {
                                                            SizeF stringSize = new SizeF();
                                                            stringSize = g.MeasureString(txt, stringFont);

                                                            pos -= (int)stringSize.Width;

                                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                        }
                                                    }
                                                    else
                                                    {
                                                        using (Font stringFont = new Font("Calibri", 7))
                                                        {
                                                            SizeF stringSize = new SizeF();
                                                            stringSize = g.MeasureString(txt, stringFont);

                                                            pos -= (int)stringSize.Width;

                                                            g.DrawString(txt, stringFont, Brushes.Black, new RectangleF(pos, (30 - stringSize.Height) / 2, stringSize.Width, stringSize.Height));
                                                        }
                                                    }
                                                }
                                            }
                                            g.Flush();
                                            j++;
                                        }


                                        g.Flush();
                                    }
                                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    image.Normalize();
                                    doc.Add(image);
                                }
                            }
                        }
                    }
                }

                this.document = new System.IO.MemoryStream(System.IO.File.ReadAllBytes(FileName));
                System.IO.File.Delete(FileName);
                this.radPdfViewer1.LoadDocument(this.document);
            }
            catch
            {
            }
        }


    }
}
