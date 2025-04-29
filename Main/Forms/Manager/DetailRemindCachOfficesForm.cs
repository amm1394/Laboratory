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
    public partial class DetailRemindCachOfficesForm : RASF.General.Forms.Base.DockContentForm
    {
        private Guid Code;
        public DetailRemindCachOfficesForm(Guid agencycode)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.billsissuedList1.spName = "DetailRemindCachOffices";
            Code = agencycode;
        }

        private void DetailRemindCachOfficesForm_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("AgencyCode", Code));
            this.billsissuedList1.Fill(Parameter);
            this.grdReports.Refetch();
        }
    }
}
