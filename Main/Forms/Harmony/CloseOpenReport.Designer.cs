namespace RASF.Main.Forms.Harmony
{
    partial class CloseOpenReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseOpenReport));
            Janus.Windows.GridEX.GridEXLayout grdView_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdView = new RASF.General.Controls.Grid();
            this.closeOpenReportList1 = new RASF.General.Lists.CloseOpenReportList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 403);
            this.pnlButton.Size = new System.Drawing.Size(1087, 24);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, -3);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, -3);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpMaster);
            this.pnlContent.Size = new System.Drawing.Size(1087, 403);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 0);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(882, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(83, 24);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(965, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 24);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1027, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 24);
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.grdView);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Location = new System.Drawing.Point(0, 0);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1087, 403);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdView
            // 
            this.grdView.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdView.AlowRetrieveStructure = false;
            this.grdView.AlternatingColors = true;
            this.grdView.BuiltInTextsData = resources.GetString("grdView.BuiltInTextsData");
            this.grdView.DataSource = this.closeOpenReportList1;
            this.grdView.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdView_DesignTimeLayout.LayoutString = resources.GetString("grdView_DesignTimeLayout.LayoutString");
            this.grdView.DesignTimeLayout = grdView_DesignTimeLayout;
            this.grdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdView.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdView.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdView.GroupByBoxVisible = false;
            this.grdView.Location = new System.Drawing.Point(3, 8);
            this.grdView.Name = "grdView";
            this.grdView.Size = new System.Drawing.Size(1081, 392);
            this.grdView.TabIndex = 0;
            this.grdView.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdView.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdView.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdView_ColumnButtonClick);
            // 
            // CloseOpenReport
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1087, 427);
            this.Name = "CloseOpenReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "باز کردن گزارشات";
            this.Load += new System.EventHandler(this.CloseOpenReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpMaster;
        private RASF.General.Controls.Grid grdView;
        private General.Lists.CloseOpenReportList closeOpenReportList1;
    }
}
