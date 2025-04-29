using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class ReportOfInsurence : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public ReportOfInsurence()
        {
            InitializeComponent();
           // this.ShowpnlButton = false;
            this.billsissuedList1.spName = "ReportOfInsurence";

            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdBills.ExportToExcel("گزارش بیمه");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.billsissuedList1.Fill(Parameter);
            this.grdBills.Refetch();
        }

        private void ReportOfGrant_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected_1(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected_1(General.Events.ReturnSelectedDatesEventArgs e)
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
                this.billsissuedList1.Fill(Parameter);
                this.grdBills.Refetch();
                From = e.From;
                To = e.To;
            }
        }
    }
}
