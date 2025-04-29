using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ViewReceiptDemandForm : RASF.General.Forms.Base.DockContentForm
    {
        private Guid CompaniesCode;
        public ViewReceiptDemandForm(Guid CompaniesCode)
        {
            InitializeComponent();
            this.CompaniesCode = CompaniesCode;
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            this.pnlPrint.Visible = false;
        }

  
        private void CompanyWorkFlow_Load(object sender, EventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", CompaniesCode));
            this.viewReceiptDemandList1.Fill(Parameters);
            this.grdWorkFlow.Refetch();
        }

       private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", CompaniesCode));
            this.viewReceiptDemandList1.Fill(Parameters);
            this.grdWorkFlow.Refetch();
      }

    
    }
}
