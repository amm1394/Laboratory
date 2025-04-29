using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class CountTestOfLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        public CountTestOfLaboratory()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        private void CountTestOfLaboratory_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear",RASF.General.Classes.Global.FinancialYear));
            this.countTestOfLaboratoryList1.Fill(Parameter);
            this.grdCount.Refetch();

            this.changeYearList1.Fill();
            General.Classes.Utility.CreateDropDow(drpYear, "ContractYear", "", changeYearList1);
            this.drpYear.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear",Convert.ToInt32(drpYear.Text)));
            this.countTestOfLaboratoryList1.Fill(Parameter);
            this.grdCount.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdCount.ExportToExcel("گزارش تعدادی آزمونهای آزمایشگاه ها");
        }
    }
}
