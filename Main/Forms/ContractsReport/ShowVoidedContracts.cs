using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ShowVoidedContracts : RASF.General.Forms.Base.DockContentForm
    {
        public ShowVoidedContracts()
        {
            InitializeComponent();
        }

        private void ShowVoidedContracts_Load(object sender, EventArgs e)
        {
            
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.voidedContractsList1.Fill(e.From, e.To);

            this.grdContracts.Refetch();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.VoidedContracts CurrentRow = (RASF.General.Data.VoidedContracts)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
