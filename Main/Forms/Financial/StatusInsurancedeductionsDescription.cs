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
    public partial class StatusInsurancedeductionsDescription : RASF.General.Forms.Base.DockContentForm
    {
        private Guid CompaniesCode;
        public StatusInsurancedeductionsDescription(Guid Code)
        {
            InitializeComponent();
            this.ShowpnlButton = false;

            this.CompaniesCode = Code;

            this.companiesCooperationTypeList1.spName = "StatusInsurancedeductions";
        }

        private void StatusInsurancedeductionsDescription_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.CompaniesCode));
            this.companiesCooperationTypeList1.Fill(Parameter);
            this.grdTypeDeductions.Refetch();
        }
    }
}
