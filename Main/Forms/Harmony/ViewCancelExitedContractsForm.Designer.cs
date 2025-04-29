namespace RASF.Main.Forms.Harmony
{
    partial class ViewCancelExitedContractsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCancelExitedContractsForm));
            Janus.Windows.GridEX.GridEXLayout grdCancelExited_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCancelExited = new RASF.General.Controls.Grid();
            this.reasonOfCancelToExitList1 = new RASF.General.Lists.ReasonOfCancelToExitList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelExited)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(797, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCancelExited);
            this.pnlContent.Size = new System.Drawing.Size(797, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(590, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(675, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(737, 0);
            // 
            // grdCancelExited
            // 
            this.grdCancelExited.AlowRetrieveStructure = false;
            this.grdCancelExited.AlternatingColors = true;
            this.grdCancelExited.BuiltInTextsData = resources.GetString("grdCancelExited.BuiltInTextsData");
            this.grdCancelExited.DataSource = this.reasonOfCancelToExitList1;
            this.grdCancelExited.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCancelExited_DesignTimeLayout.LayoutString = resources.GetString("grdCancelExited_DesignTimeLayout.LayoutString");
            this.grdCancelExited.DesignTimeLayout = grdCancelExited_DesignTimeLayout;
            this.grdCancelExited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCancelExited.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCancelExited.GroupByBoxVisible = false;
            this.grdCancelExited.Hierarchical = true;
            this.grdCancelExited.Location = new System.Drawing.Point(0, 0);
            this.grdCancelExited.Name = "grdCancelExited";
            this.grdCancelExited.Size = new System.Drawing.Size(797, 396);
            this.grdCancelExited.TabIndex = 0;
            this.grdCancelExited.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCancelExited.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ViewCancelExitedContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 426);
            this.Name = "ViewCancelExitedContractsForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CancelIsHoldForm";
            this.Load += new System.EventHandler(this.CancelIsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelExited)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdCancelExited;
        private General.Lists.ReasonOfCancelToExitList reasonOfCancelToExitList1;
    }
}