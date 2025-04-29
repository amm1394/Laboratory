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
    public partial class ChequeNoPassedForm : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public ChequeNoPassedForm()
        {
            InitializeComponent();
          //  pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void ReceiveChequeForm_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.chequeNoPassedList1.Fill(Parameters);
            this.grdCheque.Refetch();
           
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.chequeNoPassedList1.Fill(Parameters);
            this.grdCheque.Refetch();
            DateTime From = e.From;
            DateTime To = e.To;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdCheque.SelectedItems.Count > 0)
            {
                RASF.General.Data.ReceiveCheque Current_Contract = (RASF.General.Data.ReceiveCheque)this.grdCheque.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Updated;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    this.chequeNoPassedList1.Update();

                    this.txtReason.Text = String.Empty;
                }
            }

            this.chequeNoPassedList1.Update();

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.chequeNoPassedList1.Fill(Parameters);
            this.grdCheque.Refetch();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.chequeNoPassedList1.Fill(Parameters);
            this.grdCheque.Refetch();
        }
    }
}
