using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Message
{
    public partial class ShowRecieveMessage : RASF.General.Forms.Base.DockContentForm
    {
        public ShowRecieveMessage()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.showSendMessageList1.spName = "ShowRecieveMessage";
            
        }

        private void showNotFinancialForOffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@From",e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@CurrentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.showSendMessageList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }
    }
}
