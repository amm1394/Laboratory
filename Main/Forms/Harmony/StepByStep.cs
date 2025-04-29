using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class StepByStep : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From, To;
        public StepByStep()
        {
            InitializeComponent();
            this.notDestructList1.spName = "StepByStep";

            this.To = this.From = System.DateTime.Now;
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            From = e.From;
            To = e.To;
            if (e.From == DateTime.MinValue || e.To == DateTime.MinValue)
            {
                From = DateTime.Now; To = DateTime.Now;
            }
            else
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
                this.notDestructList1.Fill(Parameter);
                this.grdDestruct.Refetch();
                From = e.From;
                To = e.To;
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", To));
            this.notDestructList1.Fill(Parameter);
            this.grdDestruct.Refetch();
        }

        private void grdDestruct_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.NotDestruct CurrentRow = (RASF.General.Data.NotDestruct)this.grdDestruct.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void NotDestruct_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdDestruct.ExportToExcel("مرحله به مرحله");
        }
    }
}
