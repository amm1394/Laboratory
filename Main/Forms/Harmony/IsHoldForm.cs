using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class IsHoldForm : RASF.General.Forms.Base.DockContentForm
    {
        public IsHoldForm()
        {
            InitializeComponent();
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdIsHold.CurrentRow != null) && (this.grdIsHold.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdIsHold.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contracts_IsHoldList1.Fill(Parameters);
            this.grdIsHold.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdIsHold.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_IsHold Current_Contract = (RASF.General.Data.Contracts_IsHold)this.grdIsHold.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.contracts_IsHoldList1.Update();

                    FillGrid();

                    this.txtReason.Text = String.Empty;
                }
            }
        }


    }
}
