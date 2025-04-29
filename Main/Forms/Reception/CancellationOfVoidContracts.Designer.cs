namespace RASF.Main.Forms.Reception
{
    partial class CancellationOfVoidContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancellationOfVoidContracts));
            Janus.Windows.GridEX.GridEXLayout grdVoidContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.showVoidContractsList1 = new RASF.General.Lists.ShowVoidContractsList(this.components);
            this.grdVoidContracts = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoidContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 552);
            this.pnlButton.Size = new System.Drawing.Size(1136, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdVoidContracts);
            this.pnlContent.Size = new System.Drawing.Size(1136, 552);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1591, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1014, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1076, 0);
            // 
            // grdVoidContracts
            // 
            this.grdVoidContracts.AlowRetrieveStructure = false;
            this.grdVoidContracts.AlternatingColors = true;
            this.grdVoidContracts.BuiltInTextsData = resources.GetString("grdVoidContracts.BuiltInTextsData");
            this.grdVoidContracts.DataSource = this.showVoidContractsList1;
            this.grdVoidContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdVoidContracts_DesignTimeLayout.LayoutString = resources.GetString("grdVoidContracts_DesignTimeLayout.LayoutString");
            this.grdVoidContracts.DesignTimeLayout = grdVoidContracts_DesignTimeLayout;
            this.grdVoidContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVoidContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdVoidContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdVoidContracts.GroupByBoxVisible = false;
            this.grdVoidContracts.Location = new System.Drawing.Point(0, 0);
            this.grdVoidContracts.Name = "grdVoidContracts";
            this.grdVoidContracts.Size = new System.Drawing.Size(1136, 552);
            this.grdVoidContracts.TabIndex = 0;
            this.grdVoidContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdVoidContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdVoidContracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdVoidContracts_ColumnButtonClick);
            // 
            // CancellationOfVoidContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 582);
            this.Name = "CancellationOfVoidContracts";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CancellationOfVoidContracts";
            this.Load += new System.EventHandler(this.CancellationOfVoidContracts_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVoidContracts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.ShowVoidContractsList showVoidContractsList1;
        private RASF.General.Controls.Grid grdVoidContracts;
    }
}