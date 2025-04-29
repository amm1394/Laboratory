using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class CompaniesReferntForManager : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        public CompaniesReferntForManager()
        {
            InitializeComponent();
            this.companiesReferntList1.spName = "CompaniesReferntForManager";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        private void CompaniesReferntForm_Load(object sender, EventArgs e)
        {
            //this.companiesReferntList1.Fill();
            //this.grdCompaneis.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdCompaneis.ExportToExcel("کارهای ارجاعی شرکت ها");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.companiesReferntList1.Fill();
            //this.grdCompaneis.Refetch();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);

        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@To", e.To));
            this.companiesReferntList1.Fill(Parameter);
            this.grdCompaneis.Refetch();
        }

        private void grdCompaneis_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToInt16(e.Row.Cells["MorajeatKol"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["MorajeatKol"].Value) > 0 && Convert.ToInt16(e.Row.Cells["HaghHogh"].Value) != 0)
            {
                e.Row.Cells["CompanyName"].FormatStyle = this.NewCustomerFormat;
            }
        }
    }
}
