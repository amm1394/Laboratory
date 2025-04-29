namespace RASF.Main.Forms.Financial
{
    partial class CompanyWorkFlowWithDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyWorkFlowWithDate));
            Janus.Windows.GridEX.GridEXLayout grdWorkFlow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpWorkFlow = new RASF.General.Controls.GroupBox();
            this.grdWorkFlow = new RASF.General.Controls.Grid();
            this.companyWorkFlowBaseOfPeymentCostomerList1 = new RASF.General.Lists.companyWorkFlowBaseOfPeymentCostomerList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).BeginInit();
            this.grpWorkFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 585);
            this.pnlButton.Size = new System.Drawing.Size(1021, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpWorkFlow);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1021, 585);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(816, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(899, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(961, 0);
            // 
            // grpWorkFlow
            // 
            this.grpWorkFlow.Controls.Add(this.grdWorkFlow);
            this.grpWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWorkFlow.Location = new System.Drawing.Point(0, 57);
            this.grpWorkFlow.Name = "grpWorkFlow";
            this.grpWorkFlow.Size = new System.Drawing.Size(1021, 528);
            this.grpWorkFlow.TabIndex = 1;
            this.grpWorkFlow.Text = "گردش کار";
            this.grpWorkFlow.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWorkFlow
            // 
            this.grdWorkFlow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWorkFlow.AlowRetrieveStructure = false;
            this.grdWorkFlow.AlternatingColors = true;
            this.grdWorkFlow.BuiltInTextsData = resources.GetString("grdWorkFlow.BuiltInTextsData");
            this.grdWorkFlow.DataSource = this.companyWorkFlowBaseOfPeymentCostomerList1;
            this.grdWorkFlow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWorkFlow_DesignTimeLayout.LayoutString = resources.GetString("grdWorkFlow_DesignTimeLayout.LayoutString");
            this.grdWorkFlow.DesignTimeLayout = grdWorkFlow_DesignTimeLayout;
            this.grdWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkFlow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdWorkFlow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdWorkFlow.GroupByBoxVisible = false;
            this.grdWorkFlow.Location = new System.Drawing.Point(3, 17);
            this.grdWorkFlow.Name = "grdWorkFlow";
            this.grdWorkFlow.Size = new System.Drawing.Size(1015, 508);
            this.grdWorkFlow.TabIndex = 2;
            this.grdWorkFlow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWorkFlow.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWorkFlow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "محدوده زمانی صورت حساب";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(594, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 37);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // CompanyWorkFlowWithDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1021, 615);
            this.Name = "CompanyWorkFlowWithDate";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CompanyWorkFlow_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).EndInit();
            this.grpWorkFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpWorkFlow;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Grid grdWorkFlow;
        private General.Lists.companyWorkFlowBaseOfPeymentCostomerList companyWorkFlowBaseOfPeymentCostomerList1;
    }
}
