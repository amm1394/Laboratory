namespace RASF.Main.Forms.Harmony
{
    partial class HoldContractNotCompleted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoldContractNotCompleted));
            Janus.Windows.GridEX.GridEXLayout grdHoldContract_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdHoldContract = new RASF.General.Controls.Grid();
            this.holdContractNotCompletedList1 = new RASF.General.Lists.HoldContractNotCompletedList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHoldContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 508);
            this.pnlButton.Size = new System.Drawing.Size(791, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdHoldContract);
            this.pnlContent.Size = new System.Drawing.Size(791, 508);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(2486, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(669, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(731, 0);
            // 
            // grdHoldContract
            // 
            this.grdHoldContract.AlowRetrieveStructure = false;
            this.grdHoldContract.AlternatingColors = true;
            this.grdHoldContract.BuiltInTextsData = resources.GetString("grdHoldContract.BuiltInTextsData");
            this.grdHoldContract.DataSource = this.holdContractNotCompletedList1;
            this.grdHoldContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdHoldContract_DesignTimeLayout.LayoutString = resources.GetString("grdHoldContract_DesignTimeLayout.LayoutString");
            this.grdHoldContract.DesignTimeLayout = grdHoldContract_DesignTimeLayout;
            this.grdHoldContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHoldContract.GroupByBoxVisible = false;
            this.grdHoldContract.Location = new System.Drawing.Point(0, 0);
            this.grdHoldContract.Name = "grdHoldContract";
            this.grdHoldContract.RecordNavigator = true;
            this.grdHoldContract.Size = new System.Drawing.Size(791, 508);
            this.grdHoldContract.TabIndex = 0;
            this.grdHoldContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdHoldContract.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // HoldContractNotCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 538);
            this.Name = "HoldContractNotCompleted";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "قراردادهای مسئله دارشده و خروج نخورده ";
            this.Load += new System.EventHandler(this.HoldContractNotCompleted_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHoldContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdHoldContract;
        private General.Lists.HoldContractNotCompletedList holdContractNotCompletedList1;
    }
}