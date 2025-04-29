using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    [System.ComponentModel.Category("RASF")]
    public partial class Contractors : RASF.General.Forms.Base.DockContentForm
    {
        public Contractors()
        {
            InitializeComponent();
        }
        Guid ContractorID;

        private void Companies_AgencyList_Load(object sender, EventArgs e)
        {
            this.constractorsList1.Fill();
            this.contractors_FaxNumList1.Fill();
            this.contractors_MobilNumList1.Fill();
            this.activeNonActiveList2.Fill();
            this.contractorsPhoneNumList1.Fill();

            this.grdContractor.Refetch();
            this.grdContractorInfo.Refetch();
            this.grdFax.Refetch();
            this.grdMobile.Refetch();
            this.grdPhone.Refetch();

            this.grdFax.RemoveBindingContextChanged();
            this.grdContractorInfo.RemoveBindingContextChanged();
            this.grdMobile.RemoveBindingContextChanged();
            this.grdContractor.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();


            General.Classes.Utility.Create_DropDown(this.grdContractorInfo.RootTable.Columns["status"], this.activeNonActiveList2, "Code", "ActOrNonAct");

            this.grdContractorInfo.RootTable.Columns["status"].DefaultValue = this.activeNonActiveList2[0].Code;

            this.grdContractor.SelectionChanged += new System.EventHandler(this.grdAgencyName_SelectionChanged);

            this.grdAgencyName_SelectionChanged(sender, e);

        }

        void grdAgencyName_SelectionChanged(object sender, EventArgs e)
        {
            RefetchData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.constractorsList1.Update();
            this.contractors_FaxNumList1.Update();
            this.contractors_MobilNumList1.Update();
            this.contractorsPhoneNumList1.Update();
        }

        private void RefetchData()
        {
            if (this.grdContractor.CurrentRow.DataRow != null)
            {
                ContractorID = ((RASF.General.Data.Contractors)this.grdContractor.CurrentRow.DataRow).ContractorCode;  // this.constractorsList1[this.grdContractor.SelectedItems[0].Position].ContractorCode;
            }
            else
            {
                ContractorID = Guid.Empty;
            }

            this.grdPhone.RootTable.Columns["ContractorCode"].DefaultValue = ContractorID;
            this.grdPhone.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPhone.RootTable.Columns["ContractorCode"], Janus.Windows.GridEX.ConditionOperator.Equal, ContractorID));

            this.grdMobile.RootTable.Columns["ContractorCode"].DefaultValue = ContractorID;
            this.grdMobile.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMobile.RootTable.Columns["ContractorCode"], Janus.Windows.GridEX.ConditionOperator.Equal, ContractorID));

            this.grdFax.RootTable.Columns["ContractorCode"].DefaultValue = ContractorID;
            this.grdFax.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdFax.RootTable.Columns["ContractorCode"], Janus.Windows.GridEX.ConditionOperator.Equal, ContractorID));

            RASF.General.Data.Contractors Current_Contractors = (RASF.General.Data.Contractors)this.grdContractor.SelectedItems[0].GetRow().DataRow;
            if (Current_Contractors != null)
            {
                this.grbAgencyName.Text = this.grdContractor.CurrentRow.Cells["Name"].Value.ToString();
                // this.groupBox1.Text = "اطلاعات تکمیلی شرکت" + " " + this.grdCompanyBase.CurrentRow.Cells["CompanyName"].Value.ToString();
            }

            this.grdPhone.Refetch();
            this.grdMobile.Refetch();
            this.grdFax.Refetch();
        }

        private void grdContractor_RowCountChanged(object sender, EventArgs e)
        {
            RefetchData();
            this.grdContractorInfo.Refetch();
        }
    }
}
