using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class SendBills : RASF.General.Forms.Base.DockContentForm
    {
        public SendBills()
        {
            InitializeComponent();
            this.billsissuedList1.spName = "SendMasterBills";
            this.billsissuedList2.spName = "SendDetailBills";

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.billsissuedList1.Fill(Parameter);
            this.grdBills.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.billsissuedList2.Fill(Parameter2);
            this.grdDetail.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdBills.ExportToExcel("صورت حساب های صادر شده");
            this.grdDetail.ExportToExcel("جزئیات صورت حساب های صادر شده");

        }
    }
}
