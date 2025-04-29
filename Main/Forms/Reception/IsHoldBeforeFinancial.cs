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
    public partial class IsHoldBeforeFinancial : RASF.General.Forms.Base.DockContentForm
    {
        public IsHoldBeforeFinancial()
        {
            InitializeComponent();
            this.contracts_IsHoldList1.spName = "Contracts_IsHoldBeforFinancial";
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
                this.drpOffices.SelectedIndex =-1;
            }
            else
            {
                this.grpGrid.Text = "";
                this.drpOffices.SelectedIndex = -1;
            }
           
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contracts_IsHoldList1.Fill(Parameters);
            this.grdIsHold.Refetch();

            this.holdedBeforeFinancialList1.Fill();

            General.Classes.Utility.CreateDropDow(drpOffices, "Desc", "HoldedCode", holdedBeforeFinancialList1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdIsHold.SelectedItems.Count > 0)
             {
                RASF.General.Data.Contracts_IsHold Current_Contract = (RASF.General.Data.Contracts_IsHold)this.grdIsHold.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && ((int)(Current_Contract.HoldedCode) !=-1))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    Current_Contract.HoldedCode =(int) drpOffices.SelectedValue;
                    this.contracts_IsHoldList1.Update();

                    FillGrid();

                    this.drpOffices.SelectedIndex =-1;
                }
            }
        }


    }
}
