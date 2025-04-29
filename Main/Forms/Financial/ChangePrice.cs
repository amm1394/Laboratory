using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ChangePrice : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        public ChangePrice()
        {
            InitializeComponent();
            this.ShowpnlUpdate = true;
        }

        private void ReissuesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.changePriceList1.Fill();
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = String.Format("قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value);
            }
            else
            {
                this.grpContracts.Text = "";
            }


            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {

                    this.ContractsCode = Current_Contract.ContractsCode;
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Current_Contract.ContractsCode));
                    this.finanicalAcceptTets1.Fill(Parameters);

                    this.grdBill.Refetch();
                }
                else
                {
                    this.finanicalAcceptTets1.Clear();
                //  this.grdBill.Refetch();
                    this.ContractsCode = Guid.Empty;
                    
                }
            }
            else
            {
                this.finanicalAcceptTets1.Clear();
                this.grdBill.Refetch();
                this.ContractsCode = Guid.Empty;
            }
        }

        private void grdBill_CurrentCellChanged(object sender, EventArgs e)
        {
            this.finanicalAcceptTets1.UpdateRow();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (ContractsCode != Guid.Empty)
                {
                    ((RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;

                    this.finanicalAcceptTets1.Update();
                    this.grdContracts.Refetch();

                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@Description", "تغییر مبلغ"));
                    RASF.General.Lists.Base.BaseList<Object>.FillScalar("DescForEditContractBase_Insert", Parameter);
                }
            }
            catch  
            {
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
