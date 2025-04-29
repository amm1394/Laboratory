namespace RASF.Main.Forms.WorkFlow
{
    partial class showWorkFlowDescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showWorkFlowDescription));
            Janus.Windows.GridEX.GridEXLayout grdWorkFlow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdWorkFlow = new RASF.General.Controls.Grid();
            this.showWorkFlowDescriptionList1 = new RASF.General.Lists.ShowWorkFlowDescriptionList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 298);
            this.pnlButton.Size = new System.Drawing.Size(896, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(896, 298);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(691, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(774, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(836, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdWorkFlow);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "گردش کار";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWorkFlow
            // 
            this.grdWorkFlow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWorkFlow.AlowRetrieveStructure = false;
            this.grdWorkFlow.AlternatingColors = true;
            this.grdWorkFlow.BuiltInTextsData = resources.GetString("grdWorkFlow.BuiltInTextsData");
            this.grdWorkFlow.DataSource = this.showWorkFlowDescriptionList1;
            this.grdWorkFlow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWorkFlow_DesignTimeLayout.LayoutString = resources.GetString("grdWorkFlow_DesignTimeLayout.LayoutString");
            this.grdWorkFlow.DesignTimeLayout = grdWorkFlow_DesignTimeLayout;
            this.grdWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkFlow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdWorkFlow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdWorkFlow.GroupByBoxVisible = false;
            this.grdWorkFlow.Location = new System.Drawing.Point(3, 17);
            this.grdWorkFlow.Name = "grdWorkFlow";
            this.grdWorkFlow.Size = new System.Drawing.Size(890, 278);
            this.grdWorkFlow.TabIndex = 3;
            this.grdWorkFlow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWorkFlow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // showWorkFlowDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 328);
            this.Name = "showWorkFlowDescription";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "showWorkFlowDescription";
            this.Load += new System.EventHandler(this.showWorkFlowDescription_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdWorkFlow;
        private General.Lists.ShowWorkFlowDescriptionList showWorkFlowDescriptionList1;
    }
}