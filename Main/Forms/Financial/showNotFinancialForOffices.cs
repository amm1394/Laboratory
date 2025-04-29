using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class showNotFinancialForOffices : RASF.General.Forms.Base.DockContentForm
    {
        public showNotFinancialForOffices()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.financiacceptList1.spName = "showNotFinancialForOffices";
        }

        private void showNotFinancialForOffices_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.financiacceptList1.Fill(Parameters);
            this.grdContracts.Refetch();

        }
    }
}
