namespace RASF.Main.Forms.Harmony
{
    partial class WageofagencyPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WageofagencyPay));
            Janus.Windows.GridEX.GridEXLayout grdWage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdWage = new RASF.General.Controls.Grid();
            this.wageofagencyPayList1 = new RASF.General.Lists.WageofagencyPayList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 577);
            this.pnlButton.Size = new System.Drawing.Size(741, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(741, 577);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(536, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(619, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(681, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdWage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش پرداختی های کسر از کارمزد دفاتر";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWage
            // 
            this.grdWage.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWage.AlowRetrieveStructure = false;
            this.grdWage.AlternatingColors = true;
            this.grdWage.BuiltInTextsData = resources.GetString("grdWage.BuiltInTextsData");
            this.grdWage.DataSource = this.wageofagencyPayList1;
            this.grdWage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWage_DesignTimeLayout.LayoutString = resources.GetString("grdWage_DesignTimeLayout.LayoutString");
            this.grdWage.DesignTimeLayout = grdWage_DesignTimeLayout;
            this.grdWage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWage.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdWage.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdWage.GroupByBoxVisible = false;
            this.grdWage.Location = new System.Drawing.Point(3, 17);
            this.grdWage.Name = "grdWage";
            this.grdWage.Size = new System.Drawing.Size(735, 557);
            this.grdWage.TabIndex = 0;
            this.grdWage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWage.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdWage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // WageofagencyPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(741, 607);
            this.Name = "WageofagencyPay";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.WageofagencyPay_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdWage;
        private General.Lists.WageofagencyPayList wageofagencyPayList1;
    }
}
