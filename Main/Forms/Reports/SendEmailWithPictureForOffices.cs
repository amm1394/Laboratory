using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace RASF.Main.Forms.Reports
{
    public partial class SendEmailWithPictureForOffices : RASF.General.Forms.Base.DockContentForm
    {
        private Int32 ContractNo;

        public SendEmailWithPictureForOffices()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
                this.findContractNoForOfficesList1.Fill(Parameter);

                if (findContractNoForOfficesList1.Count() > 0)
                {

                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.partsMasterSendEmailList1.Fill(Parameter1);
                    this.grdMaster.Refetch();

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.sendingReportEmailList1.Fill(Parameter3);
                    this.grdReport.Refetch();


                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.txtEmail.Text = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                    ContractNo = Convert.ToInt32(this.txtSearch.Text);

                    List<System.Data.SqlClient.SqlParameter> Parameter4 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter4.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.labDebContract.Text = Convert.ToString(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ContractRemind_Select", Parameter4));
                    if (Convert.ToInt64(this.labDebContract.Text) > 0)
                    {
                        this.labDebContract.BackColor = Color.Red;
                    }

                    List<System.Data.SqlClient.SqlParameter> Parameter5 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter5.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.labDebContracts.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ContractsRemindNotComplete_Select", Parameter5)).ToString("#,#");

                    List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.labCredit.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("CreditCompanies_Select", Parameter6)).ToString("#,#");

                    List<System.Data.SqlClient.SqlParameter> Parameter7 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter7.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.labCooperation.Text = Convert.ToString(RASF.General.Lists.Base.BaseList<Object>.FillScalar("CompaniesCooperation_Select", Parameter7));

                    List<System.Data.SqlClient.SqlParameter> Parameter8 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter8.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.labDebCustomer.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("RemindCompanies_Select", Parameter8)).ToString("#,#");

                    List<System.Data.SqlClient.SqlParameter> Parameter9 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter9.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.LabNotDeliveryReport.Text = Convert.ToString(RASF.General.Lists.Base.BaseList<Object>.FillScalar("NotDeliveryReport_Select", Parameter9));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("این قرارداد متعلق به دفتر دیگری می باشد");
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Classes.SendEmailRecieptionPic sendEmail = new RASF.General.Classes.SendEmailRecieptionPic();
            sendEmail.MakeEmail(this.partsMasterSendEmailList1.Where(row => row.Checked == true).ToList(), this.txtEmail.Text,this.ContractNo);

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@EmailAdd", this.txtEmail.Text));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("SendingReportEmail_Insert", Parameter);
        }

        private void splitContainer9_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}