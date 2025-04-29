using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class InvoiceForPrint : RASF.General.Forms.Base.DockContentForm
    {
        public InvoiceForPrint()
        {
            InitializeComponent();
            this.contractsReissuesList1.spName = "ContractsReissuesForPrint";
        }
        private Boolean InformalFactor;
        private Boolean grant;
        private Boolean servicetopic;

        private void InvoiceForPrint_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsReissuesList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;
            InformalFactor = Current_Contract.InformalFactor;
            
            if (this.InformalFactor == false)
            {
                if (Current_Contract.AcceptServiceTopic == false)
                {
                    Report2.Load(String.Format("{0}\\Report\\BillReissuesForPrint.mrt", Application.StartupPath));
                }
                else
                {
                    Report2.Load(String.Format("{0}\\Report\\BillReissuesServiceTopicForPrint.mrt", Application.StartupPath));                
                }
            }
            else
            {
                Report2.Load(String.Format("{0}\\Report\\BillsofsaleReport-InformalForPrint.mrt", Application.StartupPath));

            }

            if (Current_Contract.Grant == true)
            {
                Report2.Load(String.Format("{0}\\Report\\BillReissuesGrantforPrint.mrt", Application.StartupPath));

            }
            Report2["@Code"] = Current_Contract.ContractsCode;
            Report2["@FinancialYear"] = RASF.General.Classes.Global.FinancialYear;
            Report2.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsReissuesList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }
    }
}
