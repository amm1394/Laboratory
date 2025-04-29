using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class DeliveryDayForTaeenGrade : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;

        private DateTime From, To;
        public DeliveryDayForTaeenGrade()
        {
            InitializeComponent();
            this.deliveryDayForHarmonyList1.spName = "DeliveryDayForTaeenGrade";
            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            //Janus.Windows.GridEX.GridEXFormatCondition AGradePartTest;
            //AGradePartTest = new Janus.Windows.GridEX.GridEXFormatCondition(grdDelivery.RootTable.Columns["StrAcceptedTaeenGrade"], Janus.Windows.GridEX.ConditionOperator.Equal, "رد");
            //AGradePartTest.FormatStyle.BackColor = Color.Red;
            //AGradePartTest.FormatStyle.ForeColor = Color.Black;
            //grdDelivery.RootTable.FormatConditions.Add(AGradePartTest);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("قراردادهای رد شده");
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
            }

        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
          


       
        }

        private void grdDelivery_LoadingRow(object sender, RowLoadEventArgs e)
        {
           
        }
    }
}
