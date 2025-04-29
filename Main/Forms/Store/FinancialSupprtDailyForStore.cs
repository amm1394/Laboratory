using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class FinancialSupprtDailyForStore : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
      
        public FinancialSupprtDailyForStore()
        {
           
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.deliveryDayForHarmonyList1.spName = "FinancialSupprtDailyForStore";
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("کارهای تحویلی روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdDelivery.Refetch();
            From = e.From;
            To = e.To;
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
             From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.deliveryDayForHarmonyList1.Fill(Parameter);
                this.grdDelivery.Refetch();
                From = e.From;
                To = e.To;
            }
        }

        private void grdDelivery_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To",To));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdDelivery.Refetch();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
        }
        private void DeliveryDayForManager_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }
    }
}
