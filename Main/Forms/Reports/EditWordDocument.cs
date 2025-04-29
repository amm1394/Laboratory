using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net; 

namespace RASF.Main.Forms.Reports
{
    public partial class EditWordDocument : RASF.General.Forms.Base.DockContentForm
    {
        private String FileName;
        private String SaveFileName;
        private String TempDocName;
        public string Path { get; set; }
        public Guid DirName { get; set; }

        public Guid PartsTestMasterCode { get; set; }

        public bool IsOpen { get; set; }

        public EditWordDocument(String fileName, Byte[] FileBytes)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.IsOpen = false;
            if (DesignMode == false)
            {
                this.editWord.WordDisablePrintHotKey(true);
                this.editWord.BeforeDocumentSaved += editWord_BeforeDocumentSaved;
                this.FileName = String.Format("{0}\\{1}", @"\\192.168.0.17\Report$\", fileName);
                SaveFileName = fileName;
                try
                {
                    System.IO.File.WriteAllBytes(FileName, FileBytes);
                }
                catch
                {
                    this.IsOpen = true;
                    MessageBox.Show("این گزارش توسط شما یا فرد دیگری در حال ویرایش می باشد.", "", MessageBoxButtons.OK);
//                    this.Close();
                }
            }
        }

        public EditWordDocument(String fileName, String saveFileName, Byte[] FileBytes)
        {
            InitializeComponent();
            this.ShowpnlButton = false;

            if (DesignMode == false)
            {

                this.TabText = System.IO.Path.GetFileNameWithoutExtension(fileName);

                this.editWord.WordDisablePrintHotKey(true);
                this.editWord.BeforeDocumentSaved += editWord_BeforeDocumentSaved;
              //GG  this.FileName = String.Format("{0}\\{1}", System.IO.Path.GetTempPath(), fileName);
                this.FileName = String.Format("{0}\\{1}", @"\\192.168.0.17\Report$\", fileName);
                try
                {
                    this.IsOpen = false;
                    SaveFileName = saveFileName;
                    System.IO.File.WriteAllBytes(FileName, FileBytes);
                }
                catch (Exception)
                {
                    this.IsOpen = true;
                    MessageBox.Show("این گزارش توسط شما یا فرد دیگری در حال ویرایش می باشد");
//                    this.Close();
                }

            }
        }

        private void editWord_BeforeDocumentSaved(object sender, EventArgs e)
        {
            SaveDocument();
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
            Microsoft.Office.Interop.Word.Document Document = (Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument();
            if (Document.Saved == false)
            {
                if (MessageBox.Show("تغییرات انجام شده ذخیره نشده است آیامایل به ذخیره آن می باشید.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    SaveDocument();
                }
            }

            //if (MessageBox.Show("آیا مایل به ارسال گزارش جهت تایید می باشد.", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            //    Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            //    Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
            //    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", ""));


            //    if (Path.ToLower().Contains("english") == true)
            //    {
            //        Parameters.Add(new System.Data.SqlClient.SqlParameter("@EnglishWorkFlowState", 1));
            //        Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersianWorkFlowState", SqlDbType.TinyInt));
            //        Parameters[4].Value = 0;
            //    }
            //    else
            //    {
            //        Parameters.Add(new System.Data.SqlClient.SqlParameter("@EnglishWorkFlowState", SqlDbType.TinyInt));
            //        Parameters[3].Value = 0;
            //        Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersianWorkFlowState", 1));
            //    }
              //  RASF.General.Lists.BanksList.FillScalar("WorkFlowDescription_Update", Parameters);
            //}
        
        }

        private void SaveDocument()
        {
            Int32 TotalPage = editWord.WordGetPageCount();
            TempDocName = GetDocument();

            editWord.WordGetPageCount();

            Guid PartsTestMasterCode;
            if (Guid.TryParse(System.IO.Path.GetFileNameWithoutExtension(SaveFileName), out PartsTestMasterCode) == false)
            {
                PartsTestMasterCode = DirName;
            }

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@data", System.IO.File.ReadAllBytes(TempDocName)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", String.Format("{0}/{1}", Path, SaveFileName)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartsTestMasterCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@TotalPage", editWord.WordGetPageCount()));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@HostName", Dns.GetHostEntry("localhost").HostName));

            RASF.General.Lists.BanksList.FillScalar("InsertFile", Parameters);
            System.IO.File.Delete(TempDocName);
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

        public void Insert_Was()
        {
            Was.Forms.Insert_Was insert_Was = new Was.Forms.Insert_Was();
            insert_Was.ReturnWas += insert_Was_ReturnWas;
            insert_Was.ShowDialog();
        }

        private void insert_Was_ReturnWas(object sender, EventArgs e)
        {
            Was.Insert_Was_Table.Insert_Table((RASF.General.Data.Csv_Contract)sender, (Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument());
        }
        public void Insert_arl()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"P:\DBF";
            openFileDialog1.Filter = "DBF Files|*.dbf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Arl.Forms.Insert_Arl insert_Arl = new Arl.Forms.Insert_Arl();
                insert_Arl.FileName = openFileDialog1.FileName;
               // insert_Arl.FileName = @"P:\DBF\123.dbf";
                insert_Arl.ReturnArl += Insert_Arl_ReturnArl;
                insert_Arl.ShowDialog();
            }
        }

        private void Insert_Arl_ReturnArl(object sender, EventArgs e)
        {
            Arl.Insert_Arl_Table.Insert_Table((RASF.General.Data.Arl_Elements)sender, (Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument());
        }

        public void Insert_Picture(String Title)
        {
            RASF.Main.Forms.Reports.MetalPicture MetalPicture = new RASF.Main.Forms.Reports.MetalPicture();
            MetalPicture.PartsTestMasterCode = this.PartsTestMasterCode;
            MetalPicture.Text = Title;
            if (MetalPicture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RASF.General.Classes.Utility.Carte_Table((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), MetalPicture.Selectedpic);
            }
        }

        public void Insert_PartPicture(String Title)
        {
            RASF.Main.Forms.Reports.RecieptionPic RecieptionPic = new RASF.Main.Forms.Reports.RecieptionPic();
            RecieptionPic.PartsTestMasterCode = this.PartsTestMasterCode;
            RecieptionPic.Text = Title;
            if (RecieptionPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RASF.General.Classes.Utility.Carte_Part_Table((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), RecieptionPic.Selectedpic);
            }
        }

        public void Insert_PartPicture2(String Title)
        {
            RASF.Main.Forms.Reports.RecieptionPic2 RecieptionPic = new RASF.Main.Forms.Reports.RecieptionPic2();
            RecieptionPic.PartsTestMasterCode = this.PartsTestMasterCode;
            RecieptionPic.Text = Title;
            if (RecieptionPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RASF.General.Classes.Utility.Carte_Part_Table((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), RecieptionPic.Selectedpic);
            }
        }

        public void Insert_Standard(String Title)
        {
            RASF.Main.Forms.Reports.InsertStandard InsertStandard = new RASF.Main.Forms.Reports.InsertStandard();
            InsertStandard.Text = Title;
            if (InsertStandard.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RASF.General.Classes.Utility.Insert_Standard((Microsoft.Office.Interop.Word.Document)this.editWord.ActiveDocument(), InsertStandard.standardDataList1);

            }
        }

    }
}
