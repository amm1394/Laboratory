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
    public partial class DailyInvoice : RASF.General.Forms.Base.DockContentForm
    {
    
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
    
        public DailyInvoice()
        {
           
            InitializeComponent();
            this.deliveryDayForHarmonyList1.spName = "DailyInvoice";

            //this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.DestructFormat.BackColor = Color.Red;
            //this.DestructFormat.ForeColor = Color.Black;

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            GridFill(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("صورت حساب های صادر شده روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
         

            if (e.Row.Cells["DateOfTestForThePresence"].Value.ToString() != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            //if (e.Row.Cells["Destruct"].Value.ToString() != "")
            //{
            //    e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            //}
        }

        private void DeliveryDayForManager_Load(object sender, EventArgs e)
        {
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            GridFill(e);
        }

        private void GridFill(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdDelivery.Refetch();
        }

      
    }
}
