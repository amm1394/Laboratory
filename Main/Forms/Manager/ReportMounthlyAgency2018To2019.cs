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
    public partial class ReportMounthlyAgency2018To2019 : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthlyAgency2018To2019()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.reportMounthlyLaboratory2017To2018List1.spName = "ReportMounthlyCompanies_Agency2018To2019";
        }

        private void ReportMounthlyAgency2018To2019_Load(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdAgency.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.reportMounthlyLaboratory2017To2018List1.Fill();
            this.grdAgency.Refetch();
        }
    }
}
