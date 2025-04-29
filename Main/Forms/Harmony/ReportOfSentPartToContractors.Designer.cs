namespace RASF.Main.Forms.Harmony
{
    partial class ReportOfSentPartToContractors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfSentPartToContractors));
            Janus.Windows.GridEX.GridEXLayout grdcontractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpContractors = new RASF.General.Controls.GroupBox();
            this.grdcontractors = new RASF.General.Controls.Grid();
            this.sentPartToContractorsReportList1 = new RASF.General.Lists.SentPartToContractorsReportList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).BeginInit();
            this.grpContractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 565);
            this.pnlButton.Size = new System.Drawing.Size(1194, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpContractors);
            this.pnlContent.Size = new System.Drawing.Size(1194, 565);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(989, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1072, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1134, 0);
            // 
            // grpContractors
            // 
            this.grpContractors.Controls.Add(this.grdcontractors);
            this.grpContractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContractors.Location = new System.Drawing.Point(0, 0);
            this.grpContractors.Name = "grpContractors";
            this.grpContractors.Size = new System.Drawing.Size(1194, 565);
            this.grpContractors.TabIndex = 1;
            this.grpContractors.Text = "انتخاب پیمانکاران";
            this.grpContractors.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcontractors
            // 
            this.grdcontractors.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdcontractors.AlowRetrieveStructure = false;
            this.grdcontractors.AlternatingColors = true;
            this.grdcontractors.BuiltInTextsData = resources.GetString("grdcontractors.BuiltInTextsData");
            this.grdcontractors.DataSource = this.sentPartToContractorsReportList1;
            this.grdcontractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcontractors_DesignTimeLayout.LayoutString = resources.GetString("grdcontractors_DesignTimeLayout.LayoutString");
            this.grdcontractors.DesignTimeLayout = grdcontractors_DesignTimeLayout;
            this.grdcontractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcontractors.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcontractors.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcontractors.GroupByBoxVisible = false;
            this.grdcontractors.Hierarchical = true;
            this.grdcontractors.Location = new System.Drawing.Point(3, 17);
            this.grdcontractors.Name = "grdcontractors";
            this.grdcontractors.RecordNavigator = true;
            this.grdcontractors.Size = new System.Drawing.Size(1188, 545);
            this.grdcontractors.TabIndex = 0;
            this.grdcontractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportOfSentPartToContractors
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 595);
            this.Name = "ReportOfSentPartToContractors";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Tag = "گزارش کارهای پیمانکاران";
            this.Text = "گزارش کارهای پیمانکاران";
            this.Load += new System.EventHandler(this.RequestOfConstractors_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).EndInit();
            this.grpContractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpContractors;
        private General.Lists.SentPartToContractorsReportList sentPartToContractorsReportList1;
        private General.Controls.Grid grdcontractors;
    }
}