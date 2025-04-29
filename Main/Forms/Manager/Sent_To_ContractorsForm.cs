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
    public partial class Sent_To_ContractorsForm : RASF.General.Forms.Base.DockContentForm
    {
    
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;

        public Sent_To_ContractorsForm()
        {
           
            InitializeComponent();
            this.deliveryDayForHarmonyList1.spName = "Sent_To_Contractors";


            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            GridFill(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("ارسال به پیمانکار");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
         

          

         
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
           
            this.deliveryDayForHarmonyList1.Fill();
            this.grdDelivery.Refetch();
        }

      
    }
}
