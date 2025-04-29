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
    public partial class CancelHoldedContract : RASF.General.Forms.Base.DockContentForm
    {
        public CancelHoldedContract()
        {
            InitializeComponent();

         //   this.cancel_Contracts_IsHoldList1.spName = "Cancel_Contracts_IsHolded";
            
        }

           
        private void btnSave_Click(object sender, EventArgs e)
        {
           txtExit.Text= RASF.General.Classes.Utility.CorrectFileName(txtExit.Text);
            if (txtExit.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("لطفا علت لغو را به طور کامل وارد نمایید");
            }
            else
            {

                if (this.grdContracts.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Cancel_Contracts_IsHold Current_Contract = (RASF.General.Data.Cancel_Contracts_IsHold)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                    if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                    {
                        Current_Contract.RowState = General.Enums.RowState.Updated;
                        Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                        this.cancel_Contracts_IsHoldedList1.Update();

                        FillContract();

                        this.txtExit.Text = String.Empty;
                    }
                }
            }
        }

        private void CancelToExit_Load(object sender, EventArgs e)
        {
            FillContract();
        }

        private void FillContract()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.cancel_Contracts_IsHoldedList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = "قرارداد" + " " + this.grdContracts.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpContracts.Text = "";
            }
        }

        private void txtExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')// && e.KeyChar == '*' && e.KeyChar == '@' && e.KeyChar == '#' && e.KeyChar == '.')
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
