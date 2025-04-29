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
    public partial class NotDeliveryReportToCustomer : RASF.General.Forms.Base.DockContentForm
    {
        public NotDeliveryReportToCustomer()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
         //   this.ShowpnlUpdate = false;
        }

        private void NotDeliveryReportToCustomer_Load(object sender, EventArgs e)
        {
            this.notDeliveryReportToCustomerList1.Fill();
            grdReport.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReport.ExportToExcel("گزارشات تحویل داده نشده");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.notDeliveryReportToCustomerList1.Fill();
            this.grdReport.Refetch();
        }
    }
}
