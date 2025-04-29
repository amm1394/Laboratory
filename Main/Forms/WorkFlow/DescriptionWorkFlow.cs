using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{
    public partial class DescriptionWorkFlow : Form
    {
        private Guid PartTestMasterCode;
        private int rtype;
        private bool Taeed;
        public DescriptionWorkFlow(Guid parttestmastercode,int RType,bool taeed)
        {
            InitializeComponent();
            PartTestMasterCode = parttestmastercode;
            rtype = RType;
            Taeed = taeed;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if ((Taeed == false) && (string.IsNullOrWhiteSpace(txtDesc.Text) == true))
            {
                MessageBox.Show("توضیحات را وارد نمایید");
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", txtDesc.Text));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@PartsTestMasterCode", PartTestMasterCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ispershian", 0));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@PersianWorkFlowState", 0));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@IsEnglish", 0));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@EnglishWorkFlowState", 0));

                if (Taeed == true)
                {
                    if (rtype == 0)
                    {
                        Parameters[3].Value = 1;
                        Parameters[4].Value = 1;
                    }
                    else if (rtype == 1)
                    {
                        Parameters[5].Value = 1;
                        Parameters[6].Value = 1;
                    }
                }
                else
                {
                    if (rtype == 0)
                    {

                        Parameters[3].Value = 1;
                        Parameters[4].Value = -1;
                    }
                    else if (rtype == 1)
                    {
                        Parameters[5].Value = 1;
                        Parameters[6].Value = -1;
                    }

                }

                RASF.General.Lists.Base.BaseList<object>.FillScalar("WorkFlowDescription_Update");
                this.Close();
            }
        }
    }
}
