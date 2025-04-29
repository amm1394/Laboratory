namespace RASF.Main.Forms.Manager
{
    partial class Connector_PeapleRelatedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connector_PeapleRelatedForm));
            Janus.Windows.GridEX.GridEXLayout grdcompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.connector_PeapleRelatedList1 = new RASF.General.Lists.Connector_PeapleRelatedList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdcompany = new RASF.General.Controls.Grid();
            this.txtInfo = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 525);
            this.pnlButton.Size = new System.Drawing.Size(933, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(933, 525);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(728, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(811, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(873, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "ورود اطلاعات";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdcompany);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "شرکت ها";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompany
            // 
            this.grdcompany.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdcompany.AlowRetrieveStructure = false;
            this.grdcompany.AlternatingColors = true;
            this.grdcompany.BuiltInTextsData = resources.GetString("grdcompany.BuiltInTextsData");
            this.grdcompany.DataSource = this.connector_PeapleRelatedList1;
            this.grdcompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompany_DesignTimeLayout.LayoutString = resources.GetString("grdcompany_DesignTimeLayout.LayoutString");
            this.grdcompany.DesignTimeLayout = grdcompany_DesignTimeLayout;
            this.grdcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcompany.GroupByBoxVisible = false;
            this.grdcompany.Location = new System.Drawing.Point(3, 17);
            this.grdcompany.Name = "grdcompany";
            this.grdcompany.RecordNavigator = true;
            this.grdcompany.Size = new System.Drawing.Size(927, 264);
            this.grdcompany.TabIndex = 0;
            this.grdcompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcompany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcompany_ColumnButtonClick);
            this.grdcompany.SelectionChanged += new System.EventHandler(this.grdcompany_SelectionChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.connector_PeapleRelatedList1, "Description", true));
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 17);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(927, 221);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // Connector_PeapleRelatedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(933, 555);
            this.Name = "Connector_PeapleRelatedForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Connector_PeapleRelatedForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Lists.Connector_PeapleRelatedList connector_PeapleRelatedList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdcompany;
        private General.Controls.TextBox txtInfo;
    }
}
