using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReportOfIndicator : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfIndicator()
        {
            InitializeComponent();
            this.viewIndicatorList1.spName = "ReportOfIndicator";
        }

        private void ReportOfIndicator_Load(object sender, EventArgs e)
        {
            this.viewIndicatorList1.Fill();
            this.grdReport.Refetch();
        }
    }
}
