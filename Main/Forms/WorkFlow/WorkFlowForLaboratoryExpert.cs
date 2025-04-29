using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{

    public partial class WorkFlowForLaboratoryExpert : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle LastStateFormat;
        public Guid PartTestmaster;
        public int rtype;
        private int Type;
        private string ReportsType;
        private String ListName = "Reports";
        private String SiteUrl = "http://reports.razi-foundation.com";
        private DialogResult result;

        public WorkFlowForLaboratoryExpert()
        {
            InitializeComponent();

            this.LastStateFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.LastStateFormat.BackColor = Color.Yellow;
            this.LastStateFormat.ForeColor = Color.Black;

            Janus.Windows.GridEX.GridEXFormatCondition contractfc;
            contractfc = new Janus.Windows.GridEX.GridEXFormatCondition(grdContract.RootTable.Columns["LastStatus"], Janus.Windows.GridEX.ConditionOperator.Equal, 0);
            contractfc.FormatStyle.BackColor = Color.Yellow;
            contractfc.FormatStyle.ForeColor = Color.Black;
            grdContract.RootTable.FormatConditions.Add(contractfc);

            Janus.Windows.GridEX.GridEXFormatCondition partfc;
            partfc = new Janus.Windows.GridEX.GridEXFormatCondition(grdpart.RootTable.Columns["LastStatus"], Janus.Windows.GridEX.ConditionOperator.Equal, 0);
            partfc.FormatStyle.BackColor = Color.Yellow;
            partfc.FormatStyle.ForeColor = Color.Black;
            grdpart.RootTable.FormatConditions.Add(partfc);
        }

        private void grdContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsForWorkFlow CurrentRow = (RASF.General.Data.ContractsForWorkFlow)this.grdContract.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnExit.Enabled = this.btnSave.Enabled = false;
            foreach (RASF.General.Data.Parts_Tests_MasterForWorkFlow Parts_Tests_Master in this.parts_Tests_MasterForWorkFlowList1.Where(row => row.check == true))
            {
                if (Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "BA6A60D5-17A9-4E24-B3C5-1698BC567B36" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "B42C264F-F8C4-4C9B-9BC3-1AED58B95115" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "1A016389-B6FA-472C-B92D-1D0B4DEEF7F5"
                    || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "84E0A789-E91F-465B-801D-237141F146BC" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "900A16B5-4492-4484-97FA-2FB30F6BE764" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "D2F59A35-F75C-4923-BFC1-474F27B4D610"
                    || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "1F7685E5-4B18-4B18-B1AF-5BE42BE2CAE1" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "CFA101D5-9664-4C26-90EE-625376DD56AF" || Parts_Tests_Master.MasterTestCode.ToString().ToUpper() == "0C972635-760D-4044-BD5D-DE8CB3364ED7")
                {
                    result = MessageBox.Show("نتیجه مطابقت دارد؟", "Accept Or Reject", MessageBoxButtons.YesNo);

                    //if (result == DialogResult.Yes)
                    //{

                    //}
                    if (result == DialogResult.No)
                    {
                        List<System.Data.SqlClient.SqlParameter> ParametersA = new List<System.Data.SqlClient.SqlParameter>();
                        ParametersA.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", Parts_Tests_Master.PartsTestMasterCode));
                        RASF.General.Lists.BanksList.FillScalar("AcceptedTaeenGradePartTestMaster_Update", ParametersA);
                    }
                }

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", Parts_Tests_Master.PartsTestMasterCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@EnglishWorkFlowState", 0));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersianWorkFlowState", 0));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", txtDesc.Text));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@State", 1));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportOwner", Parts_Tests_Master.state));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastState", Parts_Tests_Master.LastState));

                if (Parts_Tests_Master.RType == 0)
                {
                    Parameters[1].Value = 0;
                    Parameters[2].Value = 1;
                }
                else if (Parts_Tests_Master.RType == 1)
                {
                    Parameters[1].Value = 1;
                    Parameters[2].Value = 0;
                }
                RASF.General.Lists.BanksList.FillScalar("WorkFlowDescription_Update", Parameters);
               

                List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", Parts_Tests_Master.PartsTestMasterCode));
                Parameters2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                RASF.General.Lists.BanksList.FillScalar("ExitReport_Update", Parameters2);

                Parts_Tests_Master.check = false;
            }
            txtDesc.Text = string.Empty;         

            FillGrids();
            this.btnExit.Enabled = this.btnSave.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.btnExit.Enabled = this.btnSave.Enabled = false;
            if ((String.IsNullOrWhiteSpace(txtDesc.Text) == true))
            {
                MessageBox.Show("توضیحات را وارد نمایید");
            }
            else
            {
                foreach (RASF.General.Data.Parts_Tests_MasterForWorkFlow Parts_Tests_Master in this.parts_Tests_MasterForWorkFlowList1.Where(row => row.check == true))
                {
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", Parts_Tests_Master.PartsTestMasterCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@EnglishWorkFlowState", 0));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersianWorkFlowState", 0));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", txtDesc.Text));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@State", 2));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportOwner", Parts_Tests_Master.state));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@LastState", Parts_Tests_Master.LastState));

                    if (Parts_Tests_Master.RType == 0)
                    {

                        Parameters[1].Value = 0;
                        Parameters[2].Value = -1;
                    }
                    else if (Parts_Tests_Master.RType == 1)
                    {

                        Parameters[1].Value = -1;
                        Parameters[2].Value = 0;
                    }


                    RASF.General.Lists.BanksList.FillScalar("WorkFlowDescription_Update", Parameters);
                    Parts_Tests_Master.check = false;
                }
                txtDesc.Text = string.Empty;
            }
            FillGrids();
            this.btnExit.Enabled = this.btnSave.Enabled = true;
        }

        private void WorkFlowForLaboratory_Load(object sender, EventArgs e)
        {

            this.grdContract.SelectionChanged += new System.EventHandler(this.grdContract_SelectionChanged);
            this.grdpart.SelectionChanged += new System.EventHandler(this.grdpart_SelectionChanged);
            this.grdpart_test_master.SelectionChanged += new System.EventHandler(this.grdpart_test_master_SelectionChanged);

            FillGrids();

            //this.grdContract_SelectionChanged(sender, e);
            //this.grdpart_SelectionChanged(sender, e);
            //this.grdpart_test_master_SelectionChanged(sender, e);
        }

        private void FillGrids()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@WorkFlowState", 2));
            this.contractsForWorkFlowList1.Fill(Parameters);

            this.grdContract.Refetch();

            //List<System.Data.SqlClient.SqlParameter> Parameters3 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters3.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            //this.workFlowDescriptionList1.Fill(Parameters3);
            //this.grdDesc.Refetch();

