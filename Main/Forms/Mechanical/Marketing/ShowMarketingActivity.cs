using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ShowMarketingActivity : RASF.General.Forms.Base.DockContentForm
    {
        private Guid compniescode;
        public ShowMarketingActivity(Guid CompaniesCode)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            compniescode = CompaniesCode;
        }

        private void ShowMarketingActivity_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("CompaniesCode", compniescode));
            this.showMarketingActivityList1.Fill(Parameter);
            this.grdShow.Refetch();

        }

        private void grdShow_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
           
        }
    }
}
