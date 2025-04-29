using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class RecieptReduceWage : RASF.General.Forms.Base.DockContentForm
    {
        public RecieptReduceWage()
        {
            InitializeComponent();
           // this.ShowpnlButton = false;
            this.billsissuedList1.spName = "RecieptReduceWage";
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            foreach (RASF.General.Data.Billsissued rowUser in billsissuedList1)
            {
                if (rowUser.Checked = true)
                {

                    this.billsissuedList1.Update();
                }
            }

            this.billsissuedList1.Fill();
            this.grdBills.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          //  this.grdBills.ExportToExcel("گزارش کسر از کارمزد");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.billsissuedList1.Fill();
            this.grdBills.Refetch();
        }

        private void ReportOfGrant_Load(object sender, EventArgs e)
        {
            this.billsissuedList1.Fill();
            this.grdBills.Refetch();
        }
    }
}
