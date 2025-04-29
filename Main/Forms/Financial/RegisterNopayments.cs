using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class RegisterNopayments : RASF.General.Forms.Base.DockContentForm
    {
        public RegisterNopayments()
        {
            InitializeComponent();
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();

           ; //this.cashOrderStatusList1[0].Id;

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
            this.registerNopaymentsList1.Fill();
            this.grdIsHold.Refetch();

            this.cashOrderStatusList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdIsHold.RootTable.Columns["StatusOrder"], this.cashOrderStatusList1, "Id", "StatusOrder");
            this.grdIsHold.RootTable.Columns["StatusOrder"].DefaultValue = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdIsHold.SelectedItems.Count > 0)
            {
                RASF.General.Data.RegisterNopayments Current_Contract = (RASF.General.Data.RegisterNopayments)this.grdIsHold.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null))
                {
                   // Current_Contract.RowState = General.Enums.RowState.Added;
                  //  Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.registerNopaymentsList1.Update();

                    FillGrid();

                   
                }
            }
        }


    }
}
