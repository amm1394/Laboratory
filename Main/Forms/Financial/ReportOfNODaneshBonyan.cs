using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ReportOfNODaneshBonyan : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public ReportOfNODaneshBonyan()
        {
            InitializeComponent();
            this.To = this.From = System.DateTime.Now;
           // pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.reportOfDaneshBonyanList1.spName = "ReportOfNoDaneshBonyan";
        }

        private void fill()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", laboratoryName1.LabCode));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            this.reportOfDaneshBonyanList1.Fill(Parameters);
            this.grdLab.Refetch();

        }
     
        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.From = e.From;
            this.To = e.To;
            this.fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdLab.ExportToExcel(this.laboratoryName1.Lab1Name);
        }

        private void laboratoryName1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.fill();
        }

        private void grdLab_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.LaboratoryofFinancialConditionReport CurrentRow = (RASF.General.Data.LaboratoryofFinancialConditionReport)this.grdLab.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }
    }

}
    
