using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class FinanciacceptManager : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private string To;
        private Janus.Windows.GridEX.GridEXFormatStyle FourFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle NotInvoiceFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle FourtyPercentageOFCredit;
        public FinanciacceptManager()
        {
            InitializeComponent();
            this.pnlButton.Visible = true;
            this.ShowpnlSave = true;
            this.btnSave.Text = "ذخیره در اکسل";
           // this.btnSave.Size = (85,23);
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;

            this.FourFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourFormat.BackColor = Color.Red;
            this.FourFormat.ForeColor = Color.Black;

            this.NotInvoiceFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NotInvoiceFormat.BackColor = Color.Green;
            this.NotInvoiceFormat.ForeColor = Color.Black;

            this.FourtyPercentageOFCredit = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.FourtyPercentageOFCredit.BackColor = Color.DarkOrange;
            this.FourtyPercentageOFCredit.ForeColor = Color.Black;

            this.financiacceptList1.spName = "FinanciacceptManager";


        }
       // RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)grdContracts.SelectedItems[0].GetRow().DataRow;

        private void ReissuesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid() 
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            this.financiacceptList1.Fill(Parameters);
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
                    //this.grdBill.Refetch();
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

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_Base_Edit Current_Contract1 = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;
           
            if (ContractsCode != Guid.Empty )
            {

                ((RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                Current_Contract1.UserName = RASF.General.Classes.Global.CurrentUserName;
                this.financiacceptList1.Update();
                RefreshGrid();

               
            }
     
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           RefreshGrid();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdContracts.ExportToExcel("تایید مالی نشده");
        }

        private void grdContracts_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            string Contains1 = Convert.ToString(e.Row.Cells["CooperationName"].Value);
            if (Contains1.Contains("اعتباری"))
            {
                //e.Row.Cells["CompanyName"].FormatStyle = this.EtebariFormat;
                //e.Row.Cells["CooperationName"].FormatStyle = this.EtebariFormat;

                if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) > Convert.ToInt64(e.Row.Cells["Credit"].Value))
                {
                    if (Convert.ToInt64(e.Row.Cells["Notinvoice"].Value) <= Convert.ToInt64(e.Row.Cells["FourtyPercentageOFCredit"].Value))
                    {
                        e.Row.Cells["Notinvoice"].FormatStyle = this.FourtyPercentageOFCredit;
                    }
                    else
                    {
                        e.Row.Cells["Notinvoice"].FormatStyle = this.FourFormat;
                    }
                }
                else
                {
                    e.Row.Cells["Notinvoice"].FormatStyle = this.NotInvoiceFormat;
                }
            }
        }
    }
}
