using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class BillsOfSeeingInformal : RASF.General.Forms.Base.DockContentForm
    {
        public BillsOfSeeingInformal()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.billsissuedList1.spName = "BillsissuedInformalFact";
        }

       

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.billsissuedList1.Fill(Parameter);

            this.grdBills.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdBills.ExportToExcel("صورت حساب های صادر شده");
        }

        private void grdBills_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            SendSMS.Classes.BillsInformal Bill = new SendSMS.Classes.BillsInformal();
            Bill.ContractNo = (int)this.grdBills.CurrentRow.Cells["ContractNo"].Value;
            Bill.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            Bill.MakeBill();

            Main.Forms.Reports.ViewReport ViewReport = new Main.Forms.Reports.ViewReport(Bill.MakeBill(), false);
            ViewReport.MdiParent = this.MdiParent;
            ViewReport.Show();
            
        }
    }
}
