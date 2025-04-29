using Stimulsoft.Report.Dictionary;
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
    public partial class Print_Test_Form : RASF.General.Forms.Base.DockContentForm
    {
        public Print_Test_Form() 
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

       private void Print_Test_Form_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.print_TestList1.Fill(Parameters);

            this.grdEditContract.Refetch();


        }

        private void grdEditContract_ColumnButtonClick_1(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Guid ContractCode = (Guid)(this.grdEditContract.CurrentRow.Cells["ContractsCode"].Value);

            Report2.Load(String.Format("{0}\\Report\\Report2.mrt", Application.StartupPath));
            Report2["@Code"] = ContractCode;
            Report2.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.print_TestList1.Fill(Parameters);

            this.grdEditContract.Refetch();

        }
    }
}
