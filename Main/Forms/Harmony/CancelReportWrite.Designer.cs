namespace RASF.Main.Forms.Harmony
{
    partial class CancelReportWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelReportWrite));
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdReciptHistory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBoxInvoice = new RASF.General.Controls.GroupBox();
            this.grdReport = new RASF.General.Controls.Grid();
            this.cancelReportWriteList1 = new RASF.General.Lists.CancelReportWriteList(this.components);
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpMali = new RASF.General.Controls.GroupBox();
            this.grdReciptHistory = new RASF.General.Controls.Grid();
            this.yes_NoList1 = new RASF.General.Lists.Yes_NoList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).BeginInit();
            this.groupBoxInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMali)).BeginInit();
            this.grpMali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReciptHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 617);
            this.pnlButton.Size = new System.Drawing.Size(1197, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBoxInvoice);
            this.pnlContent.Controls.Add(this.groupBox6);
            this.pnlContent.Size = new System.Drawing.Size(1197, 617);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(992, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1075, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1137, 0);
            // 
            // groupBoxInvoice
            // 
            this.groupBoxInvoice.Controls.Add(this.grdReport);
            this.groupBoxInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInvoice.Location = new System.Drawing.Point(0, 43);
            this.groupBoxInvoice.Name = "groupBoxInvoice";
            this.groupBoxInvoice.Size = new System.Drawing.Size(1197, 574);
            this.groupBoxInvoice.TabIndex = 2;
            this.groupBoxInvoice.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReport
            // 
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.cancelReportWriteList1;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 8);
            this.grdReport.Name = "grdReport";
            this.grdReport.RecordNavigator = true;
            this.grdReport.Size = new System.Drawing.Size(1191, 563);
            this.grdReport.TabIndex = 0;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdReport.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdReport_ColumnButtonClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContract1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1197, 43);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(965, 8);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 32);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpMali
            // 
            this.grpMali.Controls.Add(this.grdReciptHistory);
            this.grpMali.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMali.Location = new System.Drawing.Point(702, 302);
            this.grpMali.Name = "grpMali";
            this.grpMali.Size = new System.Drawing.Size(527, 321);
            this.grpMali.TabIndex = 6;
            this.grpMali.Text = "تاریخچه پرداخت ها";
            this.grpMali.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReciptHistory
            // 
            this.grdReciptHistory.AlowRetrieveStructure = false;
            this.grdReciptHistory.AlternatingColors = true;
            this.grdReciptHistory.BuiltInTextsData = resources.GetString("grdReciptHistory.BuiltInTextsData");
            this.grdReciptHistory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReciptHistory_DesignTimeLayout.LayoutString = resources.GetString("grdReciptHistory_DesignTimeLayout.LayoutString");
            this.grdReciptHistory.DesignTimeLayout = grdReciptHistory_DesignTimeLayout;
            this.grdReciptHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReciptHistory.GroupByBoxVisible = false;
            this.grdReciptHistory.Location = new System.Drawing.Point(3, 16);
            this.grdReciptHistory.Name = "grdReciptHistory";
            this.grdReciptHistory.Size = new System.Drawing.Size(521, 302);
            this.grdReciptHistory.TabIndex = 1;
            this.grdReciptHistory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // CancelReportWrite
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1197, 647);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CancelReportWrite";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CancelReportWrite_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBoxInvoice)).EndInit();
            this.groupBoxInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMali)).EndInit();
            this.grpMali.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReciptHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected RASF.General.Controls.GroupBox groupBoxInvoice;
        private General.Controls.GroupBox grpMali;
        private General.Controls.Grid grdReciptHistory;
        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContract searchContract1;
        private General.Controls.Grid grdReport;
        private General.Lists.CancelReportWriteList cancelReportWriteList1;
        private General.Lists.Yes_NoList yes_NoList1;
    }
}
