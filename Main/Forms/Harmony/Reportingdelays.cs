using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class Reportingdelays : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public Reportingdelays()
        {
            InitializeComponent();
           // this.ShowpnlButton = false;
            this.To = this.From = System.DateTime.Now;
        }

        private void Reportingdelays_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            this.reportingDelayList1.Fill(Parameters);

            this.grdDelay.Refetch();
        }

        private void grdDelay_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ReportingDelay CurrentRow = (RASF.General.Data.ReportingDelay)this.grdDelay.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdDelay.ExportToExcel("گزارش کارهای تاخیری");
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.reportingDelayList1.Fill(Parameters);

            this.grdDelay.Refetch();
        }

     
    }
}
