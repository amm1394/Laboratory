using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ContractDontHaveInvoice : RASF.General.Forms.Base.DockContentForm
    {
        public ContractDontHaveInvoice()
        {
            InitializeComponent();
            this.deliveryDayList1.spName = "ContractDontHaveInvoice";
           // FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          //  grdDelivery.ExportToExcel("رد شده توسط مدیر علمی");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            //RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            //RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            //CostPaper.Show();
            ((RASF.General.Data.DeliveryDay)this.grdDelivery.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
            this.deliveryDayList1.Update();
            
            this.deliveryDayList1.Fill();
            this.grdDelivery.Refetch();
        }

     
        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
           this.deliveryDayList1.Fill();
            grdDelivery.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void ContractDontHaveInvoice_Load(object sender, EventArgs e)
        {
            this.deliveryDayList1.Fill();
            grdDelivery.Refetch();
        }
    }
}
