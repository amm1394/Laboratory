namespace RASF.Main.Forms.Reception
{
    partial class IsCompletedForCancelToExiteReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsCompletedForCancelToExiteReport));
            Janus.Windows.GridEX.GridEXLayout grdIsCompleted_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdIsCompleted = new RASF.General.Controls.Grid();
            this.iscompletedForCancelToExitList1 = new RASF.General.Lists.IscompletedForCancelToExitList(this.components);
            this.partsMasterSendEmailList1 = new RASF.General.Lists.PartsMasterSendEmailList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIsCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 548);
            this.pnlButton.Size = new System.Drawing.Size(1258, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1258, 548);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1053, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1136, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1198, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdIsCompleted);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdIsCompleted
            // 
            this.grdIsCompleted.AlowRetrieveStructure = false;
            this.grdIsCompleted.AlternatingColors = true;
            this.grdIsCompleted.BuiltInTextsData = resources.GetString("grdIsCompleted.BuiltInTextsData");
            this.grdIsCompleted.DataSource = this.iscompletedForCancelToExitList1;
            this.grdIsCompleted.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdIsCompleted_DesignTimeLayout.LayoutString = resources.GetString("grdIsCompleted_DesignTimeLayout.LayoutString");
            this.grdIsCompleted.DesignTimeLayout = grdIsCompleted_DesignTimeLayout;
            this.grdIsCompleted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdIsCompleted.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdIsCompleted.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdIsCompleted.GroupByBoxVisible = false;
            this.grdIsCompleted.Location = new System.Drawing.Point(3, 8);
            this.grdIsCompleted.Name = "grdIsCompleted";
            this.grdIsCompleted.Size = new System.Drawing.Size(1252, 537);
            this.grdIsCompleted.TabIndex = 0;
            this.grdIsCompleted.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdIsCompleted.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdIsCompleted.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdIsCompleted_FormattingRow);
            // 
            // IsCompletedForCancelToExiteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1258, 578);
            this.Name = "IsCompletedForCancelToExiteReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.IsCompletedForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIsCompleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdIsCompleted;
        private General.Lists.IscompletedForCancelToExitList iscompletedForCancelToExitList1;
        private General.Lists.PartsMasterSendEmailList partsMasterSendEmailList1;
    }
}
