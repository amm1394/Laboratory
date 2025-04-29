namespace RASF.Main.Forms.Harmony
{
    partial class Reportingdelays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportingdelays));
            Janus.Windows.GridEX.GridEXLayout grdDelay_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDelay = new RASF.General.Controls.GroupBox();
            this.grdDelay = new RASF.General.Controls.Grid();
            this.reportingDelayList1 = new RASF.General.Lists.ReportingDelayList(this.components);
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDelay)).BeginInit();
            this.grpDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 560);
            this.pnlButton.Size = new System.Drawing.Size(953, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(953, 560);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(746, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(831, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(893, 0);
            // 
            // grpDelay
            // 
            this.grpDelay.Controls.Add(this.grdDelay);
            this.grpDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDelay.Location = new System.Drawing.Point(0, 50);
            this.grpDelay.Name = "grpDelay";
            this.grpDelay.Size = new System.Drawing.Size(953, 510);
            this.grpDelay.TabIndex = 2;
            this.grpDelay.Text = "گزارش کارهای تاخیری";
            this.grpDelay.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDelay
            // 
            this.grdDelay.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelay.AlowRetrieveStructure = false;
            this.grdDelay.AlternatingColors = true;
            this.grdDelay.BuiltInTextsData = resources.GetString("grdDelay.BuiltInTextsData");
            this.grdDelay.DataSource = this.reportingDelayList1;
            this.grdDelay.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelay_DesignTimeLayout.LayoutString = resources.GetString("grdDelay_DesignTimeLayout.LayoutString");
            this.grdDelay.DesignTimeLayout = grdDelay_DesignTimeLayout;
            this.grdDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelay.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDelay.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelay.GroupByBoxVisible = false;
            this.grdDelay.Location = new System.Drawing.Point(3, 17);
            this.grdDelay.Name = "grdDelay";
            this.grdDelay.Size = new System.Drawing.Size(947, 490);
            this.grdDelay.TabIndex = 0;
            this.grdDelay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDelay.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDelay_ColumnButtonClick);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(953, 50);
            this.grpDate.TabIndex = 5;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(526, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // Reportingdelays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(953, 590);
            this.Controls.Add(this.grpDelay);
            this.Controls.Add(this.grpDate);
            this.Name = "Reportingdelays";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Reportingdelays_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grpDate, 0);
            this.Controls.SetChildIndex(this.grpDelay, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDelay)).EndInit();
            this.grpDelay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDelay;
        private General.Controls.Grid grdDelay;
        private General.Lists.ReportingDelayList reportingDelayList1;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
    }
}
