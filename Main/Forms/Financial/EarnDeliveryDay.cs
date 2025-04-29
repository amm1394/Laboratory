using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class EarnDeliveryDay : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public EarnDeliveryDay()
        {
            InitializeComponent();
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
           // FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.ShowpnlSave = false;
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.earnDeliveryDayList1.Fill(Parameter);
            grdDelivery.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
                this.earnDeliveryDayList1.Fill(Parameter);
                grdDelivery.Refetch();
            }
        }

        private void grdDelivery_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.EarnDeliveryDay CurrentRow = (RASF.General.Data.EarnDeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Financial.EarnDeliveryDayDetail EarnDeliveryDayDetail = new RASF.Main.Forms.Financial.EarnDeliveryDayDetail(CurrentRow.MiladiDate);
            EarnDeliveryDayDetail.Show();
        }

        private void EarnDeliveryDay_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }
    }
}
