using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class InsertPostCode : RASF.General.Forms.Base.DockContentForm
    {
        Guid CompanyCode;
        public InsertPostCode(Guid CompaniesCode)
        {
            InitializeComponent();
            this.pnlExit.Visible = false;
            this.pnlUpdate.Visible = false;
            CompanyCode = CompaniesCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox1.Text != "0" && textBox1.Text != "0000000000" && textBox1.Text != "")
            {
                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", CompanyCode));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("@PostCode", textBox1.Text));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("PostCode_Insert", Parameter2);
            }
            //else
            //{
            //    MessageBox.Show("");
            //}
        }
    }
}
