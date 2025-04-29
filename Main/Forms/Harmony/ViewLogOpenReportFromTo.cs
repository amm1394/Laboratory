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
    public partial class ViewLogOpenReportFromTo : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
    
        public ViewLogOpenReportFromTo()
        {
            InitializeComponent();

            this.showWorkFlowDescriptionList1.spName = "ViewOpenReportFromTo";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));       
        }

      

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.showWorkFlowDescriptionList1.Fill(Parameter);
            this.grid2.Refetch();
        }



        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;

            List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.showWorkFlowDescriptionList1.Fill(Parameter6);
            this.grid2.Refetch();
        }

    

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grid2.ExportToExcel("");
        }

      
    }
}
