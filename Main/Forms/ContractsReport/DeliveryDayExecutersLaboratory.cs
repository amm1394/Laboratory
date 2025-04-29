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
    public partial class DeliveryDayExecutersLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From;
        private DateTime To;
       
        public DeliveryDayExecutersLaboratory()
        {
            InitializeComponent();
           // this.deliveryDayList1.spName = "DeliveryDayLaboratoryExecuters";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.deliveryDayList1.spName = "DeliveryDayLaboratoryExecuters";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("کارهای تحویلی روز");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new Laboratory.ViewCostPaperLaboratory(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayList1.Fill(Parameter);
            this.grdDelivery.Refetch();

            From = e.From;
            To = e.To;
           
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
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
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayList1.Fill(Parameter);
            this.grdDelivery.Refetch();
        }
    }
}
