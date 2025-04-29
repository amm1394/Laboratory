using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Connector
{
    public partial class CompanyHasConnector : RASF.General.Forms.Base.DockContentForm
    {
        public CompanyHasConnector()
        {
            InitializeComponent();
            this.recieptionDayList1.spName = "CompanyHasConnector";
            this.ShowpnlExit = false;
        }

        private void CompanyHasConnector_Load(object sender, EventArgs e)
        {
            //this.recieptionDayList1.Fill();
            //this.grdConnector.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdConnector.ExportToExcel(""); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.recieptionDayList1.Fill();
            //this.grdConnector.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.recieptionDayList1.Fill(Parameter);
            this.grdConnector.Refetch();
        }
    }
}
