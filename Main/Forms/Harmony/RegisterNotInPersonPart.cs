using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class RegisterNotInPersonPart : RASF.General.Forms.Base.DockContentForm
    {
        private List<RASF.General.Lists.RegisterNotInPersonPartList> RegisterNotInPersonPartList = new List<General.Lists.RegisterNotInPersonPartList>();
        private DateTime from;
        private DateTime to;
        private Guid CompanyCode;

        public RegisterNotInPersonPart()
        {
            InitializeComponent();
            this.ShowpnlExit = false;


        }

        private void groupBox7_Click(object sender, EventArgs e)
        {

        }

        private void RegisterNotInPersonPart_Load(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Fill();

            List<System.Data.SqlClient.SqlParameter> UsersGroup = new List<System.Data.SqlClient.SqlParameter>();
            UsersGroup.Add(new System.Data.SqlClient.SqlParameter("@groupName", "Receptionists"));
            this.usersGroupList1.Fill(UsersGroup);

            General.Classes.Utility.CreateDropDow(dropDownUserID, "UserName", "UserId", usersGroupList1);
            //dropDownUserID.SelectedValue = RASF.General.Classes.Global.CurrentUserCode;

            General.Classes.Utility.CreateDropDow(drpOffices, "AgencyName", "AgencyCode", companiesAgencyListList1);

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From",DateTime.Now));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To",DateTime.Now));
            this.registerNotInPersonPartList1.Fill(Parameter);
            this.grid1.Refetch();

            this.companiesBaseList1.Fill();
            this.grdCompanisInvoice.Refetch();

            this.txtSender.Text = string.Empty;
            this.drpOffices.SelectedIndex = -1;
            this.txtDelivery.Text = string.Empty;
            this.DatePickerReciept.SelectedDateTime = System.DateTime.Now.AddDays(0);
            this.txtContractNo.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
            this.txtCountPart.Text = string.Empty;
            this.timePicker1.Value = System.DateTime.Now.AddDays(0);

        }

    
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
             //Parameters.Add(new System.Data.SqlClient.SqlParameter("Sender", this.txtSender.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("AgencyCode", (Guid)this.drpOffices.SelectedValue));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Delivery", this.txtDelivery.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("RecieptDate", this.DatePickerReciept.SelectedDateTime));
          //  Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", 0)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Description", this.txtDesc.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CountPart", Convert.ToInt32(this.txtCountPart.Text)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("RecieptTime", this.timePicker1.Value));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("SabtUser", RASF.General.Classes.Global.CurrentUserCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CompanyCode", CompanyCode));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("userId",(dropDownUserID.SelectedValue)));

            RASF.General.Lists.BanksList.FillScalar("RegisterNotInPersonPart_Insert", Parameters);

            this.txtSender.Text = string.Empty;
            this.drpOffices.SelectedIndex = -1;
            this.txtDelivery.Text = string.Empty;
          //  this.DatePickerReciept.SelectedDateTime =  System.DateTime.Now.AddDays(0);
            this.txtContractNo.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
            this.txtCountPart.Text = string.Empty;
            this.timePicker1.Value = System.DateTime.Now.AddDays(0);

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From",from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", to));
            this.registerNotInPersonPartList1.Fill(Parameter);
            this.grid1.Refetch();

        }

        private void grid1_SelectionChanged(object sender, EventArgs e)
        {
            //RASF.General.Data.RegisterNotInPersonPart CurrentCompany = (RASF.General.Data.RegisterNotInPersonPart)this.grid1.CurrentRow.DataRow;
            //if (CurrentCompany != null)
            //{
            //    this.txtSender.Text = CurrentCompany.Sender;
            //    this.drpOffices.SelectedValue = CurrentCompany.AgencyCode;
            //    this.txtDelivery.Text = CurrentCompany.Delivery;
            ////    this.DatePickerReciept.SelectedDateTime = CurrentCompany.RecieptDate;
            //    this.txtContractNo.Text = Convert.ToString(CurrentCompany.ContractNo);
            //    this.txtDesc.Text = CurrentCompany.Description;
            //    this.txtCountPart.Text = Convert.ToString(CurrentCompany.CountPart);
            // //   this.timePicker1.Value = System.DateTime.Now.AddDays(0);
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", to));
            this.registerNotInPersonPartList1.Fill(Parameter);
            //this.grid1.Refetch();

            this.companiesBaseList1.Fill();
            this.grdCompanisInvoice.Refetch();
        }

        private void grid1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Int64 Code =(Int64) (this.grid1.CurrentRow.Cells["Code"].Value);
            RASF.Main.Forms.Harmony.RegisterNotInPersonPart_Edit Reciption_Edit = new RASF.Main.Forms.Harmony.RegisterNotInPersonPart_Edit(Code);
            Reciption_Edit.Show();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);

        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.registerNotInPersonPartList1.Fill(Parameter);
            this.grid1.Refetch();

            from = e.From;
            to = e.To;
        }

        private void grdCompanisInvoice_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Companies_Base CurrentCompany = (RASF.General.Data.Companies_Base)this.grdCompanisInvoice.CurrentRow.DataRow;
            CompanyCode = CurrentCompany.CompaniesCode;
            this.groupBox12.Text = "نام شرکت جهت صدور صورت حساب  " + CurrentCompany.CompanyName;
        }
    }
}
