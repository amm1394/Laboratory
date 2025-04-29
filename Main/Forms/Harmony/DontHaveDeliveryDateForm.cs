using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class DontHaveDeliveryDateForm : RASF.General.Forms.Base.DockContentForm
    {
        public DontHaveDeliveryDateForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTest.ExportToExcel("تست در حضور");
        }

        private void TestForThePresenceForm_Load(object sender, EventArgs e)
        {
            this.dontHaveDeliveryDateList1.Fill();
            this.grdTest.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.dontHaveDeliveryDateList1.Fill();
            this.grdTest.Refetch();
        }

        private void grdTest_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DetailOfReception CurrentRow = (RASF.General.Data.DetailOfReception)this.grdTest.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
