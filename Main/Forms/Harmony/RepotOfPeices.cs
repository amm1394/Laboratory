using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class RepotOfPeices : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
   
        public RepotOfPeices()
        {
           
            InitializeComponent();
            this.deliveryDayForHarmonyList1.spName = "RepotOfPeices";
            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

       }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("کارهای تحویلی روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //switch (e.Column.Key)
            //{
            //    case "ContractNo":
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
            //        break;
            //    case "CompletedDate":
            //        RASF.General.Data.DeliveryDay ShowDesc = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            //        RASF.Main.Forms.Harmony.ShowDescDeliveryReport ShowDeliveryDateChange = new Harmony.ShowDescDeliveryReport(ShowDesc.ContractsCode);
            //        ShowDeliveryDateChange.Show();
            //        break;
           // }
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
