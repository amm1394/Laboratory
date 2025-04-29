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
    public partial class DilatoryForm : RASF.General.Forms.Base.DockContentForm
    {
        public DilatoryForm()
        {
            InitializeComponent();
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grddilatory.CurrentRow != null) && (this.grddilatory.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grddilatory.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }
           
        }

        private void FillGrid()
        {
           // List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
           // Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.dilatoryList1.Fill();
            this.grddilatory.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grddilatory.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_IsHold Current_Contract = (RASF.General.Data.Contracts_IsHold)this.grddilatory.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.dilatoryList1.Update();

                    FillGrid();

                    this.txtReason.Text = String.Empty;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.dilatoryList1.Fill();
            this.grddilatory.Refetch();
        }


    }
}
