using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Reports
{
    [System.ComponentModel.Category("RASF")]
    public partial class EditDefinitionPersionTemplates : RASF.General.Forms.Base.DockContentForm
    {
        private String DirName;
        private String ListName;
        private String SiteUrl = "http://reports.razi-foundation.com";
        private String Path = null;
        public EditDefinitionPersionTemplates(String listName)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.ListName = listName;
        }

        private void LABORATORY_Load(object sender, EventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", General.Classes.Global.CurrentUserCode));
            this.laboratoryReportsList1.Fill(Parameters);
            this.mainTestList1.Fill();
            this.masterTestList1.Fill();

            this.grdlaboratory.Refetch();
            this.grdMain.Refetch();
            this.grdMaster.Refetch();

            this.grdlaboratory_SelectionChanged(sender, e);
            this.grdMain_SelectionChanged(sender, e);
            this.grdMaster_SelectionChanged(sender, e);
        }

        private void grdlaboratory_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdlaboratory.CurrentRow != null) && (this.grdlaboratory.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grp_Lab.Text = this.grdlaboratory.CurrentRow.Cells["LaboratoryName"].Value.ToString();
                this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"].DefaultValue = this.grdlaboratory.CurrentRow.Cells["LaboratoryCode"].Value;
                this.grdMain.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdlaboratory.CurrentRow.Cells["LaboratoryCode"].Value));
                this.grdMain.Enabled = true;
                this.grdMaster.Enabled = true;
            }
            else
            {
                this.grp_Lab.Text = "";
                this.grdMain.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdMain.Enabled = false;
                this.grdMaster.Enabled = false;
            }
            this.grdMain.MoveFirst();
        }

        private void grdMain_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdMain.CurrentRow != null) && (this.grdMain.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpMain.Text = this.grdMain.CurrentRow.Cells["MainTestName"].Value.ToString();
                this.grdMaster.RootTable.Columns["MainTestCode"].DefaultValue = this.grdMain.CurrentRow.Cells["MainCode"].Value;
                this.grdMaster.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMaster.RootTable.Columns["MainTestCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdMain.CurrentRow.Cells["MainCode"].Value));
                this.grdMaster.Enabled = true;
            }
            else
            {
                this.grpMain.Text = "";
                this.grdMaster.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMaster.RootTable.Columns["MainTestCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdMaster.Enabled = false;
            }
            this.grdMaster.MoveFirst();
        }

        private void grdMaster_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdMaster.CurrentRow != null) && (this.grdMaster.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpmaster.Text = this.grdMaster.CurrentRow.Cells["MasterName"].Value.ToString();
                Path = String.Format("{0}/{1}", ListName, this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value.ToString());
                DirName = this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value.ToString();
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListName", ListName));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@DirName", Path));
                this.definitionTemplateList1.Fill(Parameters);

                //if (ListName == "English Template")
                //{
                //    this.grdTemplate.AlowRetrieveStructure = true;
                //    this.grdTemplate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
                //    Janus.Windows.GridEX.GridEXColumnSet CS = new Janus.Windows.GridEX.GridEXColumnSet();
                //    CS.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center;
                //    CS.Width = 200;
                //    this.grdTemplate.RootTable.ColumnSets.Add(CS);
                //}

                this.grdTemplate.Refetch();

            }
            else
            {
                Path = null;
                this.grpmaster.Text = "";
            }
        }

        private void grdTemplate_ReturnRow(General.Events.ReturnRowEventArgs e)
        {

            RASF.General.Data.DefinitionTemplate DefinitionTemplate = (RASF.General.Data.DefinitionTemplate)e.row;
            DefinitionTemplate.FileName = RASF.General.Classes.Utility.CorrectFileName(DefinitionTemplate.FileName);
            int Count = this.definitionTemplateList1.Count(Row => Row.FileName == DefinitionTemplate.FileName);
            if ((Count == 1) && (String.IsNullOrWhiteSpace(DefinitionTemplate.FileName) == false))
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", String.Format("{0}.Docx", DefinitionTemplate.FileName)));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@DirName", DirName));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@TemplateList", ListName));

                byte[] Template = (byte[])this.definitionTemplateList1.FillScalar(Parameters);

                Main.Forms.Reports.EditWordDocument EditDocument = new Main.Forms.Reports.EditWordDocument(String.Format("{0}.Docx", DefinitionTemplate.FileName), Template);
                if (EditDocument.IsOpen == false)
                {
                    EditDocument.Path = String.Format("{0}/{1}/{2}", SiteUrl, ListName, DirName);
                    EditDocument.DirName = new Guid(DirName);
                    //EditDocument.MdiParent = this.MdiParent;
                    EditDocument.TabText = DefinitionTemplate.FileName;
                    EditDocument.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("نام فایل صحیح نمی باشد");
                this.definitionTemplateList1.Remove(DefinitionTemplate);
            }
            this.grdTemplate.Refetch();
        }

        private void grdTemplate_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if ((this.grdTemplate.CurrentRow != null) && (this.grdTemplate.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                RASF.General.Data.DefinitionTemplate DefinitionTemplate = (RASF.General.Data.DefinitionTemplate)this.grdTemplate.CurrentRow.DataRow;
                switch (e.Column.Key)
                {
                    case "FileName":

                      

                        List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters.Add(new System.Data.SqlClient.SqlParameter("@FileName", DefinitionTemplate.FilePath));
                        Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListName", ListName));
                        byte[] Template = (byte[])RASF.General.Lists.BanksList.FillScalar("SelectFileForTemp", Parameters);

                        Main.Forms.Reports.EditWordDocument EditDocument = new Main.Forms.Reports.EditWordDocument(String.Format("{0}.Docx", System.IO.Path.GetFileNameWithoutExtension(DefinitionTemplate.FileName)), Template);
                        if (EditDocument.IsOpen == false)
                        {
                            EditDocument.Path = String.Format("{0}/{1}/{2}", SiteUrl, ListName, DirName);
                            EditDocument.PartsTestMasterCode = Guid.Empty;
                            EditDocument.DirName = new Guid(DirName);
                            // EditDocument.MdiParent = this.MdiParent;
                            //EditDocument.Show();
                            EditDocument.TabText = DefinitionTemplate.FileName;
                            EditDocument.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
                        }


                        break;
                    case "Column2":
                         List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@FileName", DefinitionTemplate.FileName));
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@ListName", ListName));
                        Parameters2.Add(new System.Data.SqlClient.SqlParameter("@ID", DefinitionTemplate.ID));
                        RASF.General.Lists.BanksList.FillScalar("DefinitionTempLaboratory_Update", Parameters2);
                        break;

                    case "Column1":
                        List<System.Data.SqlClient.SqlParameter> Parameters3 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters3.Add(new System.Data.SqlClient.SqlParameter("@DirName", DirName));
                        Parameters3.Add(new System.Data.SqlClient.SqlParameter("@ListName", ListName));
                        Parameters3.Add(new System.Data.SqlClient.SqlParameter("@ID", DefinitionTemplate.ID));
                        RASF.General.Lists.BanksList.FillScalar("DefinitionTempLaboratory_Delete", Parameters3);

                        break;

                }

            }
            this.grdTemplate.Refetch();
        }
      

        private void btnSave_Click(object sender, EventArgs e)
        {
           //if ((this.grdTemplate.CurrentRow != null) && (this.grdTemplate.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
           // {
                //RASF.General.Data.DefinitionTemplate DefinitionTemplate = (RASF.General.Data.DefinitionTemplate)this.grdTemplate.CurrentRow.DataRow;
                //DefinitionTemplate.ListName = "Pershian Template";
                //DefinitionTemplate.DirName = DirName; 
                     
               this.definitionTemplateList1.Update();

            this.grdTemplate.Refetch();
         //  }
        }


    }
}
