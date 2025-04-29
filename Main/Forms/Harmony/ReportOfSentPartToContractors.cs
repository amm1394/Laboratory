using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReportOfSentPartToContractors : RASF.General.Forms.Base.DockContentForm
    {
        public ReportOfSentPartToContractors()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;

         
        }
              
        private void RequestOfConstractors_Load(object sender, EventArgs e)
        {
            this.sentPartToContractorsReportList1.Fill();
            this.grdcontractors.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdcontractors.ExportToExcel("پیمانکاران");
        }

       
    }
}
