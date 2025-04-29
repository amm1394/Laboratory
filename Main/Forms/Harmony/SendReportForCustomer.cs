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
    public partial class SendReportForCustomer : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public SendReportForCustomer()
        {
            InitializeComponent();
        }

        private void SendReportForCustomer_Load(object sender, EventArgs e)
        {
          
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.sendReportForCustomerList1.Fill(Parameter);
            this.grdSendReports.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.deliveryOfReportsToTheCustomerList1.Fill(Parameter2);
            this.grddelivery.Refetch();

            this.from = e.From;
            this.to = e.To;
        }

        private void grdSendReports_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_Base_Edit Current_Contract1 = (RASF.General.Data.Contracts_Base_Edit)this.grdSendReports.SelectedItems[0].GetRow().DataRow;

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", Current_Contract1.ContractsCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@SendType", Current_Contract1.SendType));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
            RASF.General.Lists.BanksList.FillScalar("SendReportForCustomer_Insert", Parameters);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("From", this.from));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("To", this.to));
            this.sendReportForCustomerList1.Fill(Parameter1);
            this.grdSendReports.Refetch();
        }
    }
}
