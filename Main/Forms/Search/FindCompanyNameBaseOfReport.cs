using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Search
{
    public partial class FindCompanyNameBaseOfReport : RASF.General.Forms.Base.DockContentForm
    {
        public FindCompanyNameBaseOfReport()
        {
            InitializeComponent();
            this.ShowpnlUpdate = false;
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("CompanyName", String.Format("%{0}%", this.txtSearch.Text)));
                this.findCompanyNameBaseOfReportList1.Fill(Parameter);

                grdContracts.Refetch();
            }
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.FindLetterNoPartsName CurrentRow = (RASF.General.Data.FindLetterNoPartsName)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("نتایج جستجو");
        }
    }
}
