using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.BillsReports
{
    public partial class ContractMatters : RASF.General.Forms.Base.DockContentForm
    {
        public ContractMatters()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.billsissuedList1.spName = "ContractsMatters";
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.billsissuedList1.Fill(Parameter);
            this.grdBills.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdBills.ExportToExcel("صورت حساب های صادر شده");
        }

        private void grdBills_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.grdBills.SelectedItems.Count > 0)
            {
                RASF.General.Data.Billsissued Current_Contract = (RASF.General.Data.Billsissued)this.grdBills.SelectedItems[0].GetRow().DataRow;
                ///   Current_Contract.RowState = General.Enums.RowState.Added;
                if ((Current_Contract != null) && ((txtDesc.Text != null || txtReferal.Text != null || TxtPhone.Text != null || txtPost.Text != null || txtRegion.Text != null)))
                {

                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@MasterBillCode", Current_Contract.MasterBillsCode));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", txtDesc.Text));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Referral", txtReferal.Text));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Phone", TxtPhone.Text));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Post", txtPost.Text));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("@Region", txtRegion.Text));

                    RASF.General.Lists.BanksList.FillScalar("MasterBillDescription_Insert", Parameters);

                    txtDesc.Text = "";
                    txtReferal.Text = "";
                    TxtPhone.Text = "";
                    txtPost.Text = "";
                    txtRegion.Text = "";
                }
            }
        }
    }
}
