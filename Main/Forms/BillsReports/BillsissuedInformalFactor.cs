using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class BillsissuedInformalFactor : RASF.General.Forms.Base.DockContentForm
    {
        public BillsissuedInformalFactor()
        {
            InitializeComponent();
           // this.ShowpnlButton = false;
            this.billsissuedList1.spName = "BillsissuedInformalFact";
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.billsissuedList1.Fill(Parameter);
            grdBills.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdBills.ExportToExcel("صورت حساب های صادر شده غیر رسمی");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // FillGrid(e);
        }
    }
}
