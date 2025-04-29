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
    public partial class RegisterLaboratoryExecuters : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From,To;
        public RegisterLaboratoryExecuters()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.deliveryDayList1.spName = "RegisterLaboratoryExecuters";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            if (Convert.ToString(CurrentRow.LaboratoryExecuters) != "00000000-0000-0000-0000-000000000000")
            {
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.deliveryDayList1.Update();

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.deliveryDayList1.Fill(Parameter);
                this.grdDelivery.Refetch();
            }
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
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.deliveryDayList1.Fill(Parameter);

            this.executersLaboratoryList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdDelivery.RootTable.Columns["LaboratoryExecuters"], this.executersLaboratoryList1, "UserId", "UserName");
            this.grdDelivery.RootTable.Columns["LaboratoryExecuters"].DefaultValue = this.executersLaboratoryList1[2].UserId;

            this.grdDelivery.Refetch();
            this.From = e.From;
            this.To = e.To;
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void grdDelivery_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
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

        private void RegisterLaboratoryExecuters_Load(object sender, EventArgs e)
        {
           
        }
    }
}
