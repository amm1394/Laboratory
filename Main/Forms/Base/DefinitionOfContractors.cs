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
    public partial class DefinitionOfContractors : RASF.General.Forms.Base.DockContentForm
    {
        public DefinitionOfContractors()
        {
            InitializeComponent();

        }

        private void COMPANIES_BASE_Load(object sender, EventArgs e)
        {


            this.constractorsList1.Fill();
            this.contractors_FaxNumList1.Fill();
            this.contractorsPhoneNumList1.Fill();
            this.activeNonActiveList1.Fill();

            this.grdContractors.Refetch();
            this.grdPhone.Refetch();
            this.grdFax.Refetch();

            RASF.General.Classes.Utility.Create_DropDown(this.grdContractors.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");
            this.grdContractors.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;

            this.grdContractors.RemoveBindingContextChanged();
            this.grdContractorsAdd.RemoveBindingContextChanged();
            this.grdFax.RemoveBindingContextChanged();
            this.grdPhone.RemoveBindingContextChanged();



            this.grdContractors.SelectionChanged += new System.EventHandler(this.grdContractors_SelectionChanged);



            this.grdContractors_SelectionChanged(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.constractorsList1.Update();

          //  ((RASF.General.Data.Contractors_FaxNum)grdFax.CurrentRow.DataRow).ContractorCode = ((RASF.General.Data.Contractors)grdContractors.CurrentRow.DataRow).ContractorCode; ;
            this.contractors_FaxNumList1.Update();

          //  ((RASF.General.Data.Contractors_PhoneNum)grdPhone.CurrentRow.DataRow).ContractorCode = ((RASF.General.Data.Contractors)grdContractors.CurrentRow.DataRow).ContractorCode; ;
            this.contractorsPhoneNumList1.Update();

            this.grdContractors.Refetch();
            this.grdPhone.Refetch();
            this.grdFax.Refetch();

        }
        Guid CoId;

        private void grdContractors_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdContractors.SelectedItems[0].Position > -1)
            {
                CoId = ((RASF.General.Data.Contractors)grdContractorsAdd.CurrentRow.DataRow).ContractorCode;
            }
            else
            {
                CoId = new Guid();
            }

            this.grdPhone.RootTable.Columns["ContractorCode"].DefaultValue = CoId;
            this.grdPhone.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPhone.RootTable.Columns["ContractorCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdFax.RootTable.Columns["ContractorCode"].DefaultValue = CoId;
            this.grdFax.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdFax.RootTable.Columns["ContractorCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));
        }

            }
        }
    