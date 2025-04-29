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
    public partial class BillsOfSales : RASF.Main.Forms.Reception.EditContract
    {
        public BillsOfSales()
        {
            InitializeComponent();
        }

        protected override void grdEditContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Guid ContractCode = (Guid)(this.grdEditContract.CurrentRow.Cells["ContractsCode"].Value);

            RASF.General.Lists.ReportParameters ReportParameters = new General.Lists.ReportParameters();
            ReportParameters.ReportName = String.Format("{0}\\Report\\BillsofsaleReport.mrt", Application.StartupPath);
            ReportParameters.Add(new General.Data.ReportParameter("@Code", ContractCode));
            ReportParameters.Add(new General.Data.ReportParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));


            Report2.Load(String.Format("{0}\\Report\\BillsofsaleReport.mrt", Application.StartupPath));
            Report2["@Code"] = ContractCode;
            Report2["@FinancialYear"] = RASF.General.Classes.Global.FinancialYear;
            Report2.Show();

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsBaseEditList1.Fill(Parameters);
            this.grdEditContract.Refetch();
            
        }

        private void Report2_Printed(object sender, EventArgs e)
        {
        }
    }
}

