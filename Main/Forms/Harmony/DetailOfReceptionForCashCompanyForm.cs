using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class DetailOfReceptionForCashCompanyForm : RASF.General.Forms.Base.DockContentForm
    {
        public DetailOfReceptionForCashCompanyForm()
        {
            InitializeComponent();
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private DateTime From;
        private DateTime To;


        private void DetailOfReceptionForm_Load(object sender, EventArgs e)
        {
          
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
            this.detailOfReceptionForCashCompanyList1.Fill(Parameter);
            this.grdDetail.Refetch();
            From = e.From;
            To = e.To;
        }

        private void grdDetail_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.DetailOfReception CurrentRow = (RASF.General.Data.DetailOfReception)this.grdDetail.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.detailOfReceptionForCashCompanyList1.Fill(Parameter);
            this.grdDetail.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDetail.ExportToExcel("شرکت های نقدی که بدهی دارند");
        }
    }
}
