using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class EarninigOfAgencyRecieption : RASF.General.Forms.Base.DockContentForm
    {
        public EarninigOfAgencyRecieption()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdAgency.ExportToExcel("کارکرد دفاتر براساس پذیرش");
        }

       
       private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.officesFinancialAgencyList1.Fill(Parameter);

            grdAgency.Refetch();
        }

     
        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

       
    }
}
