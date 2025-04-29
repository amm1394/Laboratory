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
    public partial class ViewTarrif_Master : RASF.General.Forms.Base.DockContentForm
    {
        public ViewTarrif_Master()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void LABORATORY_Load(object sender, EventArgs e)
        {
            this.labList1.Fill();
            this.mainTestList1.Fill();
            this.masterTestList1.Fill();
            this.tarrifList1.Fill();
            this.userList1.Fill();
            this.activeNonActiveList1.Fill();
            this.yes_NoList1.Fill();

            this.grdlaboratory.Refetch();
            this.grdMain.Refetch();
            this.grdMaster.Refetch();
            this.grdTarrif.Refetch();

            this.grdlaboratory.RemoveBindingContextChanged();
            this.grdMain.RemoveBindingContextChanged();
            this.grdMaster.RemoveBindingContextChanged();
            this.grdTarrif.RemoveBindingContextChanged();


            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["CreatorID"], this.userList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["ExpertID"], this.userList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["SientificManagerID"], this.userList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["TecnicalManagerID"], this.userList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            General.Classes.Utility.Create_DropDown(this.grdMain.RootTable.Columns["HasStandard"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdMain.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            General.Classes.Utility.Create_DropDown(this.grdMaster.RootTable.Columns["Printable"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdMaster.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            this.grdlaboratory.RootTable.Columns["CreatorID"].DefaultValue = this.userList1[0].UserName;
            this.grdlaboratory.RootTable.Columns["ExpertID"].DefaultValue = this.userList1[0].UserName;
            this.grdlaboratory.RootTable.Columns["SientificManagerID"].DefaultValue = this.userList1[0].UserName;
            this.grdlaboratory.RootTable.Columns["TecnicalManagerID"].DefaultValue = this.userList1[0].UserName;
            this.grdlaboratory.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].ActOrNonAct;

            this.grdMain.RootTable.Columns["HasStandard"].DefaultValue = this.yes_NoList1[0].YesNo;
            this.grdMain.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].ActOrNonAct;

            this.grdMaster.RootTable.Columns["Printable"].DefaultValue = this.yes_NoList1[0].YesNo;
            this.grdMaster.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].ActOrNonAct;
            
            this.grdlaboratory.SelectionChanged += new System.EventHandler(this.grdlaboratory_SelectionChanged);
            this.grdMaster.SelectionChanged += new System.EventHandler(this.grdMaster_SelectionChanged);
            this.grdMain.SelectionChanged += new System.EventHandler(this.grdMain_SelectionChanged);
            this.grdTarrif.SelectionChanged +=grdTarrif_SelectionChanged;


            this.grdlaboratory_SelectionChanged(sender, e);
            this.grdMain_SelectionChanged(sender, e);
            this.grdMaster_SelectionChanged(sender, e);
        }

        private void grdTarrif_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdTarrif.CurrentRow != null) && (this.grdTarrif.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpTarrif.Text = this.grdTarrif.CurrentRow.Cells["FinancialYear"].Value.ToString();
            }
            else
            {
                this.grpTarrif.Text = "";
            }
        }

        private void grdlaboratory_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdlaboratory.CurrentRow != null) && (this.grdlaboratory.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grp_Lab.Text = this.grdlaboratory.CurrentRow.Cells["LaboratoryName"].Value.ToString();
                this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"].DefaultValue = this.grdlaboratory.CurrentRow.Cells["LaboratoryCode"].Value;
                this.grdMain.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdlaboratory.CurrentRow.Cells["LaboratoryCode"].Value));
                this.grdMain.Enabled = true;
                this.grdMaster.Enabled = true;
                this.grdTarrif.Enabled = true;
            }
            else
            {
                this.grp_Lab.Text = "";
                this.grdMain.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdMain.Enabled = false;
                this.grdMaster.Enabled = false;
                this.grdTarrif.Enabled = false;
            }
            this.grdMain.MoveFirst();
        }

        private void grdMain_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdMain.CurrentRow != null) && (this.grdMain.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpMain.Text = this.grdMain.CurrentRow.Cells["MainTestName"].Value.ToString();
                this.grdMaster.RootTable.Columns["MainTestCode"].DefaultValue = this.grdMain.CurrentRow.Cells["MainCode"].Value;
                this.grdMaster.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMaster.RootTable.Columns["MainTestCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdMain.CurrentRow.Cells["MainCode"].Value));
                this.grdMaster.Enabled = true;
                this.grdTarrif.Enabled = true;
            }
            else
            {
                this.grpMain.Text = "";
                this.grdMaster.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMaster.RootTable.Columns["MainTestCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdMaster.Enabled = false;
                this.grdTarrif.Enabled = false;
            }
            this.grdMaster.MoveFirst();

        }

        private void grdMaster_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdMaster.CurrentRow != null) && (this.grdMaster.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {

                this.grpmaster.Text = this.grdMaster.CurrentRow.Cells["MasterName"].Value.ToString();
                this.grdTarrif.RootTable.Columns["MasterTestCode_Tarrif"].DefaultValue = this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value;
                this.grdTarrif.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdTarrif.RootTable.Columns["MasterTestCode_Tarrif"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value));
                this.grdTarrif.Enabled = true;

            }
            else
            {
                this.grpmaster.Text = "";
                this.grdTarrif.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdTarrif.RootTable.Columns["MasterTestCo de_Tarrif"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdTarrif.Enabled = false;
            }
            this.grdTarrif.MoveFirst();
        }

      
    }
}
