using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.SEM
{
    public partial class SEMContract : RASF.General.Forms.Base.DockContentForm
    {
        public SEMContract()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void SEMContract_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@ContractYear",RASF.General.Classes.Global.FinancialYear ));
            this.semContractList1.Fill(Parameter1);
            this.grdSem.Refetch();
        }

        private void grdSem_DoubleClick(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
