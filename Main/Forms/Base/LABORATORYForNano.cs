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
    public partial class LABORATORYForNano : RASF.General.Forms.Base.DockContentForm
    {
        public LABORATORYForNano()
        {
            InitializeComponent();
        }

        private void LABORATORY_Load(object sender, EventArgs e)
        {
            this.labList1.Fill();
            this.mainTestList1.Fill();
            this.masterTestList1.Fill();
            this.detailTestList1.Fill();
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("groupName", "Laboratory_User"));
            this.usersGroupList1.Fill(Parameter);
            this.activeNonActiveList1.Fill();
            this.yes_NoList1.Fill();

            this.grdlaboratory.Refetch();
            this.grdMain.Refetch();
            this.grdMaster.Refetch();
            this.grdDetail.Refetch();

            this.grdlaboratory.RemoveBindingContextChanged();
            this.grdMain.RemoveBindingContextChanged();
            this.grdMaster.RemoveBindingContextChanged();
            this.grdDetail.RemoveBindingContextChanged();

            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["CreatorID"], this.usersGroupList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["ExpertID"], this.usersGroupList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["SientificManagerID"], this.usersGroupList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["TecnicalManagerID"], this.usersGroupList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdlaboratory.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            General.Classes.Utility.Create_DropDown(this.grdMain.RootTable.Columns["HasStandard"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdMain.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            General.Classes.Utility.Create_DropDown(this.grdMaster.RootTable.Columns["Printable"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdMaster.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");
         

            General.Classes.Utility.Create_DropDown(this.grdDetail.RootTable.Columns["HaveReport"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdDetail.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            this.grdlaboratory.RootTable.Columns["CreatorID"].DefaultValue = this.usersGroupList1[0].UserId;
            this.grdlaboratory.RootTable.Columns["ExpertID"].DefaultValue = this.usersGroupList1[0].UserId;
            this.grdlaboratory.RootTable.Columns["SientificManagerID"].DefaultValue = this.usersGroupList1[0].UserId;
            this.grdlaboratory.RootTable.Columns["TecnicalManagerID"].DefaultValue = this.usersGroupList1[0].UserId;
            this.grdlaboratory.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;

            this.grdMain.RootTable.Columns["HasStandard"].DefaultValue = this.yes_NoList1[0].Code;
            this.grdMain.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;
            this.grdMain.RootTable.Columns["CarriedoutintheBonyad"].DefaultValue = true;

            this.grdMaster.RootTable.Columns["Printable"].DefaultValue = this.yes_NoList1[0].Code;
            this.grdMaster.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;

            this.grdDetail.RootTable.Columns["HaveReport"].DefaultValue = this.yes_NoList1[0].Code;
            this.grdDetail.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;
           

            this.grdlaboratory.SelectionChanged += new System.EventHandler(this.grdlaboratory_SelectionChanged);
            this.grdMaster.SelectionChanged += new System.EventHandler(this.grdMaster_SelectionChanged);
            this.grdMain.SelectionChanged += new System.EventHandler(this.grdMain_SelectionChanged);
            this.grdDetail.SelectionChanged += grdDetail_SelectionChanged;

           

            this.grdlaboratory_SelectionChanged(sender, e);
            this.grdMain_SelectionChanged(sender, e);
            this.grdMaster_SelectionChanged(sender, e);
        }

        private void grdDetail_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdDetail.CurrentRow != null) && (this.grdDetail.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpDetail.Text = this.grdDetail.CurrentRow.Cells["DetailName"].Value.ToString();
            }
            else
            {
                this.grpDetail.Text = "";
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
               this.grdDetail.Enabled = true;
           }
           else
           {
               this.grp_Lab.Text = "";
               this.grdMain.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMain.RootTable.Columns["LaboratoryCode_MainTest"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
               this.grdMain.Enabled = false;
               this.grdMaster.Enabled = false;
               this.grdDetail.Enabled = false;
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
                this.grdDetail.Enabled = true;
            }
            else
            {
                this.grpMain.Text = "";
                this.grdMaster.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdMaster.RootTable.Columns["MainTestCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdMaster.Enabled = false;
                this.grdDetail.Enabled = false;
            }
            this.grdMaster.MoveFirst();
        }

        private void grdMaster_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdMaster.CurrentRow != null) && (this.grdMaster.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {

                this.grpmaster.Text = this.grdMaster.CurrentRow.Cells["MasterName"].Value.ToString();
                this.grdDetail.RootTable.Columns["MasterTestCode_Detail"].DefaultValue = this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value;
                this.grdDetail.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdDetail.RootTable.Columns["MasterTestCode_Detail"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdMaster.CurrentRow.Cells["MasterTestCode"].Value));
                this.grdDetail.Enabled = true;
                
            }
            else
            {
                this.grpmaster.Text = "";
                this.grdDetail.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdDetail.RootTable.Columns["MasterTestCode_Detail"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                this.grdDetail.Enabled = false;
            }
            this.grdDetail.MoveFirst();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.labList1.Update();
            this.mainTestList1.Update();
            this.masterTestList1.Update();
            this.detailTestList1.Update();

        }

        private void grdMaster_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }
    }
}
