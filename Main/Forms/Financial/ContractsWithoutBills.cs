using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ContractsWithoutBills : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public ContractsWithoutBills()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
           //his.ShowpnlButton = false;
        }

        private void fill()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            this.contractsWithoutBillsList1.Fill(Parameters);
            this.grdContracts.Refetch();

        }
        private void officesName1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.fill();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("قراردادهایی که صورت حساب ندارند");
        }

        private void grdOffices_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsWithoutBills CurrentRow = (RASF.General.Data.ContractsWithoutBills)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.MdiParent = this.MdiParent;
            CostPaper.Show();
        }
    }

}
    
