using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class Settledcontracts : RASF.General.Forms.Base.DockContentForm
    {
        public Settledcontracts()
        {
            InitializeComponent();
           // this.ShowpnlButton = false; 
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.settledcontractsList1.Fill(Parameter);

            grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("قرارداد های تسویه شده");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Settledcontracts CurrentRow = (RASF.General.Data.Settledcontracts)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
