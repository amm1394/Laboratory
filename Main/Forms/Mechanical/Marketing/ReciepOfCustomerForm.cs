using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ReciepOfCustomerForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReciepOfCustomerForm()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void ReciepOfCustomerForm_Load(object sender, EventArgs e)
        {

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
            this.reciepOfCustomerList1.Fill(Parameter);
            this.grdReciept.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReciept.ExportToExcel("");
        }
    }
}
