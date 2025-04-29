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
    public partial class ReportOfCorrosion : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfCorrosion()
        {
           
            InitializeComponent();
                          
                        
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
            if (e.Row.Cells["Destruct"].Value.ToString() != "")
            {

                if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
                {
                    Janus.Windows.GridEX.GridEXFormatStyle rowcol = new GridEXFormatStyle();
                    rowcol.BackColor = Color.Red;
                    e.Row.RowStyle = rowcol;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportOfCorrosionList1.Fill();
            this.grdDelivery.Refetch();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
            for (int i = 0; i < grdDelivery.RowCount; i++)
            {

                if (e.Row.Cells["DateOfTestForThePresence"].Value.ToString() != "")
                {

                    if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
                    {
                        Janus.Windows.GridEX.GridEXFormatStyle rowcol = new GridEXFormatStyle();
                        rowcol.BackColor = Color.Yellow;
                        e.Row.RowStyle = rowcol;
                    }
                }

              
            }
        }

        private void DeliveryDayForManager_Load(object sender, EventArgs e)
        {
            this.reportOfCorrosionList1.Fill();
            this.grdDelivery.Refetch();
        }
    }
}
