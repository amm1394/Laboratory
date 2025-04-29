using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class InvoiceDaneshBonyan : RASF.General.Forms.Base.DockContentForm
    {
        public InvoiceDaneshBonyan()
        {
            InitializeComponent();
            this.reportOfDaneshBonyanList1.spName = "InvoiceNoDaneshBonyan";
            this.ShowpnlExit = false;
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.reportOfDaneshBonyanList1.Fill(Parameter);

            this.grdDaneshBonyan.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDaneshBonyan.ExportToExcel("گزارش دانش بنیان");
        }
    }
}
