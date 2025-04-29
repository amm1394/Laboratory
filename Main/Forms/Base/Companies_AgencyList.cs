using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class Companies_AgencyList : RASF.General.Forms.Base.DockContentForm
    {
        public Companies_AgencyList()
        {
            InitializeComponent();
        }
        Guid AgencyId;

        private void Companies_AgencyList_Load(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Fill();
            this.agencyFaxNumList1.Fill();
            this.agencyPhoneNumList1.Fill();
            this.activeNonActiveList1.Fill();
            this.agencyMobileNumList1.Fill();

            this.grdAgencyName.Refetch();
            this.grdAgencyInfo.Refetch();
            this.grdAgencyMobile.Refetch();
            this.grdAgencyFax.Refetch();
            this.grdPhone.Refetch();

            this.grdAgencyFax.RemoveBindingContextChanged();
            this.grdAgencyInfo.RemoveBindingContextChanged();
            this.grdAgencyMobile.RemoveBindingContextChanged();
            this.grdAgencyName.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();


            General.Classes.Utility.Create_DropDown(this.grdAgencyInfo.RootTable.Columns["status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            this.grdAgencyInfo.RootTable.Columns["status"].DefaultValue = this.activeNonActiveList1[0].Code;

            this.grdAgencyName.SelectionChanged +=new System.EventHandler(this.grdAgencyName_SelectionChanged);

            this.grdAgencyName_SelectionChanged(sender, e);

        }

        void grdAgencyName_SelectionChanged(object sender, EventArgs e)
        {
             AgencyId = new Guid();

            if (this.grdAgencyName.SelectedItems[0].Position > -1)
            {

                AgencyId = this.companiesAgencyListList1[this.grdAgencyName.SelectedItems[0].Position].AgencyCode;
            }

            this.grdPhone.RootTable.Columns["AgencyCode"].DefaultValue = AgencyId;
            this.grdPhone.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPhone.RootTable.Columns["AgencyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, AgencyId));

            this.grdAgencyMobile.RootTable.Columns["AgencyCode"].DefaultValue = AgencyId;
            this.grdAgencyMobile.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdAgencyMobile.RootTable.Columns["AgencyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, AgencyId));

            this.grdAgencyFax.RootTable.Columns["AgencyCode"].DefaultValue = AgencyId;
            this.grdAgencyFax.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdAgencyFax.RootTable.Columns["AgencyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, AgencyId));

                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Update();
            this.agencyFaxNumList1.Update();
            this.agencyPhoneNumList1.Update();
            this.agencyMobileNumList1.Update();
        }

        private void grdAgencyName_RowCountChanged(object sender, EventArgs e)
        {
            this.grdAgencyInfo.Refetch();
        }

     
      
    }
}
