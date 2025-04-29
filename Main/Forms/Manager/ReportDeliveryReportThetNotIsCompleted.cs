using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ReportDeliveryReportThetNotIsCompleted : RASF.General.Forms.Base.DockContentForm
    {
        public ReportDeliveryReportThetNotIsCompleted()
        {
            InitializeComponent();
            this.deliveryDayForHarmonyList1.spName = "ReportDeliveryReportThetNotIsCompleted";
            this.ShowpnlButton = false;
        }

        private void ReportDeliveryReportThetNotIsCompleted_Load(object sender, EventArgs e)
        {
           
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.deliveryDayForHarmonyList1.Fill(Parameter);
            this.grdDelivery.Refetch();
        }
    }
}
