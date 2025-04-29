using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RAFS.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class Chash : RASF.General.Forms.Base.DockContentForm
    {
        public Chash()
        {
            InitializeComponent();
        }

        private void Chash_Load(object sender, EventArgs e)
        {
            this.cashList1.Fill();
            this.activeNonActiveList1.Fill();
            this.userList1.Fill();
            this.companiesAgencyListList1.Fill();

            this.grdCash.Refetch();

            this.grdCash.RemoveBindingContextChanged();

            RASF.General.Classes.Utility.Create_DropDown(this.grdCash.RootTable.Columns["UserId"], this.userList1, "UserId", "UserName");

            RASF.General.Classes.Utility.Create_DropDown(this.grdCash.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            RASF.General.Classes.Utility.Create_DropDown(this.grdCash.RootTable.Columns["CashAgency"], this.companiesAgencyListList1, "AgencyCode", "AgencyName");

            this.grdCash.RootTable.Columns["UserId"].DefaultValue = this.userList1[0].UserId;

            this.grdCash.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;

            this.grdCash.RootTable.Columns["CashAgency"].DefaultValue = this.companiesAgencyListList1[0].AgencyCode;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.cashList1.Update();
        }
    }
}
