using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class EditAgencyName : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode;
        public EditAgencyName(Guid contractid)
        {
            InitializeComponent();
            this.ShowpnlUpdate = false;
            this.ShowpnlExit = false;
            ContractsCode = contractid;
            
        }

        private void EditAgencyName_Load(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Fill();
            General.Classes.Utility.CreateDropDow(drpOffices, "AgencyName", "AgencyCode", companiesAgencyListList1);
          //  this.drpOffices.SelectedValue = "7A2EEE8F-AEBF-49F6-818E-BB2E2EDB5154";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@OfficesCode", this.drpOffices.SelectedValue));
            RASF.General.Lists.BanksList.FillScalar("EditAgencyNameContract_Update", Parameters);


            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@EditUser", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("EditedContractBase_Update", Parameter);
            
            this.Close();



        }
    }
}
