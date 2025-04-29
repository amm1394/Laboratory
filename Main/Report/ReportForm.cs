using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Report
{
    public partial class ReportForm : Form
    {
        public ReportForm(Stimulsoft.Report.StiReport report)
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
//            this.Report.Show(this);
        }

        private void Report_Printed(object sender, EventArgs e)
        {
            //this.Report.Dispose();
            //this.Close();
        }
    }
}
