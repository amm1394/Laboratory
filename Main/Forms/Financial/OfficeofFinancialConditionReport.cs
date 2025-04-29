using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class OfficeofFinancialConditionReport : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public OfficeofFinancialConditionReport()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
        }

        private void fill()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("OfficesCode", officesName1.OfficesCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            this.officeofFinancialConditionReportList1.Fill(Parameters);
            this.grdOffices.Refetch();

        }
        private void officesName1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.fill();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdOffices.ExportToExcel(this.officesName1.OfficeName);
        }

        private void grdOffices_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.OfficeofFinancialConditionReport CurrentRow = (RASF.General.Data.OfficeofFinancialConditionReport)this.grdOffices.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }

}
    
