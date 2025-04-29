using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class ReceiptFormForAgency : RASF.General.Forms.Base.DockContentForm
    {
        private Int64 Remind = 0;
        private List<RASF.General.Lists.DebtorCreditorCompaniesList> DebtorCreditorCompanies = new List<General.Lists.DebtorCreditorCompaniesList>();

        private List<RASF.General.Lists.ReceiptAmountMasterList> ReceiptAmountMasterList = new List<General.Lists.ReceiptAmountMasterList>();
        List<RASF.General.InterFaces.IRecieption> RecieptionControl = new List<General.InterFaces.IRecieption>();
        public ReceiptFormForAgency()
        {
            InitializeComponent();
            this.debtorCreditorContractBaseList1.spName = "DebtorCreditorContractBaseForAgency";
            this.receiptTypeList1.spName = "Receipt_TypeForAgency";

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.Cash());
            this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.Cheque());
            this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.MoneyOrder());
          //  this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.Tax_Amount());
          //  this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.RemindCreditor());
           // this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.WageOfAgency());
          //  this.RecieptionControl.Add(new RASF.Main.Controls.Reciept.Bimeh());
            


            this.debtorCreditorCompaniesList1.Fill();
            this.receiptTypeList1.Fill();
            this.cashList1.Fill();
           
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Company_Invoice", this.debtorCreditorCompaniesList1[0].CompaniesCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.debtorCreditorContractBaseList1.Fill(Parameters);

            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.debtorCreditorCompaniesList1[0].CompaniesCode));
            this.creditorRemindList1.Fill(Parameters1);

            General.Classes.Utility.CreateDropDow(drpPeyment, "Name", "ReceieptCode", receiptTypeList1);
            this.drpPeyment.SelectedIndex = 0;

            this.grdContracts.Refetch();
            this.grdCompanies.Refetch();

            chkPrint.Checked = true;
        }

        private void grdCompanies_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCompanies.CurrentRow != null) && (this.grdCompanies.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpCompany.Text = this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString();

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("Company_Invoice", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                this.debtorCreditorContractBaseList1.Fill(Parameters);

                List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameters1.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value));
                this.creditorRemindList1.Fill(Parameters1);

                this.grdContracts.Refetch();

                if (this.creditorRemindList1.Count() > 0)
                {
                    this.Remind = this.creditorRemindList1[0].Remind;
                }
                else
                {
                    this.Remind = 0;
                }

                ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).Remind = this.Remind;
                ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).Reset();
                this.chkPrint.Checked = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int Count = this.debtorCreditorContractBaseList1.Count(row => row.ReceiptAmount <= row.Remind && row.ReceiptAmount < 0);
            Int64 sum = this.debtorCreditorContractBaseList1.Sum(row => row.ReceiptAmount);
            if ((Count == 0) && ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).chekData(sum) == true)
            {
               Guid ReceiptAmountMasterCode = ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).UpdateData((Guid)this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value);
               Boolean InformalReceipt =(Boolean) this.grdCompanies.CurrentRow.Cells["InformalFactor"].Value;

                foreach (RASF.General.Data.DebtorCreditorContractBase row in debtorCreditorContractBaseList1)
                {
                    row.ReceiptMasterCode = ReceiptAmountMasterCode;
                    row.CashesCode = ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).CashCode;
                    row.HowtoPay = Convert.ToByte(drpPeyment.SelectedValue);
                    if (row.ReceiptAmount == 0)
                    {
                        row.RowState = General.Enums.RowState.Original;
                    }
                }
                this.debtorCreditorContractBaseList1.Update();

                this.debtorCreditorCompaniesList1.Fill();
                this.grdCompanies.Refetch();

                ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).Reset();

                if (chkPrint.Checked == true)
                {
                    ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).ShowReport(ReceiptAmountMasterCode, InformalReceipt);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد");
            }
        }

        private void drpPeyment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlContain.Controls.Clear();
            this.pnlContain.Controls.Add((UserControl)this.RecieptionControl[this.drpPeyment.SelectedIndex]);
            ((RASF.General.InterFaces.IRecieption)this.pnlContain.Controls[0]).Remind = this.Remind;
            this.pnlContain.Controls[0].Dock = DockStyle.Right;
        }
    }
}
