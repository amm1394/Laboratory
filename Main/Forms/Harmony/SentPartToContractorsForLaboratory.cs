using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Harmony
{
    public partial class SentPartToContractorsForLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        public SentPartToContractorsForLaboratory()
        {
            InitializeComponent();
           // this.ShowpnlSave = false;
            this.ShowpnlExit = false;
        }

        private void SentPartToContractorsForLaboratory_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@Userid", RASF.General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.viewSentPartToContractorsForLaboratoryList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@Userid", RASF.General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.viewSentPartToContractorsForLaboratoryList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdContracts.ExportToExcel("کارهای ارسالی به پیمانکاران");
        }
    }
}
