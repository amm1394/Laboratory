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
    public partial class SendEmailSpecialCompany : RASF.General.Forms.Base.DockContentForm
    {
        private Int16 ContractNo;
        public Boolean TestPresence;
        public SendEmailSpecialCompany()
        {
            InitializeComponent();
            this.findContractNoList1.spName = "FindContractNoSpecialCompany";
            this.partsMasterSendEmailList1.spName = "PartsMasterSendEmailSpecialCompany";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                this.findContractNoList1.Fill(Parameter);

                if (this.findContractNoList1.Count() > 0)
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.partsMasterSendEmailList1.Fill(Parameter1);
                    this.grdMaster.Refetch();

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", findContractNoList1[0].ContractsCode));
                    this.sendingReportEmailList1.Fill(Parameter3);
                    this.grdReport.Refetch();


                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.txtEmail.Text = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                    ContractNo = Convert.ToInt16(this.txtSearch.Text);
                }
                else
                {
                    MessageBox.Show("شماره قرارداد اشتباه است");
                }
               
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Classes.SendEmail sendEmail = new RASF.General.Classes.SendEmail();
            sendEmail.MakeEmail(this.partsMasterSendEmailList1.Where(row => row.Checked == true).ToList(), this.txtEmail.Text, this.ContractNo );

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", findContractNoList1[0].ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@EmailAdd", this.txtEmail.Text));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("SendingReportEmail_Insert", Parameter);
        }
    }
}