namespace RASF.Main.Forms.ContractsReport
{
    partial class ViewRegisteredReportSamene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRegisteredReportSamene));
            Janus.Windows.GridEX.GridEXLayout grdcontracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdcontracts = new RASF.General.Controls.Grid();
            this.viewSabtSamaneList1 = new RASF.General.Lists.ViewSabtSamaneList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 489);
            this.pnlButton.Size = new System.Drawing.Size(890, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(890, 489);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(685, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(768, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(830, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdcontracts);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "مشاهده قراردادهایی که در سامانه ثبت شده اند";
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
            this.grdcontracts.Size = new System.Drawing.Size(884, 469);
            this.grdcontracts.TabIndex = 0;
            this.grdcontracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcontracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcontracts_ColumnButtonClick);
            // 
            // ViewRegisteredReportSamene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Name = "ViewRegisteredReportSamene";
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
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdcontracts;
        private RASF.General.Lists.ViewSabtSamaneList viewSabtSamaneList1;
    }
}