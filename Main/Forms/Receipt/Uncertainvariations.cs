using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Receipt
{
    public partial class Uncertainvariations :RASF.General.Forms.Base.DockContentForm
    {
        private string Assno;
        public Uncertainvariations()
        {
            InitializeComponent();
           // this.ShowpnlExit = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@RecieptDate", DatePickerReciept.SelectedDateTime));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@Amount",Convert.ToInt64(txtAmount.Text)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignNo", txtRecieptNo.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName",RASF.General.Classes.Global.CurrentUserName));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", RASF.General.Classes.Global.FinancialYear));
            RASF.General.Lists.BanksList.FillScalar("Uncertainvariations_Insert", Parameters);

            DatePickerReciept.SelectedDateTime = DateTime.Now;
            txtAmount.Text = string.Empty;
            txtRecieptNo.Text = String.Empty;

            this.uncertainvariationsList1.Fill();
            this.grdAmount.Refetch();

        }

        private void Uncertainvariations_Load(object sender, EventArgs e)
        {
            this.uncertainvariationsList1.Fill();
            this.grdAmount.Refetch();

            this.companiesBaseList1.Fill();
            this.grdCompany.Refetch();
        }

        private void grdCompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentRow = (RASF.General.Data.Companies_Base)this.grdCompany.CurrentRow.DataRow;

            foreach (RASF.General.Data.uncertainvariations uncertainvariations in this.uncertainvariationsList1.Where(row => row.Check == true))
            {
                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@Amount", uncertainvariations.Amount));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear", uncertainvariations.FinancialYear));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@UserName", RASF.General.Classes.Global.CurrentUserName));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@CompaniesCode", CurrentRow.CompaniesCode));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentDate", uncertainvariations.RecieptDate));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@AssignmentNo", uncertainvariations.AssignmentNo));
                Parameters.Add(new System.Data.SqlClient.SqlParameter("@ID", uncertainvariations.ID));


                RASF.General.Lists.BanksList.FillScalar("ImportUncertainvariations_Insert", Parameters);
                uncertainvariations.Check = false;
            }

            this.uncertainvariationsList1.Fill();
            this.grdAmount.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.grdAmount.ExportToExcel("واریزی های نامشخص");
        }

        private void txtRecieptNo_Leave(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("AssignmentNo", String.Format("{0}", this.txtRecieptNo.Text)));
            Assno = (string)RASF.General.Lists.BanksList.FillScalar("FindAssignmentNo_Select", Parameter);
            string Asstxt = this.txtRecieptNo.Text;

            if (Assno == Asstxt)
            {
                MessageBox.Show("شماره حواله تکراری در رسیدها ");
                this.txtRecieptNo.Text = "";
            }

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("AssignmentNo", String.Format("{0}", this.txtRecieptNo.Text)));
            string Assno1 = (string)RASF.General.Lists.BanksList.FillScalar("FindAssignmentNo2_Select", Parameter1);
            string Asstxt1 = this.txtRecieptNo.Text;

            if (Assno1 == Asstxt1)
            {
                MessageBox.Show("شماره حواله تکراری  در نامشخص ها");
                this.txtRecieptNo.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.uncertainvariationsList1.Fill();
            this.grdAmount.Refetch();

            this.companiesBaseList1.Fill();
            this.grdCompany.Refetch();
        }
    }
}
