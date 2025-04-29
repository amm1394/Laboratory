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
    public partial class MissMatchCompanyNameRecieptAmount : RASF.General.Forms.Base.DockContentForm 
    {
        public MissMatchCompanyNameRecieptAmount()
        {
            InitializeComponent();
            this.theamountofdailyintakeList1.spName = "MissMatchCompanyNameRecieptAmount";
            this.ShowpnlExit = false;
        }

        private void MissMatchCompanyNameRecieptAmount_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", System.DateTime.Now));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", System.DateTime.Now));
            this.theamountofdailyintakeList1.Fill(Parameter);

            this.grdReport.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdReport.ExportToExcel("عدم تطابق نام شرکت ها");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", System.DateTime.Now));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", System.DateTime.Now));
            this.theamountofdailyintakeList1.Fill(Parameter);

            this.grdReport.Refetch();
        }
    }
}
