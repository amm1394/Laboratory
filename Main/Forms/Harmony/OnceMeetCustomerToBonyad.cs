using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class OnceMeetCustomerToBonyad : RASF.General.Forms.Base.DockContentForm
    {
        public OnceMeetCustomerToBonyad()
        {
            InitializeComponent();
          //  FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

      

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.onceMeetOfBonyadList1.Fill(Parameter);
            this.grdCustomer.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdCustomer.ExportToExcel("شزکت هایی که یک بار به بنیاد مراجعه کرده اند");

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.onceMeetOfBonyadList1.Fill(Parameter);
            this.grdCustomer.Refetch();

        }
    }
}
