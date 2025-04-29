using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class StatusInsurancedeductions : RASF.General.Forms.Base.DockContentForm
    {
        public StatusInsurancedeductions()
        {
            InitializeComponent();

            this.companiesCooperationTypeList1.spName = "StatusInsurancedeductions";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StatusInsurancedeductions_Load(object sender, EventArgs e)
        {
            FillGrid();

            General.Classes.Utility.CreateDropDow(drpYear, "ContractYear", "ContractYear", changeYearList1);

        }

        private void FillGrid()
        {
            this.companiesBaseList1.Fill();
            this.grdCompanies.Refetch();

            this.changeYearList1.Fill();

            this.rdbAkhzMafasa.Checked = false;
            this.rdbDaryaftName.Checked = false;
            this.rdbEraeyeMafasa.Checked = false;
            this.rdbErjaeName.Checked = false;
            this.rdbAkhzMafasa.Checked = false;
            this.rdbEraeyeMafasa.Checked = false;
            this.rdMoghayeratCustomer.Checked = false;
            this.rdmoghayertMali.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.rdbErsalName.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 1));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear",this.drpYear.SelectedValue));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdbDaryaftName.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 2));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdbErjaeName.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 3));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdbAkhzMafasa.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 4));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdbEraeyeMafasa.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 5));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdNemeToMoshtari.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 6));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdMoghayeratCustomer.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 7));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            if (this.rdmoghayertMali.Checked == true)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@InsuranceDeductionsCode", 8));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value.ToString()));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DoDate", this.DatePickertxtDoDate.SelectedDateTime));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinYear", this.drpYear.SelectedValue));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("StatusInsurancedeductions_Insert", Parameter);
            }

            FillGrid();
        }

        private void grdcompanies_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdCompanies.CurrentRow != null) && (this.grdCompanies.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "شرکت" + " " + this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString();
                this.grp2.Text = "شرکت" + " " + this.grdCompanies.CurrentRow.Cells["CompanyName"].Value.ToString();

                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", this.grdCompanies.CurrentRow.Cells["CompaniesCode"].Value));
                this.companiesCooperationTypeList1.Fill(Parameter);
                this.grdTypeDeductions.Refetch();
            }
            else
            {
                this.grpGrid.Text = "";
                this.grp2.Text = "";
            }


        }
    }
}
