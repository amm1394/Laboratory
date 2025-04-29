using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class AgencyPhoneNum : RASF.General.Forms.Base.DockContentForm
    {
        public AgencyPhoneNum()
        {
            InitializeComponent();
        }

        private void AgencyPhoneNum_Load(object sender, EventArgs e)
        {
            this.agencyPhoneNumList1.Fill();
            this.companiesAgencyListList1.Fill();

            this.grdPhoneNum.Refetch();

            RASF.General.Classes.Utility.Create_DropDown(this.grdPhoneNum.RootTable.Columns["AgencyCode"], this.companiesAgencyListList1, "AgencyCode", "AgencyName");

            this.grdPhoneNum.RootTable.Columns["AgencyCode"].DefaultValue = this.companiesAgencyListList1[0].AgencyCode;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.agencyPhoneNumList1.Update();
        }
    }
}
