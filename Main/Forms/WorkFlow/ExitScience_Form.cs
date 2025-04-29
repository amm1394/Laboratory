using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{

    public partial class ExitScience_Form : RASF.General.Forms.Base.DockContentForm
    {


        public ExitScience_Form()
        {
            InitializeComponent();


        
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;

            this.contractsForWorkFlowList1.spName = "ExitScience";

        }

        private void grdContract_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsForWorkFlow CurrentRow = (RASF.General.Data.ContractsForWorkFlow)this.grdContract.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

      
         private void FillGrids()
        {
            //List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
           this.contractsForWorkFlowList1.Fill();

            this.grdContract.Refetch();

        }

    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrids();

 
        }

        private void EnterScience_Form_Load(object sender, EventArgs e)
        {
            FillGrids();
        }

   

     
    }
}
