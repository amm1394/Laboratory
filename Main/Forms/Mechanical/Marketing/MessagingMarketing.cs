using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class MessagingMarketing : RASF.General.Forms.Base.DockContentForm
    {
        private Int64 CodeMaessaging;

        public MessagingMarketing(Int64 Code)
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            CodeMaessaging = Code;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            RASF.General.Data.MessagingMarketing Marketing = new General.Data.MessagingMarketing();
            if (txtmessage.Text != "")
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("MarketingActivityCode", CodeMaessaging));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("MessageSender", txtmessage.Text));


                this.messagingMarketingList1.FillScalar(Parameter);
                txtmessage.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("متن مربوطه را وارد نمایید.");
            }
        }

    }
}
