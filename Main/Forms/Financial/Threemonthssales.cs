using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class Threemonthssales : RASF.General.Forms.Base.DockContentForm
    {
        public Threemonthssales()
        {
            InitializeComponent();
        }

        private void pickDate1_DateSelected(RASF.General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.threemonthssalesList1.Fill(Parameter);

            grdReport.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
            grdReport.ExportToExcel("کزارش سه ماهه فروش");
        
        }

     
    }
}
