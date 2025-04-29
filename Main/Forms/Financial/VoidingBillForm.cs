using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class VoidingBillForm : RASF.General.Forms.Base.DockContentForm
    {
        public VoidingBillForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdBill.SelectedItems.Count > 0)
            {
                RASF.General.Data.MasterBillVoid Current_Contract = (RASF.General.Data.MasterBillVoid)this.grdBill.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
                    this.masterBillVoidList1.Update();

                    FillGrid();

                    this.txtReason.Text = String.Empty;
                }
            }
        }

        private void VoidingBillForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.masterBillVoidList1.Fill(Parameters);
            this.grdBill.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
