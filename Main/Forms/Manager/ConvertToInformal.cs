using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ConvertToInformal : RASF.General.Forms.Base.DockContentForm
    {
        public ConvertToInformal()
        {
            InitializeComponent();
            this.debtorCreditorCompaniesWorkFlowList1.spName = "ConvertToInformalCompany";
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void ConvertToInformal_Load(object sender, EventArgs e)
        {
            this.debtorCreditorCompaniesWorkFlowList1.Fill();
            this.grdCompanies.Refetch();
        }

        private void grdCompanies_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DebPayCompanies Current_Contract = (RASF.General.Data.DebPayCompanies)this.grdCompanies.SelectedItems[0].GetRow().DataRow;

            if ((Current_Contract != null))
            {
                Current_Contract.RowState = General.Enums.RowState.Updated;
                this.debtorCreditorCompaniesWorkFlowList1.Update();

                this.debtorCreditorCompaniesWorkFlowList1.Fill();
                this.grdCompanies.Refetch();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.debtorCreditorCompaniesWorkFlowList1.Fill();
            this.grdCompanies.Refetch();
        }
    }
}
