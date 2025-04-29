using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class InspectCompany : RASF.General.Forms.Base.DockContentForm
    {
        public InspectCompany()
        {
            InitializeComponent();
        }

        private void InspectCompany_Load(object sender, EventArgs e)
        {
            this.companyOfInspectList1.Fill();
            this.grdInspect.Refetch();
            this.inspectorList1.Fill();
            this.grdInspector.Refetch();


            this.grdInspect.SelectionChanged += new System.EventHandler(this.grdInspect_SelectionChanged);
            this.grdInspector.SelectionChanged += new System.EventHandler(this.grdInspector_SelectionChanged);

        }

        private void grdInspect_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdInspect_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdInspect.CurrentRow != null) && (this.grdInspect.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpInspect.Text = this.grdInspect.CurrentRow.Cells["InspectName"].Value.ToString();
                this.grdInspector.RootTable.Columns["InspectCode"].DefaultValue = this.grdInspect.CurrentRow.Cells["InspectCode"].Value;
                this.grdInspector.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdInspector.RootTable.Columns["InspectCode"], Janus.Windows.GridEX.ConditionOperator.Equal, this.grdInspect.CurrentRow.Cells["InspectCode"].Value));
                //this.grdInspector.Enabled = true;
                //this.grdMaster.Enabled = true;
                //this.grdDetail.Enabled = true;
            }
            else
            {
                this.grpInspect.Text = "";
                this.grdInspector.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdInspector.RootTable.Columns["InspectCode"], Janus.Windows.GridEX.ConditionOperator.Equal, Guid.NewGuid()));
                //this.grdMain.Enabled = false;
                //this.grdMaster.Enabled = false;
                //this.grdDetail.Enabled = false;
            }
            this.grdInspector.MoveFirst();          
        }

        private void grdInspector_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdInspector.CurrentRow != null) && (this.grdInspector.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpInspector.Text = this.grdInspector.CurrentRow.Cells["InspectorName"].Value.ToString();
            }
            else
            {
                this.grpInspector.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companyOfInspectList1.Update();
            this.inspectorList1.Update();

            this.companyOfInspectList1.Fill();
            this.grdInspect.Refetch();

            this.inspectorList1.Fill();
            this.grdInspector.Refetch();
                        
        }
    }
}
