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
    public partial class ChequeIsVoidedForm : RASF.General.Forms.Base.DockContentForm
    {
      
        public ChequeIsVoidedForm()
        {
            InitializeComponent();
            this.chequeNoPassedList1.spName = "ChequeIsVoided";

        }

        private void ReceiveChequeForm_Load(object sender, EventArgs e)
        {
            this.chequeNoPassedList1.Fill();
            this.grdCheque.Refetch();
           
        }



      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.chequeNoPassedList1.Fill();
            this.grdCheque.Refetch();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCheque.ExportToExcel("چک های باطل شده");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (this.grdCheque.SelectedItems.Count > 0)
            {
                RASF.General.Data.ReceiveCheque Current_Contract = (RASF.General.Data.ReceiveCheque)this.grdCheque.SelectedItems[0].GetRow().DataRow;
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ReceiptAmountMasterCode", Current_Contract.ReceiptAmountMasterCode));
                RASF.General.Lists.BanksList.FillScalar("VoidCheque_Update", Parameter);
            }
            this.chequeNoPassedList1.Fill();
            this.grdCheque.Refetch();
        }

        private void grdCheque_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdCheque.SelectedItems.Count > 0)
            {
                RASF.General.Data.ReceiveCheque Current_Contract = (RASF.General.Data.ReceiveCheque)this.grdCheque.SelectedItems[0].GetRow().DataRow;
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ReceiptAmountMasterCode", Current_Contract.ReceiptAmountMasterCode));
                RASF.General.Lists.BanksList.FillScalar("PassCheque_Update", Parameter);
            }
            this.chequeNoPassedList1.Fill();
            this.grdCheque.Refetch();
        }
    }
}
