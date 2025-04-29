namespace RASF.Main.Forms.Base
{
    partial class InsertInspectCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertInspectCompany));
            this.grpContract = new RASF.General.Controls.GroupBox();
            this.grdContract = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContract)).BeginInit();
            this.grpContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 548);
            this.pnlButton.Size = new System.Drawing.Size(724, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpContract);
            this.pnlContent.Size = new System.Drawing.Size(724, 548);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(519, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(602, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(664, 0);
            // 
            // grpContract
            // 
            this.grpContract.Controls.Add(this.grdContract);
            this.grpContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContract.Location = new System.Drawing.Point(0, 0);
            this.grpContract.Name = "grpContract";
            this.grpContract.Size = new System.Drawing.Size(724, 548);
            this.grpContract.TabIndex = 0;
            this.grpContract.Text = "groupBox1";
            this.grpContract.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContract
            // 
            this.grdContract.AlowRetrieveStructure = true;
            this.grdContract.AlternatingColors = true;
            this.grdContract.BuiltInTextsData = resources.GetString("grdContract.BuiltInTextsData");
            this.grdContract.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.grdContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContract.GroupByBoxVisible = false;
            this.grdContract.Location = new System.Drawing.Point(3, 17);
            this.grdContract.Name = "grdContract";
            this.grdContract.Size = new System.Drawing.Size(718, 528);
            this.grdContract.TabIndex = 0;
            this.grdContract.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // InsertInspectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(724, 578);
            this.Name = "InsertInspectCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContract)).EndInit();
            this.grpContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpContract;
        private General.Controls.Grid grdContract;
    }
}
