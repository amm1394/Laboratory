using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class IndicatorDelivery : RASF.General.Forms.Base.DockContentForm
    {
        private  Guid ContractsCode;
        private Int16 LastConf;
        public IndicatorDelivery()
        {
            InitializeComponent();
            this.indicatorList1.spName = "IndicatorDelevery";
        }
        public IndicatorDelivery(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new RASF.General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void searchContract1_ReturnContractsCode(RASF.General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;

            //List<System.Data.SqlClient.SqlParameter> LastConfirm = new List<System.Data.SqlClient.SqlParameter>();
            //LastConfirm.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", this.ContractsCode));
            //LastConf = Convert.ToInt16( RASF.General.Lists.BanksList.FillScalar("LastConfirm_Select", LastConfirm));

            //if (this.LastConf == 0)
            //{
            //    labbedehi.Text = "این قرارداد بدهی دارد.";
            //}
            //else
            //{
            //    labbedehi.Text = "";

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
                this.indicatorList1.Fill(Parameter);
                this.GrdContract.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameter8 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter8.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
                this.hasCDForLaboratoryList1.Fill(Parameter8);
                this.grdHasCD.Refetch();

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
                this.viewIndicatorList1.Fill(Parameter1);
                this.grdView.Refetch();
         //   }

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.labDebContract.Text =Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ContractRemind_Select", Parameter2)).ToString("#,#");

            if (this.labDebContract.Text != string.Empty)
            {
                if (Convert.ToInt64(this.labDebContract.Text.Replace(",", "")) > 0)
                {
                    this.labDebContract.BackColor = Color.Red;
                }
            }

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.labDebContracts.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ContractsRemindNotComplete_Select", Parameter3)).ToString("#,#");

            List<System.Data.SqlClient.SqlParameter> Parameter4 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter4.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.labCredit.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("CreditCompanies_Select", Parameter4)).ToString("#,#");

            List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.labCooperation.Text = Convert.ToString(RASF.General.Lists.Base.BaseList<Object>.FillScalar("CompaniesCooperation_Select", Parameter6));

            List<System.Data.SqlClient.SqlParameter> Parameter5 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter5.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.labDebCustomer.Text = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("RemindCompanies_Select", Parameter5)).ToString("#,#");

            List<System.Data.SqlClient.SqlParameter> Parameter7 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter7.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.LabNotDeliveryReport.Text = Convert.ToString(RASF.General.Lists.Base.BaseList<Object>.FillScalar("NotDeliveryReport_Select", Parameter7));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtindicator.Text = RASF.General.Classes.Utility.CorrectFileName(txtindicator.Text);
            if (txtindicator.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("لطفا علت خروج را به طور کامل وارد نمایید");
            }
            else
            {

                if (this.GrdContract.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Indicator Current_Contract = (RASF.General.Data.Indicator)this.GrdContract.SelectedItems[0].GetRow().DataRow;

                    if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                    {
                        Current_Contract.RowState = General.Enums.RowState.Added;
                        Current_Contract.UderId = RASF.General.Classes.Global.CurrentUserCode;
                        Current_Contract.ContractsCode = this.ContractsCode;
                        Current_Contract.IsComplete = Current_Contract.IsCompleted;
                        this.indicatorList1.Update();

                        this.txtindicator.Text = String.Empty;

                        List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
                        this.viewIndicatorList1.Fill(Parameter1);

                        this.grdView.Refetch();
                    }
                }
            }
        }

        private void btnSabt_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text != string.Empty)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("UserId",RASF.General.Classes.Global.CurrentUserCode));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("Description", txtDesc.Text));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("RegisterDescIndicator_Insert", Parameter2);

                MessageBox.Show("اطلاعات با موفقیت ثبت شد");

                txtDesc.Text = "";

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
                this.indicatorList1.Fill(Parameter);

                this.GrdContract.Refetch();
            }
        }

        private void splitContainer9_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
