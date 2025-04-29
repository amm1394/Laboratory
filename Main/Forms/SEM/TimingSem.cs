using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.SEM
{
    public partial class TimingSem : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle CheckFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle CanceledFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle InPersonFormat;

        public TimingSem()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            faDatePicker1.SelectedDateTime = System.DateTime.Now;

            this.CheckFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.CheckFormat.BackColor = Color.Red;
            this.CheckFormat.ForeColor = Color.Black;

            this.CanceledFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.CanceledFormat.BackColor = Color.Yellow;
            this.CanceledFormat.ForeColor = Color.Black;

            this.InPersonFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.InPersonFormat.BackColor = Color.Green;
            this.InPersonFormat.ForeColor = Color.Black;

           
        }

        private void TimingSem_Load(object sender, EventArgs e)
        {
            faDatePicker1.SelectedDateTime = System.DateTime.Now;
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.semContractList1.Fill(Parameter1);

            General.Classes.Utility.Create_DropDown(this.grdHours.RootTable.Columns["ContractsCode"], this.semContractList1, "ContractsCode", "ContractNo");
            this.grdHours.RootTable.Columns["ContractsCode"].DefaultValue = this.semContractList1[0].ContractsCode;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@DateOfSem", faDatePicker1.SelectedDateTime));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("TimeOfSem_Insert", Parameter);

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@DateOfSem", faDatePicker1.SelectedDateTime));
            this.timeOfSemList1.Fill(Parameter1);
            this.grdHours.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.timeOfSemList1.Update();

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@DateOfSem", faDatePicker1.SelectedDateTime));
            this.timeOfSemList1.Fill(Parameter1);
            this.grdHours.Refetch();
        }

        private void grdHours_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToBoolean(e.Row.Cells["Checked"].Value) == true)
            {
                e.Row.Cells["SemTime"].FormatStyle = this.CheckFormat;
            }

            if (Convert.ToBoolean(e.Row.Cells["Canceled"].Value) == true)
            {
                e.Row.Cells["Canceled"].FormatStyle = this.CanceledFormat;
            }

            if (Convert.ToBoolean(e.Row.Cells["InPerson"].Value) == true)
            {
                e.Row.Cells["InPerson"].FormatStyle = this.InPersonFormat;
            }
        }

        private void grdHours_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdHours.SelectedItems.Count > 0)
            {
                textBox1.Text = (string)this.grdHours.CurrentRow.Cells["Description"].Value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Report2.Load(String.Format("{0}\\Report\\SemTime.mrt", Application.StartupPath));
            Report2.Show();
        }

        private void grdHours_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.Main.Forms.SEM.SEMContract SEMContract = new RASF.Main.Forms.SEM.SEMContract();
            SEMContract.Show();
        }

        private void faDatePicker1_Leave(object sender, EventArgs e)
        {
            if (faDatePicker1.SelectedDateTime.DayOfWeek == DayOfWeek.Friday)
            {
                faDatePicker1.BackColor = Color.Red;
                MessageBox.Show("تاریخ تحویل روز جمعه انتخاب شده است", "جمعه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                faDatePicker1.BackColor = Color.White;
            }
        }
    }
}
