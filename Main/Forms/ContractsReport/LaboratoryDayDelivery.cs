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
    public partial class LaboratoryDayDelivery : RASF.General.Forms.Base.DockContentForm
    {
        //private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        //private Janus.Windows.GridEX.GridEXFormatStyle DestructFormat;
        //private Janus.Windows.GridEX.GridEXFormatStyle TestFormat;

        private DateTime From, To;
        public LaboratoryDayDelivery()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
            this.deliveryDayForHarmonyList1.spName = "Laboratory_day_delivery";
            this.deliveryDayForHarmonyList2.spName = "Labs_day_delivery";
            this.deliveryDayForHarmonyList3.spName = "Delayed_Contracts_Report_Executer";

            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            //this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.NewCustomerFormat.BackColor = Color.Plum;
            //this.NewCustomerFormat.ForeColor = Color.Black;

            //this.DestructFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.DestructFormat.BackColor = Color.Red;
            //this.DestructFormat.ForeColor = Color.Black;

            //this.TestFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            //this.TestFormat.BackColor = Color.Yellow;
            //this.TestFormat.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                    
            this.grdLabDelivery.ExportToExcel("کارهای تحویلی روز آزمایشگاه");
            this.grdlab.ExportToExcel("کارهای تحویلی روز");
            this.grdDelay.ExportToExcel("کارهای تاخیری");
        }

        //private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        //{
        //    RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdLabDelivery.CurrentRow.DataRow;
        //    RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
        //    CostPaper.Show();
        //}

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdLabDelivery.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList2.Fill(Parameter2);
            this.grdlab.Refetch();
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
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.deliveryDayForHarmonyList1.Fill(Parameter);
                this.grdLabDelivery.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", To));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.deliveryDayForHarmonyList2.Fill(Parameter2);
                this.grdlab.Refetch();


            }

        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
          
            //if (Convert.ToString(e.Row.Cells["DateOfTestForThePresence"].Value) != "")
            //{
            //    e.Row.Cells["DateOfTestForThePresence"].FormatStyle = this.TestFormat;
            //}

            //if (Convert.ToString(e.Row.Cells["Destruct"].Value) != "")
            //{
            //    e.Row.Cells["Destruct"].FormatStyle = this.DestructFormat;
            //}

            //if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            //{
            //    e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            //}
        }

        private void grdDelivery_LoadingRow(object sender, RowLoadEventArgs e)
        {
           
        }

        private void LaboratoryDayDelivery_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdLabDelivery.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList2.Fill(Parameter2);
            this.grdlab.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList3.Fill(Parameter3);
            this.grdDelay.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdLabDelivery.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList2.Fill(Parameter2);
            this.grdlab.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayForHarmonyList3.Fill(Parameter3);
            this.grdDelay.Refetch();
        }

        private void grdLabDelivery_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdLabDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void grdlab_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdlab.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void grdDelay_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelay.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
