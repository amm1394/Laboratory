using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class HoldedContractBeforeFinancialReports : RASF.General.Forms.Base.DockContentForm
    {
        public HoldedContractBeforeFinancialReports()
        {
            InitializeComponent();
            this.contracts_IsHoldList1.spName = "HoldedContractBeforeFinancialReports";
        }

        private void HoldedContractBeforeFinancialReports_Load(object sender, EventArgs e)
        {
            this.contracts_IsHoldList1.Fill();
            this.grdHolded.Refetch();
        }

        private void grdHolded_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_IsHold CurrentRow = (RASF.General.Data.Contracts_IsHold)this.grdHolded.SelectedItems[0].GetRow().DataRow;
            List<System.Data.SqlClient.SqlParameter> Param = new List<System.Data.SqlClient.SqlParameter>();
            Param.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", CurrentRow.ContractsCode));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("CancelHoldedContractBeforeFinancial_Update", Param);

            this.contracts_IsHoldList1.Fill();
            this.grdHolded.Refetch();
        }
    }
}
