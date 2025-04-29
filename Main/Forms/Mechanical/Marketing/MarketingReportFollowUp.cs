using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class MarketingReportFollowUp : RASF.General.Forms.Base.DockContentForm
    {
        private int sabtshode;
        private int erjanashode;
        public MarketingReportFollowUp()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void MarketingReportFollowUp_Load(object sender, EventArgs e)
        {
            this.marketingReportFollowUpList1.Fill();
            this.grdReports.Refetch();

            sabtshode = Convert.ToInt32(RASF.General.Lists.Base.BaseList<Object>.FillScalar("sabtshode_Select"));
            labSabt.Text = sabtshode.ToString();

            erjanashode = Convert.ToInt32(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ErjaNashode_Select"));
            laberjanashode.Text = erjanashode.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.marketingReportFollowUpList1.Fill();
            this.grdReports.Refetch();

            sabtshode = Convert.ToInt32(RASF.General.Lists.Base.BaseList<Object>.FillScalar("sabtshode_Select"));
            labSabt.Text = sabtshode.ToString();

            erjanashode = Convert.ToInt32(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ErjaNashode_Select"));
            laberjanashode.Text = erjanashode.ToString();
        }
    }
}
