using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Complaint
{
    public partial class InitialComplaintReview : RASF.General.Forms.Base.DockContentForm
    {
        public InitialComplaintReview()
        {
            InitializeComponent();
        }

        private void InitialComplaintReview_Load(object sender, EventArgs e)
        {
            RefreshGrid();

            this.textBox2.Enabled = false; 

        }

        private void RefreshGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ReferalUser", RASF.General.Classes.Global.CurrentUserCode));
            this.initialComplaintReviewList1.Fill(Parameter);
            this.grdReport.Refetch();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.textBox2.Enabled = true;
            }
            else
            {
                this.textBox2.Enabled = false;
            }
        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            // RASF.General.Data.Complaint Current_Contract = (RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow;

            // if (Current_Contract != null && (String.IsNullOrWhiteSpace(Current_Contract.InitialResult) == false))
            //{

            //    ((RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
            //    this.initialComplaintReviewList1.Update();

            //    RefreshGrid();
            //}

        }

        private void grdReport_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdReport.CurrentRow != null) && (this.grdReport.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.groupBox1.Text = String.Format("شرکت {0}", this.grdReport.CurrentRow.Cells["CompanyName"].Value);
            }
            else
            {
                this.groupBox1.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Data.Complaint Current_Contract = (RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow;

            if (Current_Contract != null && (String.IsNullOrWhiteSpace(Current_Contract.InitialResult) == false))
            {

                ((RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                this.initialComplaintReviewList1.Update();

                RefreshGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RASF.General.Data.Complaint Current_Contract = (RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow;

            if (Current_Contract != null && (String.IsNullOrWhiteSpace(Current_Contract.InitialResult) == false))
            {

                ((RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                this.initialComplaintReviewList1.Update();

                RefreshGrid();

                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RASF.General.Data.Complaint Current_Contract = (RASF.General.Data.Complaint)this.grdReport.SelectedItems[0].GetRow().DataRow;
            if (Current_Contract != null && (String.IsNullOrWhiteSpace(Current_Contract.DescControlAction) == false))
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@SabtComplaintCode", Current_Contract.SabtComplaintCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@ControlAction", Current_Contract.ControlAction));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("@DescControlAction", Current_Contract.DescControlAction));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("InitialComplaintControlAction_Update", Parameter);

                RefreshGrid();

                textBox2.Text = "";
            }
        }
    }
}
