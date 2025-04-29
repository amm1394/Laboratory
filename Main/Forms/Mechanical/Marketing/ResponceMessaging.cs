using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class ResponceMessaging : RASF.General.Forms.Base.DockContentForm
    {
        private Int64 CodeMaessaging;
        public ResponceMessaging(Int64 Code)
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            CodeMaessaging = Code;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (txtmessage.Text != "")
           {
               List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
               Parameter.Add(new System.Data.SqlClient.SqlParameter("@Code", CodeMaessaging));
               Parameter.Add(new System.Data.SqlClient.SqlParameter("@Message", txtmessage.Text));

               this.responceToMessagingMarketingList1.FillScalar(Parameter);
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
