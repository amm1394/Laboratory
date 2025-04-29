using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class EditReportForView : RASF.General.Forms.Base.DockContentForm
    {
        private String ListName = "Reports";
        private String SiteUrl = "http://reports.razi-foundation.com";

        public EditReportForView()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                this.findContractNoList1.Fill(Parameter);

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                this.observationReportWordList1.Fill(Parameter1);
                this.grdMaster.Refetch();
            }
        }

        private void grdMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ReportType", ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).RType));
            byte[] Template = (byte[])RASF.General.Lists.BanksList.FillScalar("GetFile_Select", Parameters);

            if (((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).RType == true)
            {
                Template = RASF.General.Classes.BookMarks.SetBookMarks(((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode, Template, RASF.General.Enums.BookMark.EditState, true);
                ListName = "English Reports";
            }
            else
            {
                Template = RASF.General.Classes.BookMarks.SetBookMarks(((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode, Template, RASF.General.Enums.BookMark.EditState, false);
                ListName = "Reports";
            }

            string fullPath = String.Format("{0}\\{1}", System.IO.Path.GetTempPath(), ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).FileName);
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
                Main.Forms.Reports.EditWordDocumentForView EditDocument = new Main.Forms.Reports.EditWordDocumentForView(((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).FileName, String.Format("{0}.Docx", ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode), Template);
                EditDocument.Path = String.Format("{0}/{1}/{2}", SiteUrl, ListName, ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).DirName);
                EditDocument.PartsTestMasterCode = ((RASF.General.Data.ObservationReport)this.grdMaster.CurrentRow.DataRow).PartsTestMasterCode;
                EditDocument.Show();
            }
        }
    }
}
