using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class EarninigOfAgency : RASF.General.Forms.Base.DockContentForm
    {
        public EarninigOfAgency()
        {
            InitializeComponent();
            this.billsissuedList1.spName = "RemindCachOffices";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelivery.ExportToExcel("کارکرد دفاتر براساس صورت حساب");
        }

       
       private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.earninigOfAgencyList1.Fill(Parameter);

            grdDelivery.Refetch();
        }

     
        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void EarninigOfAgency_Load(object sender, EventArgs e)
        {
            this.billsissuedList1.Fill();
            this.grdReport.Refetch();
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.Main.Forms.Manager.DetailRemindCachOfficesForm DetailRemindCachOfficesForm = new RASF.Main.Forms.Manager.DetailRemindCachOfficesForm((Guid)this.grdReport.CurrentRow.Cells["AgencyCode"].Value);
            DetailRemindCachOfficesForm.Show();

        }

       
    }
}
