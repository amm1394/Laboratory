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
    public partial class ReferralComplaintToUser : RASF.General.Forms.Base.DockContentForm
    {
        public ReferralComplaintToUser()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.sabtCompanyUserList1.spName = "ResponsibleForComplaints";
        }

        private void ReferralComplaintToUser_Load(object sender, EventArgs e)
        {
            this.sabtCompanyUserList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdReferral.RootTable.Columns["ReferalUser"], this.sabtCompanyUserList1, "UserId", "UserName");
            this.grdReferral.RootTable.Columns["ReferalUser"].DefaultValue = this.sabtCompanyUserList1[0].UserId;

            this.referralComplaintToUserList1.Fill();
            this.grdReferral.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.referralComplaintToUserList1.Update();

            this.referralComplaintToUserList1.Fill();
            this.grdReferral.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.referralComplaintToUserList1.Fill();
            this.grdReferral.Refetch();
        }
    }
}
