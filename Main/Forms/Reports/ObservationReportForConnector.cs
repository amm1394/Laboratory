using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class ObservationReportForConnector : RASF.General.Forms.Base.DockContentForm
    {

        public ObservationReportForConnector()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.observationReportList1.spName = "ObservationReportForConnector";
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
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.observationReportList1.Fill(Parameter1);
                this.grdView.Refetch();
            }
        }

        private void grdView_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", ((RASF.General.Data.ObservationReport)this.grdView.CurrentRow.DataRow).PartsTestMasterCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ReportType", ((RASF.General.Data.ObservationReport)this.grdView.CurrentRow.DataRow).RType));
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
            //ViewReport.MdiParent = this.MdiParent;
            ViewReport.TabText = ((RASF.General.Data.ObservationReport)this.grdView.CurrentRow.DataRow).Name;
            ViewReport.ShowDocument(((NewMainForm)MyMdiParent).CurrentDockPanel);
        }
    }
}
