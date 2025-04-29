using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Marketing
{
    public partial class AcceptAndNonAcceptActivity : RASF.General.Forms.Base.DockContentForm
    {
        public AcceptAndNonAcceptActivity()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void AcceptAndNonAcceptActivity_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> param = new List<System.Data.SqlClient.SqlParameter>();
            param.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.nonAcceptedMarketingActivityList1.Fill(param);
            this.grdnonAccept.Refetch();

            List<System.Data.SqlClient.SqlParameter> param1 = new List<System.Data.SqlClient.SqlParameter>();
            param1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.acceptedMarketingActivityList1.Fill(param1);
            this.grdAccept.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> param = new List<System.Data.SqlClient.SqlParameter>();
            param.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.nonAcceptedMarketingActivityList1.Fill(param);
            this.grdnonAccept.Refetch();

            List<System.Data.SqlClient.SqlParameter> param1 = new List<System.Data.SqlClient.SqlParameter>();
            param1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.acceptedMarketingActivityList1.Fill(param1);
            this.grdAccept.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void grdnonAccept_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdnonAccept.SelectedItems.Count > 0)
            {
                RASF.General.Data.MarketingActivity CurrentRow = (General.Data.MarketingActivity)this.grdnonAccept.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.nonAcceptedMarketingActivityList1.Update();
            }

            List<System.Data.SqlClient.SqlParameter> param = new List<System.Data.SqlClient.SqlParameter>();
            param.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.nonAcceptedMarketingActivityList1.Fill(param);
            this.grdnonAccept.Refetch();

            List<System.Data.SqlClient.SqlParameter> param1 = new List<System.Data.SqlClient.SqlParameter>();
            param1.Add(new System.Data.SqlClient.SqlParameter("@UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.acceptedMarketingActivityList1.Fill(param1);
            this.grdAccept.Refetch();
                
        }

        private void grdnonAccept_SelectionChanged(object sender, EventArgs e)
        {
            textBox1.Text = (string)this.grdnonAccept.CurrentRow.Cells["Description"].Value;

        }

        private void grdAccept_SelectionChanged(object sender, EventArgs e)
        {
            textBox2.Text = (string)this.grdAccept.CurrentRow.Cells["Description"].Value;

        }
    }
}
