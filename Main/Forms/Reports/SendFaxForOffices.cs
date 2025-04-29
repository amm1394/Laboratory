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
    public partial class SendFaxForOffices : RASF.General.Forms.Base.DockContentForm
    {
        private Int16 ContractNo;

        public SendFaxForOffices()
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

                    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoForOfficesList1[0].ContractsCode));
                    this.txtEmail.Text = RASF.General.Lists.SendEmailList.FillScalar("SendFax_Select", Parameter2).ToString();

                    ContractNo = Convert.ToInt16(this.txtSearch.Text);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("این قرارداد متعلق به دفتر دیگری می باشد");
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Classes.SendFax SendFax = new RASF.General.Classes.SendFax();
            SendFax.MakeEmail(this.partsMasterSendEmailList1.Where(row => row.Checked == true).ToList(), this.txtEmail.Text, this.ContractNo);
        }
    }
}