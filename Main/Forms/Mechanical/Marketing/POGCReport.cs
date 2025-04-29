using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class POGCReport : RASF.General.Forms.Base.DockContentForm
    {
        public POGCReport()
        {
            InitializeComponent();
        }

     
        private void POGCReport_Load(object sender, EventArgs e)
        {
            this.reportOfPOGCList1.Fill();
            this.grdcompany.Refetch();

        }

        private void grdcompany_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdcompany.CurrentRow != null) && (this.grdcompany.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@Company_Invoice", this.grdcompany.CurrentRow.Cells["CompaniesCode"].Value));
                this.reportOfPOGCDetailList1.Fill(Parameter);

                this.grdTest.Refetch();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdTest.ExportToExcel(this.grdcompany.CurrentRow.Cells["CompanyName"].Value.ToString());
        }

      
      
    }
}
