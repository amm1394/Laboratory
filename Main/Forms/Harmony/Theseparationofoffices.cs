using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class Theseparationofoffices : RASF.General.Forms.Base.DockContentForm
    {
        public Theseparationofoffices()
        {
            InitializeComponent();
        }

        private void grdOffices_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Theseparationofoffices CurrentRow = (RASF.General.Data.Theseparationofoffices)this.grdOffices.CurrentRow.DataRow;
            RASF.Main.Forms.Harmony.ViewCostPaper CostPaper = new Harmony.ViewCostPaper(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            grdOffices.ExportToExcel("کارکرد دفاتر");
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.theseparationofofficesList1.Fill(Parameter);

            grdOffices.Refetch();

        }

        private void Theseparationofoffices_Load(object sender, EventArgs e)
        {
            pickDate1_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
        }
    }
}
