using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class ActivePartForEnter : RASF.General.Forms.Base.DockContentForm
    {
        public ActivePartForEnter()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();

        }
        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.findContractNoList1.Fill(Parameter);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", findContractNoList1[0].ContractsCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.activePartForEnterList1.Fill(Parameter1);
            this.grdactive.Refetch();

            this.textBox1.Text = activePartForEnterList1[0].Description;
        }

        private void grdactive_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.PartsMasterPrintReport Currentrow = (RASF.General.Data.PartsMasterPrintReport)this.grdactive.CurrentRow.DataRow;
            Currentrow.RowState = General.Enums.RowState.Updated;

            this.activePartForEnterList1.Update();

            FillGrid();
            
        }
    }
}