//            this.grdContract_SelectionChanged(this, new EventArgs());

//            this.grdContract.Refetch();
            
            //this.grdContract.SelectionChanged += new System.EventHandler(this.grdContract_SelectionChanged);
            //this.grdpart.SelectionChanged += new System.EventHandler(this.grdpart_SelectionChanged);
            //this.grdpart_test_master.SelectionChanged += new System.EventHandler(this.grdpart_test_master_SelectionChanged);

        }

        private void grdContract_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.partsMasterForWorkFlowList1.Clear();
                if ((this.grdContract.CurrentRow != null) && (this.grdContract.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
                {
                    if (grdContract.SelectedItems.Count > 0)
                    {
                        this.grpcontract.Text = "قرارداد" + " " + this.grdContract.CurrentRow.Cells["ContractNo"].Value.ToString();
                        Guid contracscode = new Guid(this.grdContract.CurrentRow.Cells["ContractCode"].Value.ToString());

                        List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                        Parameters1.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", contracscode));
                        Parameters1.Add(new System.Data.SqlClient.SqlParameter("@WorkFlowState", 2));
                        this.partsMasterForWorkFlowList1.Fill(Parameters1);

                        //                    this.grdpart.DataSource = this.partsMasterForWorkFlowList1.Where(r => r.ContractsBaseCode == contracscode).ToList();

                        //                    this.grdpart_SelectionChanged(sender, e);
                    }
                }

                this.grdpart.Refetch();
            }
            catch { }
          
        }

        private void grdpart_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("PartsMasterCode", ((RASF.General.Data.PartsMasterForWorkFlow)this.grdpart.CurrentRow.DataRow).PartsMasterCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ReportType", ((RASF.General.Data.PartsMasterForWorkFlow)this.grdpart.CurrentRow.DataRow).RType));
            this.getDocumentForPrintList1.Fill(Parameter);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", this.getDocumentForPrintList1.First().PartsTestMasterCode));
            string Pic = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic2_Select", Parameter2);

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", this.getDocumentForPrintList1.First().PartsTestMasterCode));
            string Pic1 = (string)RASF.General.Lists.BanksList.FillScalar("ChechReciption_Pic1_Select", Parameter3);

            //  Int32 StartPage = 1;

            if (Pic == "true")
            {
                this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture2.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterForWorkFlow)this.grdpart.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
            }


            if (Pic1 == "true")
            {
                this.getDocumentForPrintList1.Insert(0, RASF.General.Classes.MakePicture.MakePage(this.getDocumentForPrintList1.First().PartsTestMasterCode, ((RASF.General.Data.PartsMasterForWorkFlow)this.grdpart.CurrentRow.DataRow).RType, this.getDocumentForPrintList1.First().LaboratoryType, this.getDocumentForPrintList1.First().ManagerName, this.getDocumentForPrintList1.First().EnglishManagerName));
            }
            System.IO.MemoryStream PdfStrem = new System.IO.MemoryStream();
            
            using (Aspose.Pdf.Document PdfDocument = new Aspose.Pdf.Document())
            {
                using (System.IO.MemoryStream pdf = new System.IO.MemoryStream())
                {
                    foreach (RASF.General.Data.GetDocumentForPrint Document in this.getDocumentForPrintList1)
                    {
                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Document.Content))
                        {
                            Aspose.Words.Document Doc = new Aspose.Words.Document(ms);
                            Doc.Save(pdf, Aspose.Words.SaveFormat.Pdf);
                            Aspose.Pdf.Document LoadedDocument = new Aspose.Pdf.Document(pdf);
                            foreach (Aspose.Pdf.Page page in LoadedDocument.Pages)
                            {
                                PdfDocument.Pages.Add(page);
                            }
                        }
                    }
                    PdfDocument.Save(PdfStrem);
                }
            }
         
            Main.Forms.Reports.ViewReport ViewReport = new Main.Forms.Reports.ViewReport(PdfStrem, false);
            ViewReport.TabText ="تنوع"+"-"+ Convert.ToString(((RASF.General.Data.PartsMasterForWorkFlow)this.grdpart.CurrentRow.DataRow).PartNumber);
            ViewReport.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
        }            

        private void grdpart_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.parts_Tests_MasterForWorkFlowList1.Clear();
                if ((this.grdpart.CurrentRow != null) && (this.grdpart.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
                {
                    if (this.grdpart.SelectedItems.Count > 0)
                    {
                        this.grpparts.Text = "تنوع" + " " + this.grdpart.CurrentRow.Cells["PartNumber"].Value.ToString();
                        Guid PartsCode = new Guid(this.grdpart.CurrentRow.Cells["PartsMasterCode"].Value.ToString());
                        Boolean rtype = Convert.ToBoolean((this.grdpart.CurrentRow.Cells["RType"].Value.ToString()));
                        if (rtype == true)
                        {
                            Type = 1;
                        }
                        else
                        {
                            Type = 0;
                        }

                        List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@PartsMasterCode", PartsCode));
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@WorkFlowState", 2));
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@RType", this.grdpart.CurrentRow.Cells["RType"].Value.ToString()));
                        this.parts_Tests_MasterForWorkFlowList1.Fill(Parameters2);

                        //                    this.grdpart_test_master.DataSource = this.parts_Tests_MasterForWorkFlowList1.Where(r => r.PartsMasterCode == PartsCode && r.RType == Type).ToList();


                    }

                }
                this.grdpart_test_master.Refetch();
                //this.txtDesc.DataBindings.Clear();
                //this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grdpart_test_master.DataSource, "Description", true));
            }
            catch { }

        }

        private void grdpart_test_master_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "MasterName":
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("ReportType", ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).RType));
                    byte[] Template = (byte[])RASF.General.Lists.BanksList.FillScalar("GetFile_Select", Parameters);

                    System.IO.MemoryStream PdfStrem = new System.IO.MemoryStream();
                    using (System.IO.MemoryStream DocStrem = new System.IO.MemoryStream(Template))
                    {
                        Aspose.Words.Document Document = new Aspose.Words.Document(DocStrem);

                        Aspose.Words.Saving.PdfSaveOptions SaveOptions = new Aspose.Words.Saving.PdfSaveOptions();
                        SaveOptions.EncryptionDetails = new Aspose.Words.Saving.PdfEncryptionDetails("", "test", Aspose.Words.Saving.PdfEncryptionAlgorithm.RC4_128);
                        SaveOptions.EncryptionDetails.Permissions = Aspose.Words.Saving.PdfPermissions.DisallowAll;

                        Document.Save(PdfStrem, SaveOptions);
                    }

                    Main.Forms.Reports.ViewReport ViewReport = new Main.Forms.Reports.ViewReport(PdfStrem, false);
                    ViewReport.TabText = ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).MasterName;
                    ViewReport.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
                    break;

                case "ReportType":

                    List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters1.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode));
                    Parameters1.Add(new System.Data.SqlClient.SqlParameter("ReportType", ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).RType));
                    Template = (byte[])RASF.General.Lists.BanksList.FillScalar("GetFile_Select", Parameters1);

                    if (((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).RType == 1)
                    {
                        Template = RASF.General.Classes.BookMarks.SetBookMarks(((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode, Template, RASF.General.Enums.BookMark.EditState, true);
                        ListName = "English Reports";
                    }
                    else
                    {
                        Template = RASF.General.Classes.BookMarks.SetBookMarks(((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode, Template, RASF.General.Enums.BookMark.EditState, false);
                        ListName = "Reports";
                    }

                    string fullPath = String.Format("{0}\\{1}", System.IO.Path.GetTempPath(), ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).FileName);
                    bool isAllow = false;
                    if (System.IO.File.Exists(fullPath) == true)
                    {

                        try
                        {
                            System.IO.File.Delete(fullPath);
                            isAllow = true;
                        }
                        catch (Exception)
                        {
                        }

                        if (isAllow == false)
                        {
                            MessageBox.Show("این تنوع باز می باشد");
                        }


                    }
                    else
                    {
                        isAllow = true;
                    }

                    if (isAllow == true)
                    {
                        Main.Forms.Reports.EditWordDocument EditDocument = new Main.Forms.Reports.EditWordDocument(((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).FileName, String.Format("{0}.Docx", ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode), Template);
                        if (EditDocument.IsOpen == false)
                        {
                            EditDocument.Path = String.Format("{0}/{1}/{2}", SiteUrl, ListName, ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).DirName);
                            EditDocument.PartsTestMasterCode = ((RASF.General.Data.Parts_Tests_MasterForWorkFlow)this.grdpart_test_master.CurrentRow.DataRow).PartsTestMasterCode;
                            EditDocument.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
                        }
                    }
                    break;
            }
        }

        private void grdpart_test_master_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.workFlowDescriptionList1.Clear();
                if ((this.grdpart_test_master.CurrentRow != null) && (this.grdpart_test_master.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
                {
                    if (grdpart_test_master.CurrentRow.Cells["state"].Value.ToString() == "مدیر علمی")
                    {
                        grdpart_test_master.RootTable.Columns["ReportType"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
                    }
                    else
                    {
                        grdpart_test_master.RootTable.Columns["ReportType"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.TextButton;
                    }
                    if (this.grdpart_test_master.SelectedItems.Count > 0)
                    {
                        this.grpparttestmaster.Text = this.grdpart_test_master.CurrentRow.Cells["MasterName"].Value.ToString();
                        Guid PartsTestCode = new Guid(this.grdpart_test_master.CurrentRow.Cells["PartsTestMasterCode"].Value.ToString());

                        List<System.Data.SqlClient.SqlParameter> Parameters3 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters3.Add(new System.Data.SqlClient.SqlParameter("@PartTestMasterCode", PartsTestCode));
                        Parameters3.Add(new System.Data.SqlClient.SqlParameter("@RType", this.grdpart_test_master.CurrentRow.Cells["RType"].Value.ToString()));
                        this.workFlowDescriptionList1.Fill(Parameters3);

                        //Int16 rtype = Convert.ToInt16((this.grdpart_test_master.CurrentRow.Cells["RType"].Value.ToString()));
                        //if (rtype == 1)
                        //{
                        //    this.grdDesc.DataSource = this.workFlowDescriptionList1.Where(r => r.PartTestMasterCode == PartsTestCode && r.IsEnglish == true && r.Ispershian == false).ToList();
                        //}
                        //else
                        //{
                        //    this.grdDesc.DataSource = this.workFlowDescriptionList1.Where(r => r.PartTestMasterCode == PartsTestCode && r.Ispershian == true && r.IsEnglish == false).ToList();

                        //}
                    }
                }
                this.grdDesc.Refetch();
            }
            catch { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrids();

            //this.grdContract.SelectionChanged += new System.EventHandler(this.grdContract_SelectionChanged);
            //this.grdpart.SelectionChanged += new System.EventHandler(this.grdpart_SelectionChanged);
            //this.grdpart_test_master.SelectionChanged += new System.EventHandler(this.grdpart_test_master_SelectionChanged);

            //this.grdContract_SelectionChanged(sender, e);
            //this.grdpart_SelectionChanged(sender, e);
            //this.grdpart_test_master_SelectionChanged(sender, e);
        }

        private void grdpart_EditingCell(object sender, Janus.Windows.GridEX.EditingCellEventArgs e)
        {
            if ((grdpart.CurrentRow != null) && (e.Column.Index == 0))
            {
                e.Cancel = true;
                this.grdpart.CurrentRow.Cells["Check"].Value = !Convert.ToBoolean(e.Value);
                foreach (RASF.General.Data.Parts_Tests_MasterForWorkFlow Parts_Tests_Master in (RASF.General.Lists.Parts_Tests_MasterForWorkFlowList)this.grdpart_test_master.DataSource)
                {
                    Parts_Tests_Master.check = Convert.ToBoolean(this.grdpart.CurrentRow.Cells["Check"].Value);
                }
                this.grdpart_test_master.Refetch();
            }
        }

     
    }
}
