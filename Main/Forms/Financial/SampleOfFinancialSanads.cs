using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class SampleOfFinancialSanads : RASF.General.Forms.Base.DockContentForm
    {
        DateTime BillDate = DateTime.MinValue;
        public SampleOfFinancialSanads()
        {
            InitializeComponent();
        }

        private void pickDateFrom1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            pickDate2_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdSanad.ExportToExcel("نمونه اسناد حسابداری");
        }

        private void pickDate2_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
         
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.sampleOfFinancialSanadsList1.Fill(Parameters);
            this.grdSanad.Refetch();
        }
    }
}
