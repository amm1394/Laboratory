using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class RecDuplicatePrint : RASF.General.Forms.Base.DockContentForm
    {
        public RecDuplicatePrint()
        {
            InitializeComponent();
        }

        private void RecDuplicatePrint_Load(object sender, EventArgs e)
        {
            FillGridDuplicate();

            FillGridRepeat();

            FillGridCopy();
        }

        private void FillGridCopy()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.copyPrintList1.Fill(Parameters);
            this.grdCopy.Refetch();
        }

        private void FillGridRepeat()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.repeatePrintList1.Fill(Parameters);
            this.grdReprint.Refetch();
        }

        private void FillGridDuplicate()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.recDuplicatePrintList1.Fill(Parameters);
            this.grdDuplicate.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdDuplicate.SelectedItems.Count > 0)
            {
                RASF.General.Data.RecDuplicatePrint Current_Contract = (RASF.General.Data.RecDuplicatePrint)this.grdDuplicate.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.RecDescription) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.RecUser = RASF.General.Classes.Global.CurrentUserName;
                    this.recDuplicatePrintList1.Update();

                    FillGridDuplicate();

                    this.txtDesc.Text = String.Empty;
                }
            }


            if (this.grdReprint.SelectedItems.Count > 0)
            {
                RASF.General.Data.RecDuplicatePrint Current_Contract = (RASF.General.Data.RecDuplicatePrint)this.grdReprint.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.RecDescription) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.RecUser = RASF.General.Classes.Global.CurrentUserName;
                    this.repeatePrintList1.Update();

                    FillGridRepeat();
                    this.txtReprint.Text = String.Empty;
                }
            }


            if (this.grdCopy.SelectedItems.Count > 0)
            {
                RASF.General.Data.RecDuplicatePrint Current_Contract = (RASF.General.Data.RecDuplicatePrint)this.grdCopy.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.RecDescription) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.RecUser = RASF.General.Classes.Global.CurrentUserName;
                    this.copyPrintList1.Update();

                    FillGridCopy();

                    this.txtCopy.Text = String.Empty;
                }
            }
        }
    }
}
