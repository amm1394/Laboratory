namespace RASF.Main.Forms.WorkFlow
{
    partial class EnterScience_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterScience_Form));
            Janus.Windows.GridEX.GridEXLayout grdContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grpcontract = new RASF.General.Controls.GroupBox();
            this.grdContract = new RASF.General.Controls.Grid();
            this.contractsForWorkFlowList1 = new RASF.General.Lists.ContractsForWorkFlowList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpcontract)).BeginInit();
            this.grpcontract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 660);
            this.pnlButton.Size = new System.Drawing.Size(1339, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "رد";
            // 
            // btnSave
            // 
            this.btnSave.Text = "تایید";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlContent.Size = new System.Drawing.Size(1339, 660);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1134, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1217, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1279, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpcontract);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1339, 660);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpcontract
            // 
            this.grpcontract.Controls.Add(this.grdContract);
            this.grpcontract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpcontract.Location = new System.Drawing.Point(3, 8);
            this.grpcontract.Name = "grpcontract";
            this.grpcontract.Size = new System.Drawing.Size(1333, 649);
            this.grpcontract.TabIndex = 1;
            this.grpcontract.Text = "قرارداد";
            this.grpcontract.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContract
            // 
            this.grdContract.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContract.AlowRetrieveStructure = false;
            this.grdContract.AlternatingColors = true;
            this.grdContract.BuiltInTextsData = resources.GetString("grdContract.BuiltInTextsData");
            this.grdContract.DataSource = this.contractsForWorkFlowList1;
            this.grdContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContract_DesignTimeLayout.LayoutString = resources.GetString("grdContract_DesignTimeLayout.LayoutString");
            this.grdContract.DesignTimeLayout = grdContract_DesignTimeLayout;
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContract.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContract.GroupByBoxVisible = false;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Name = "grdContract";
            this.grdContract.RecordNavigator = true;
            this.grdContract.Size = new System.Drawing.Size(1327, 629);
            this.grdContract.TabIndex = 0;
            this.grdContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // EnterScience_Form
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1339, 690);
            this.Name = "EnterScience_Form";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.EnterScience_Form_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpcontract)).EndInit();
            this.grpcontract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox grpcontract;
        private General.Controls.Grid grdContract;
        private General.Lists.ContractsForWorkFlowList contractsForWorkFlowList1;
    }
}
