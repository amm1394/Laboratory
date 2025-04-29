using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class ClearReportForm : RASF.General.Forms.Base.DockContentForm
    {
      

        public ClearReportForm()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.findContractNoList1.Fill(Parameter);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.clearReportList1.Fill(Parameter1);
            this.grdMaster.Refetch();
        }

        private void grdMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            if (this.grdMaster.SelectedItems.Count >0)
            {
                RASF.General.Data.AddReport CurrentRow = (RASF.General.Data.AddReport)this.grdMaster.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;

                this.clearReportList1.Update();

                FillGrid();
            }
          

         
        }
    }
}
