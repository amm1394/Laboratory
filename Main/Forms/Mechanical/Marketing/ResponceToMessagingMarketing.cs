using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{

    public partial class ResponceToMessagingMarketing : RASF.General.Forms.Base.DockContentForm
    {
        private Int64 CodeMarketing;
        public ResponceToMessagingMarketing()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void ResponceToMessagingMarketing_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.responceToMessagingMarketingList1.Fill(Parameters);
            this.grdMessage.Refetch();
        }

        private void grdMessage_SelectionChanged(object sender, EventArgs e)
        {
            txtdesc.Text = (string)this.grdMessage.CurrentRow.Cells["Description"].Value;
            txtSender.Text = (string)this.grdMessage.CurrentRow.Cells["MessageSender"].Value;
            CodeMarketing = (Int64)this.grdMessage.CurrentRow.Cells["Code"].Value; 
            
           
        }

        private void grdMessage_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.Main.Forms.Marketing.ResponceMessaging ResponceMessaging = new RASF.Main.Forms.Marketing.ResponceMessaging(CodeMarketing);
            ResponceMessaging.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.responceToMessagingMarketingList1.Fill(Parameters);
            this.grdMessage.Refetch();
        }
    }
}
