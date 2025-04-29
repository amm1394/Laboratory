using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Reception
{
    public partial class IsCompletedForm : RASF.General.Forms.Base.DockContentForm
    {
        private string To;
        private Janus.Windows.GridEX.GridEXFormatStyle EnglishReport;
        public IsCompletedForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;


            this.EnglishReport = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.EnglishReport.BackColor = Color.Red;
            this.EnglishReport.ForeColor = Color.Black;
        }
       
        private void IsCompletedForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            this.isCompletedList1.Fill();
            this.grdIsCompleted.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.Contracts_Base_Edit Contracts_Base_Edit in this.isCompletedList1)
            {
                if (Contracts_Base_Edit.IsCompleted == true)
                {
                    Contracts_Base_Edit.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.isCompletedList1.Update();

                    List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Contracts_Base_Edit.ContractsCode));
                    string Check = (string)RASF.General.Lists.BanksList.FillScalar("CheckSendEmail_Select", Parameter3);

                    if (Check == "True")
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Contracts_Base_Edit.ContractsCode));
                        this.partsMasterSendEmailList1.Fill(Parameter1);

                        List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Contracts_Base_Edit.ContractsCode));
                        To = RASF.General.Lists.SendEmailList.FillScalar("SendEmail_Select", Parameter2).ToString();

                        RASF.General.Classes.SendEmail sendEmail = new RASF.General.Classes.SendEmail();
                        sendEmail.MakeEmail(this.partsMasterSendEmailList1.Where(row => row.Checked == true).ToList(), To, Contracts_Base_Edit.ContractNo);

                        List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", Contracts_Base_Edit.ContractsCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
                        Parameter.Add(new System.Data.SqlClient.SqlParameter("@EmailAdd", To));
                        RASF.General.Lists.Base.BaseList<Object>.FillScalar("SendingReportEmail_Insert", Parameter);
                    }

                 }

             
            }



            //RASF.General.Data.Contracts_Base_Edit Contracts_Base_Edit = new General.Data.Contracts_Base_Edit();

            //Contracts_Base_Edit.UserId = RASF.General.Classes.Global.CurrentUserCode;
            //this.isCompletedList1.Update();

            this.isCompletedList1.Fill();

            this.grdIsCompleted.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void grdIsCompleted_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToString(e.Row.Cells["EnglishReporter"].Value) == "دارد")
            {
                e.Row.Cells["EnglishReporter"].FormatStyle = this.EnglishReport;
            }
        }
            
        }
    }

