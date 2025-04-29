using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Connector
{
    public partial class NewCompany : RASF.General.Forms.Base.DockContentForm
    {
        public NewCompany()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.recieptionDayList1.spName = "NewCompany";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("شرکت های جدید");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DeliveryDay CurrentRow = (RASF.General.Data.DeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

       private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
           this.recieptionDayList1.Fill();
           this.grdDelivery.Refetch();
        }

        private void NewCompany_Load(object sender, EventArgs e)
        {
            this.recieptionDayList1.Fill();
            this.grdDelivery.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.recieptionDayList1.Fill();
            this.grdDelivery.Refetch();
        }

       
    }
}
