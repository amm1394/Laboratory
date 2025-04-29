namespace RASF.Main.Forms.ContractsReport
{
    partial class ViewSabtSamane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSabtSamane));
            Janus.Windows.GridEX.GridEXLayout grdcontracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdcontracts = new RASF.General.Controls.Grid();
            this.viewSabtSamaneList1 = new RASF.General.Lists.ViewSabtSamaneList(this.components);
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtdesc = new RASF.General.Controls.TextBox();
            this.viewSabtSamaneList2 = new RASF.General.Lists.ViewSabtSamaneList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).BeginInit();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 367);
            this.pnlButton.Size = new System.Drawing.Size(788, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpText);
            this.pnlContent.Size = new System.Drawing.Size(788, 367);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(583, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(666, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(728, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdcontracts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = " ثبت در سامانه";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcontracts
            // 
            this.grdcontracts.AlowRetrieveStructure = false;
            this.grdcontracts.AlternatingColors = true;
            this.grdcontracts.BuiltInTextsData = resources.GetString("grdcontracts.BuiltInTextsData");
            this.grdcontracts.DataSource = this.viewSabtSamaneList1;
            this.grdcontracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcontracts_DesignTimeLayout.LayoutString = resources.GetString("grdcontracts_DesignTimeLayout.LayoutString");
            this.grdcontracts.DesignTimeLayout = grdcontracts_DesignTimeLayout;
            this.grdcontracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcontracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcontracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcontracts.GroupByBoxVisible = false;
            this.grdcontracts.Location = new System.Drawing.Point(3, 17);
            this.grdcontracts.Name = "grdcontracts";
            this.grdcontracts.RecordNavigator = true;
            this.grdcontracts.Size = new System.Drawing.Size(782, 265);
            this.grdcontracts.TabIndex = 0;
            this.grdcontracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcontracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcontracts_ColumnButtonClick);
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtdesc);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpText.Location = new System.Drawing.Point(0, 285);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(788, 82);
            this.grpText.TabIndex = 2;
            this.grpText.Text = "توضیحات";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtdesc
            // 
            this.txtdesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.viewSabtSamaneList2, "Description", true));
            this.txtdesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdesc.Location = new System.Drawing.Point(3, 17);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(782, 62);
            this.txtdesc.TabIndex = 0;
            this.txtdesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ViewSabtSamane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 397);
            this.Name = "ViewSabtSamane";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ViewSabtSamane";
            this.Load += new System.EventHandler(this.ViewSabtSamane_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcontracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdcontracts;
        private RASF.General.Lists.ViewSabtSamaneList viewSabtSamaneList1;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtdesc;
        private General.Lists.ViewSabtSamaneList viewSabtSamaneList2;
    }
}