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
    public partial class AddReport : RASF.General.Forms.Base.DockContentForm
    {
        private String ListName;
        private String SiteUrl = "http://reports.razi-foundation.com";
     //   private Int16 Result;

        public AddReport()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
            //Parameter2.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            //Result =Convert.ToInt16(RASF.General.Lists.BanksList.FillScalar("EnglishName_Select", Parameter2));
            //if (Result == 1)
            //{
                if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.findContractNoList1.Fill(Parameter);
                    if (findContractNoList1.list.Count > 0)
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("HasReport", false));
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("HasReportEnglish", false));
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                        this.addReportList1.Fill(Parameter1);
                        this.grdMaster.Refetch();
                        FillTemplate();
                    }

                }
            //}
            //else
            //{
            //    MessageBox.Show("نام انگلیسی شرکت وارد نشده است با پذیرش تماس بگیرید");
            //}
        }


        private void FillTemplate()
        {
            
            if ((this.grdMaster.CurrentRow != null) && (this.grdMaster.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                RASF.General.Data.AddReport Currenrow = (RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow;
                this.ListName = Currenrow.ListName;
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListName", Currenrow.TemplateList));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@DirName", String.Format("{0}/{1}", Currenrow.TemplateList, Currenrow.MasterTestCode)));
                this.definitionTemplateList1.Fill(Parameters);
            }

            this.grdTemp.Refetch();
        }

        private void grdMaster_SelectionChanged(object sender, EventArgs e)
        {
            FillTemplate();
        }

        private void grdTemp_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", ((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@TemplateUrl", ((RASF.General.Data.DefinitionTemplate)this.grdTemp.CurrentRow.DataRow).FilePath));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@ListName", ListName));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@HostName", Dns.GetHostEntry("localhost").HostName));

            byte[] Template = (byte[])RASF.General.Lists.BanksList.FillScalar("CreateDocumentsInReports_Select", Parameters);
         //  byte[] Template = System.IO.File.ReadAllBytes(@"c:\Template.docx");

            Template = RASF.General.Classes.BookMarks.SetBookMarks(((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode, Template, RASF.General.Enums.BookMark.AddState, ((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).RType);

            Main.Forms.Reports.EditWordDocument EditDocument = new Main.Forms.Reports.EditWordDocument(((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).FileName, String.Format("{0}.Docx", ((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode), Template);
            EditDocument.Path = String.Format("{0}/{1}/{2}", SiteUrl, ListName, ((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).DirName);
            EditDocument.PartsTestMasterCode = ((RASF.General.Data.AddReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode;

            //EditDocument.MdiParent = this.MdiParent;
            //RASF.Main.Forms.NewMainForm newMainForm = new NewMainForm();
            //newMainForm.ShowDocument(EditDocument);
           // EditDocument.MdiParent = MyMdiParent;
            //EditDocument.Show();

            //NewMainForm main = (NewMainForm)MyMdiParent;
            //main.ShowDocument(EditDocument);
            EditDocument.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("HasReport", false));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("HasReportEnglish", false));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.addReportList1.Fill(Parameter1);
            this.grdMaster.Refetch();
        }
    }
}
