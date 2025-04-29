using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ViewRegisteredReportSamene : RASF.General.Forms.Base.DockContentForm
    {
        public ViewRegisteredReportSamene()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.viewSabtSamaneList1.spName = "ViewRegisterSameneh";
        }

        private void ViewSabtSamane_Load(object sender, EventArgs e)
        {
            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.grdcontracts.ExportToExcel("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.viewSabtSamaneList1.Fill();
            this.grdcontracts.Refetch();
        }

        private void grdcontracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ViewSabtSamane CurrentRow = (RASF.General.Data.ViewSabtSamane)this.grdcontracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
