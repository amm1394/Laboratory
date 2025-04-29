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
    public partial class RegisterNotInPersonPart_Edit : RASF.General.Forms.Base.DockContentForm
    {

        public RegisterNotInPersonPart_Edit(Int64 id)
        {
            InitializeComponent();
            registerNotInPersonPartList1.spName = "RegisterNotInPersonPart_Edit";
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;

            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("code", id));
            registerNotInPersonPartList1.Fill(Parameters);

        }

        private void RegisterNotInPersonPart_Load(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Fill();

            General.Classes.Utility.CreateDropDow(drpOffices, "AgencyName", "AgencyCode", companiesAgencyListList1);

            this.txtSender.Text = this.registerNotInPersonPartList1.list[0].Sender;
            this.drpOffices.SelectedValue = this.registerNotInPersonPartList1.list[0].AgencyCode;
            this.txtDelivery.Text = this.registerNotInPersonPartList1.list[0].Delivery;
            this.DatePickerReciept.SelectedDateTime = this.registerNotInPersonPartList1.list[0].RecieptDate;
            this.txtContractNo.Text =Convert.ToString( this.registerNotInPersonPartList1.list[0].ContractNo);
            this.txtDesc.Text = this.registerNotInPersonPartList1.list[0].Description;
            this.txtCountPart.Text = Convert.ToString(this.registerNotInPersonPartList1.list[0].CountPart);
            this.timePicker1.Value = Convert.ToDateTime( this.registerNotInPersonPartList1.list[0].RecieptTime);

        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", this.registerNotInPersonPartList1.list[0].Code));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Sender", this.txtSender.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("AgencyCode", (Guid)this.drpOffices.SelectedValue));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Delivery", this.txtDelivery.Text));
          //  Parameters.Add(new System.Data.SqlClient.SqlParameter("RecieptDate", this.DatePickerReciept.SelectedDateTime));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractNo", Convert.ToInt32(this.txtContractNo.Text)));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("Description", this.txtDesc.Text));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("CountPart", Convert.ToInt32(this.txtCountPart.Text)));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("RecieptTime", this.timePicker1.Value));
            //Parameters.Add(new System.Data.SqlClient.SqlParameter("SabtUser", RASF.General.Classes.Global.CurrentUserCode));

            RASF.General.Lists.BanksList.FillScalar("RegisterNotInPersonPart_Edit_Update", Parameters);

            this.Close();
             

        }

      
    }
}
