using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class OutPutExecutersManager : RASF.General.Forms.Base.DockContentForm
    {
        public OutPutExecutersManager()
        {
            this.ShowpnlButton = false;
            InitializeComponent();
        }

        private void grdoutput_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.outPutExecutersManagerList1.Fill(Parameters);
            this.grdoutput.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.outPutExecutersManagerKolList1.Fill(Parameters1);
            this.grdDetailOutput.Refetch();

          
        }

        private void OutPutExecuters_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdoutput.ExportToExcel("کارکرد پرسنل");
           
        }
    }
}
