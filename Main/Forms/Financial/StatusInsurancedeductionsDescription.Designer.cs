namespace RASF.Main.Forms.Financial
{
    partial class StatusInsurancedeductionsDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusInsurancedeductionsDescription));
            Janus.Windows.GridEX.GridEXLayout grdTypeDeductions_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grp2 = new RASF.General.Controls.GroupBox();
            this.grdTypeDeductions = new RASF.General.Controls.Grid();
            this.companiesCooperationTypeList1 = new RASF.General.Lists.CompaniesCooperationTypeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp2)).BeginInit();
            this.grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTypeDeductions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 476);
            this.pnlButton.Size = new System.Drawing.Size(539, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grp2);
            this.pnlContent.Size = new System.Drawing.Size(539, 476);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(334, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(417, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(479, 0);
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.grdTypeDeductions);
            this.grp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp2.Location = new System.Drawing.Point(0, 0);
            this.grp2.Name = "grp2";
            this.grp2.Size = new System.Drawing.Size(539, 476);
            this.grp2.TabIndex = 3;
            this.grp2.Text = "وضعیت کسورات بیمه";
            this.grp2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdTypeDeductions
            // 
            this.grdTypeDeductions.AlowRetrieveStructure = false;
            this.grdTypeDeductions.AlternatingColors = true;
            this.grdTypeDeductions.BuiltInTextsData = resources.GetString("grdTypeDeductions.BuiltInTextsData");
            this.grdTypeDeductions.DataSource = this.companiesCooperationTypeList1;
            this.grdTypeDeductions.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdTypeDeductions_DesignTimeLayout.LayoutString = resources.GetString("grdTypeDeductions_DesignTimeLayout.LayoutString");
            this.grdTypeDeductions.DesignTimeLayout = grdTypeDeductions_DesignTimeLayout;
            this.grdTypeDeductions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTypeDeductions.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTypeDeductions.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTypeDeductions.GroupByBoxVisible = false;
            this.grdTypeDeductions.Location = new System.Drawing.Point(3, 17);
            this.grdTypeDeductions.Name = "grdTypeDeductions";
            this.grdTypeDeductions.RecordNavigator = true;
            this.grdTypeDeductions.Size = new System.Drawing.Size(533, 456);
            this.grdTypeDeductions.TabIndex = 0;
            this.grdTypeDeductions.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTypeDeductions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // StatusInsurancedeductionsDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 506);
            this.Name = "StatusInsurancedeductionsDescription";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "StatusInsurancedeductionsDescription";
            this.Load += new System.EventHandler(this.StatusInsurancedeductionsDescription_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grp2)).EndInit();
            this.grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTypeDeductions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grp2;
        private General.Controls.Grid grdTypeDeductions;
        private General.Lists.CompaniesCooperationTypeList companiesCooperationTypeList1;
    }
}