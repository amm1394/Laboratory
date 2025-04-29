using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReportOfInvoiceOfContractors : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfInvoiceOfContractors()
        {
            InitializeComponent();
        }

        private void ReportOfInvoiceOfContractors_Load(object sender, EventArgs e)
        {
            this.reportOfInvoiceOfContractorsList1.Fill();
            this.grdReport.Refetch();
        }
    }
}
