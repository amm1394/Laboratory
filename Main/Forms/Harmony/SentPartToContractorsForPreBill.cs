using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SentPartToContractorsForPreBill : RASF.General.Forms.Base.DockContentForm
    {
        public SentPartToContractorsForPreBill()
        {
            InitializeComponent();
        }

        private DateTime From, To;
        private void SentPartToContractorsForPreBill_Load(object sender, EventArgs e)
        {
            pickDate2_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", DateTime.Now));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", DateTime.Now));
            this.sentPartToContractorsForPreBillList1.Fill(Parameters1);
            this.grdbill.Refetch();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.SentPartToContractors SertPartToContractors in this.sentPartToContractorsForPreBillList1)
            {

                this.sentPartToContractorsForPreBillList1.Update();
               
            }
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.sentPartToContractorsForPreBillList1.Fill(Parameters1);
            this.grdbill.Refetch();
          
        }

        private void pickDate2_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            RefreshGrid(e);
        }

        private void RefreshGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To; 

            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.sentPartToContractorsForPreBillList1.Fill(Parameters1);
            this.grdbill.Refetch();
        }
    }
}
