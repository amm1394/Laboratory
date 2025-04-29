using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class AddStandardForm : RASF.General.Forms.Base.DockContentForm
    {
        public AddStandardForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStandardForm_Load(object sender, EventArgs e)
        {
            FillGrid();

        }

        private void FillGrid()
        {
            this.standard_BaseList1.Fill();
            this.standard_NamesList1.Fill();
            this.standard_DataList1.Fill();

            this.grdBase.Refetch();
            this.grdName.Refetch();
            this.grdData.Refetch();
        }

        private void grdBase_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdBase.CurrentRow != null) && (this.grdBase.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpBase.Text = this.grdBase.CurrentRow.Cells["Name"].Value.ToString();
                this.grdName.RootTable.Columns["StandardBaseCode"].DefaultValue = this.grdBase.CurrentRow.Cells["Code"].Value;
                this.grdName.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdName.RootTable.Columns["StandardBaseCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdBase.CurrentRow.Cells["Code"].Value));
             
            }
            else
            {
                this.grpBase.Text = "";
                this.grdName.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdName.RootTable.Columns["StandardBaseCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                
            }
            //this.grdName.MoveFirst();
        }

        private void grdName_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdName.CurrentRow != null) && (this.grdName.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpName.Text = this.grdName.CurrentRow.Cells["Name"].Value.ToString();
                this.grdData.RootTable.Columns["StandardNameCode"].DefaultValue = this.grdName.CurrentRow.Cells["Code"].Value;
                this.grdData.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdData.RootTable.Columns["StandardNameCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdName.CurrentRow.Cells["Code"].Value));
               
            }
            else
            {
                this.grpName.Text = "";
                this.grdData.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdData.RootTable.Columns["StandardNameCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
         
            }
          //  this.grdData.MoveFirst();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.standard_BaseList1.Update();
            this.standard_NamesList1.Update();
            this.standard_DataList1.Update();

            FillGrid();
        }
    }
}
