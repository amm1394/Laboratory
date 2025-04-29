using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class StandardStudy : RASF.General.Forms.Base.DockContentForm
    {

        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;

        public StandardStudy()
        {
            InitializeComponent();

            this.checkDestructList1.spName = "StandardStudy";

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

     
        private void grdDelivery_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.checkDestructList1.Fill();
            this.grdDelivery.Refetch();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
            //for (int i = 0; i < grdDelivery.RowCount; i++)
            //{

            //    if (e.Row.Cells["DateOfTestForThePresence"].Value.ToString() != "")
            //    {

            //        if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
            //        {
            //            Janus.Windows.GridEX.GridEXFormatStyle rowcol = new GridEXFormatStyle();
            //            rowcol.BackColor = Color.Yellow;
            //            e.Row.RowStyle = rowcol;
            //        }
            //    }

              
            //}

            if (e.Row.Cells["DateOfTestForThePresence"].Value.ToString() != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            if (e.Row.Cells["Destruct"].Value.ToString() != "")
            {
                e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            }
        }

        private void DeliveryDayForManager_Load(object sender, EventArgs e)
        {
            this.checkDestructList1.Fill();
            this.grdDelivery.Refetch();
        }
    }
}
