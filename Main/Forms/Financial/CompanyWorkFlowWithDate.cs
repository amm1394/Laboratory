using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class CompanyWorkFlowWithDate : RASF.General.Forms.Base.DockContentForm
    {
        public CompanyWorkFlowWithDate()
        {
            InitializeComponent();
       
        }

  
        private void CompanyWorkFlow_Load(object sender, EventArgs e)
        {
    
        }

        private void grdCompanies_SelectionChanged(object sender, EventArgs e)
        {
             
      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdWorkFlow.ExportToExcel("");
        }

        private void grdWorkFlow_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.CompanyWorkFlow CurrentRow = (RASF.General.Data.CompanyWorkFlow)this.grdWorkFlow.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.MdiParent = this.MdiParent;
            CostPaper.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
       
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.companyWorkFlowBaseOfPeymentCostomerList1.Fill(Parameter);
            this.grdWorkFlow.Refetch();
        }

        
    }
}
