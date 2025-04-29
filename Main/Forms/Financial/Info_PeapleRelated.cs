using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class Info_PeapleRelated : RASF.General.Forms.Base.DockContentForm
    {
        private Guid CompaniesCode;
        public Info_PeapleRelated(Guid CompaniesCode)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.CompaniesCode = CompaniesCode;
            this.viewReceiptDemandList1.spName = "Info_PeapleRelated";
        }

        private void Info_PeapleRelated_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", CompaniesCode));
            this.viewReceiptDemandList1.Fill(Parameters);

            if (this.viewReceiptDemandList1.list.Count > 0)
            {
                this.textBox1.Text = this.viewReceiptDemandList1.list[0].Description;
                this.groupBox1.Text = this.viewReceiptDemandList1.list[0].CompanyName;
            }
          
        }
    }
}
