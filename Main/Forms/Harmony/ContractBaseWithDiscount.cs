using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ContractBaseWithDiscount : RASF.General.Forms.Base.DockContentForm
    {
        public ContractBaseWithDiscount()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void ContractBaseWithDiscount_Load(object sender, EventArgs e)
        {

        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.contractBaseWithDiscountList1.Fill(Parameter);

            grdContracts.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("قراردادهایی که شامل تخفیف می باشند");
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractBaseWithDiscount CurrentRow = (RASF.General.Data.ContractBaseWithDiscount)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }
}
