using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class EditWordDocumentForView : RASF.General.Forms.Base.DockContentForm
    {
        private String FileName;
        private String SaveFileName;
        public string Path { get; set; }
        public Guid DirName { get; set; }

        public Guid PartsTestMasterCode { get; set; }

        public EditWordDocumentForView(String fileName, Byte[] FileBytes)
        {
            InitializeComponent();
            this.ShowpnlButton = false;

            if (DesignMode == false)
            {
                this.editWord.WordDisablePrintHotKey(true);
                this.editWord.BeforeDocumentSaved += editWord_BeforeDocumentSaved;
                this.FileName = String.Format("{0}\\{1}", System.IO.Path.GetTempPath(), fileName);
                SaveFileName = fileName;
                System.IO.File.WriteAllBytes(FileName, FileBytes);
            }
        }

        public EditWordDocumentForView(String fileName, String saveFileName, Byte[] FileBytes)
        {
            InitializeComponent();
            this.ShowpnlButton = false;

            if (DesignMode == false)
            {

                this.TabText = System.IO.Path.GetFileNameWithoutExtension(fileName);

                this.editWord.WordDisablePrintHotKey(true);
                this.editWord.BeforeDocumentSaved += editWord_BeforeDocumentSaved;
                this.FileName = String.Format("{0}\\{1}", System.IO.Path.GetTempPath(), fileName);
                try
                {
                    SaveFileName = saveFileName;
                    System.IO.File.WriteAllBytes(FileName, FileBytes);
                }
                catch (Exception)
                {
                    MessageBox.Show("این تنوع باز می باشد");
                }

            }
        }

        private void editWord_BeforeDocumentSaved(object sender, EventArgs e)
        {
           // SaveDocument();
        }

        private void EditWordDocument_Load(object sender, EventArgs e)
        {
            this.editWord.CreateNew("Word.Application");
            this.editWord.Open(this.FileName);
            this.editWord.ClearTempFiles();
            this.editWord.BeforeDocumentClosed += editWord_BeforeDocumentClosed;
            Microsoft.Office.Interop.Word.Application app = (Microsoft.Office.Interop.Word.Application)this.editWord.GetApplication();
            app.Options.SaveInterval = 0;
            app.Options.BackgroundSave = false;
        }

        private void editWord_BeforeDocumentClosed(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Word.Document Document = (Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument();
            //if (Document.Saved == false)
            //{
            //    if (MessageBox.Show("تغییرات انجام شده ذخیره نشده است آیامایل به ذخیره آن می باشید.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        SaveDocument();
            //    }
            //}
        }

        private void SaveDocument()
        {
            //Int32 TotalPage = editWord.WordGetPageCount();
            //String TempDocName = GetDocument();

            //editWord.WordGetPageCount();

            //Guid PartsTestMasterCode;
            //if (Guid.TryParse(System.IO.Path.GetFileNameWithoutExtension(SaveFileName), out PartsTestMasterCode) == false)
            //{
            //    PartsTestMasterCode = DirName;
            //}

            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@data", System.IO.File.ReadAllBytes(TempDocName)));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", String.Format("{0}/{1}", Path, SaveFileName)));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("@TotalPage", editWord.WordGetPageCount()));
            //RASF.General.Lists.BanksList.FillScalar("InsertFile", Parameters);
            //System.IO.File.Delete(TempDocName);
        }

        private String GetDocument()
        {
            this.editWord.Save();
            String TempDocName = System.IO.Path.ChangeExtension(string.Format("{0}{1}", System.IO.Path.GetTempPath(), System.IO.Path.GetRandomFileName()), "Docx");

            System.IO.File.Copy(editWord.GetDocumentFullName(), TempDocName);

            try
            {
                Aspose.Words.Document doc = new Aspose.Words.Document(TempDocName);
            }
            catch
            {
                System.IO.File.Delete(TempDocName);
                return GetDocument();
            }
            return TempDocName;
        }

        private void EditWordDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.editWord.CloseDoc();
            this.editWord.Dispose();
            System.IO.File.Delete(this.FileName);
        }

        //public void Insert_Picture(String Title)
        //{
        //    RASF.Main.Forms.Reports.MetalPicture MetalPicture = new RASF.Main.Forms.Reports.MetalPicture();
        //    MetalPicture.PartsTestMasterCode = this.PartsTestMasterCode;
        //    MetalPicture.Text = Title;
        //    if (MetalPicture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        RASF.General.Classes.Utility.Carte_Table((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), MetalPicture.Selectedpic);
        //    }
        //}

        //public void Insert_PartPicture(String Title)
        //{
        //    RASF.Main.Forms.Reports.RecieptionPic RecieptionPic = new RASF.Main.Forms.Reports.RecieptionPic();
        //    RecieptionPic.PartsTestMasterCode = this.PartsTestMasterCode;
        //    RecieptionPic.Text = Title;
        //    if (RecieptionPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        RASF.General.Classes.Utility.Carte_Part_Table((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), RecieptionPic.Selectedpic);
        //    }
        //}

        //public void Insert_Standard(String Title)
        //{
        //    RASF.Main.Forms.Reports.InsertStandard InsertStandard = new RASF.Main.Forms.Reports.InsertStandard();
        //    InsertStandard.Text = Title;
        //    if (InsertStandard.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        RASF.General.Classes.Utility.Insert_Standard((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), InsertStandard.standardDataList1);

        //    }
        //}

    }
}
