using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.DashboardCommon;
using DevExpress.XtraCharts;


namespace RASF.Main.Forms.Dash
{
    public partial class ReportMounthlyLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        public ReportMounthlyLaboratory()
        {
            InitializeComponent();
        }

        private void ReportMounthlyLaboratory_Load(object sender, EventArgs e)
        {
            //ChartLegendInsidePosition.TopRightVertical.Equals(true);
        }

        private void dashboardViewer1_DashboardLoaded(object sender, DevExpress.DashboardWin.DashboardLoadedEventArgs e)
        {
           // Legend legend = ChartControl1. 
                      
        }
    }
}
