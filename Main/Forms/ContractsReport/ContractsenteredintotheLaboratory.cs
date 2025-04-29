using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.ContractsReport
{
    public partial class ContractsenteredintotheLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        public ContractsenteredintotheLaboratory()
        {
            InitializeComponent();
        }

        private void ContractsenteredintotheLaboratory_Load(object sender, EventArgs e)
        {
            this.contractsenteredintotheLaboratoryList1.Fill();

            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("قراردادهایی که وارد آزمایشگاه شده اند");
        } 

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsenteredintotheLaboratory CurrentRow = (RASF.General.Data.ContractsenteredintotheLaboratory)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
