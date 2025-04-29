using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class EarnDeliveryDayDetail : RASF.General.Forms.Base.GeneralForm
    {
        private DateTime MiladiDateForm;
        public EarnDeliveryDayDetail(DateTime MiladiDate)
        {
            InitializeComponent();
            this.earnDeliveryDayList1.spName = "EarnDeliveryDayDetail";
            this.MiladiDateForm = MiladiDate; 
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", MiladiDateForm));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", MiladiDateForm));
            this.earnDeliveryDayList1.Fill(Parameter);
            grdDelivery.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
          //  FillGrid(e);
        }

        private void EarnDeliveryDayDetail_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", MiladiDateForm));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", MiladiDateForm));
            this.earnDeliveryDayList1.Fill(Parameter);
            grdDelivery.Refetch();
        }

        private void grdDelivery_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.EarnDeliveryDay CurrentRow = (RASF.General.Data.EarnDeliveryDay)this.grdDelivery.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper ViewCostPaper = new RASF.Main.Forms.Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            ViewCostPaper.Show();
        }
    }
}
