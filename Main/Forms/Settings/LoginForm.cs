using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class LoginForm : RASF.General.Forms.Base.DockContentForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
//            if (MessageBox.Show("آیا مایل به بروزرسانی برنامه می باشید", "بروزرسانی", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
//            {
//                try
//                {
//                    var dir = new DirectoryInfo(@"C:\\Release");
//                    if (dir.Exists)
//                    {
//                        dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
//                        dir.Delete(true);

//                        File.Copy(@"\\share-pc\Share\Release", @"\\C", true);
//                    }
//                    else
//                    {

//                        File.Copy(@"\\share-pc\Share\Release", @"\\C", true);
//                    }


                    txtUserName.Focus();
//#if DEBUG
                    //txtPassword.Text = "Ma123456";
//#endif
                    txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1];
            //txtUserName.Enabled = true;

            //txtUserName.Text = "knabavi";
            //                }
            //                catch (IOException ex)
            //                {
            //                    MessageBox.Show(ex.Message);
            //                }
            //            }
            //            else
            //            {

            //                txtUserName.Focus();
            //#if DEBUG
            //txtPassword.Text = "sp@123456";
            //#endif
            //                txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1];
            //            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@userName", txtUserName.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@Password", txtPassword.Text));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@str", System.Environment.MachineName));
            this.validateCredentialsList1.Fill(Parameter);
          
            if (validateCredentialsList1.list[0].UserId != null)
            {

                IsAllowClosed = false;
                RASF.General.Classes.Global.CurrentUserName = validateCredentialsList1[0].FullName;
                RASF.General.Classes.Global.CurrentUserCode = validateCredentialsList1[0].UserId;
                RASF.General.Classes.Global.LastUpdate = DateTime.Now;
                RASF.General.Classes.Global.SleepInterval = 1000;


                using (RASF.General.AD.ADHelper helper = new RASF.General.AD.ADHelper())
                {
                    RASF.General.Classes.Global.LaboratoryList = helper.GetGroupsByUserID(RASF.General.Classes.Global.CurrentUserCode);
                }

                RASF.General.Classes.Global.FinancialYear = Convert.ToInt32(RASF.General.Lists.BasketList.FillScalar("CurrentYear_Select"));

                this.Close();
            }
            else
            {
                base.IsAllowClosed = true;
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
