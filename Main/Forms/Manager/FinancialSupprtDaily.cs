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
    public partial class FinancialSupprtDaily : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;

        public FinancialSupprtDaily()
        {
           
            InitializeComponent();
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TestFormat.BackColor = Color.Yellow;
            this.TestFormat.ForeColor = Color.Black;

            this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.DestructFormat.BackColor = Color.Red;
            this.DestructFormat.ForeColor = Color.Black;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
                        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("تایید مالی شده های روز");
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
            this.financialSupprtDailyList1.Fill(Parameter);
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
                this.financialSupprtDailyList1.Fill(Parameter);
                this.grdDelivery.Refetch();
                From = e.From;
                To = e.To;
            }
        }

        private void grdDelivery_LoadingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            //if (e.Row.Cells["Destruct"].Value.ToString() != "")
            //{

            //    if (e.Row.RowType == Janus.Windows.GridEX.RowType.Record)
            //    {
            //        Janus.Windows.GridEX.GridEXFormatStyle rowcol = new GridEXFormatStyle();
            //        rowcol.BackColor = Color.Red;
            //        e.Row.RowStyle = rowcol;
            //    }
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To",To));
            this.financialSupprtDailyList1.Fill(Parameter);
            this.grdDelivery.Refetch();
        }

        private void grdDelivery_FormattingRow(object sender, RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            {
                e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            }

            if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            {
                e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            }

            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0 && Convert.ToInt16(e.Row.Cells["HaghHogh"].Value) != 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
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
        }

        private void DeliveryDayForManager_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }
    }
}
