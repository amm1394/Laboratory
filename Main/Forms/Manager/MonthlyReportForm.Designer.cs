namespace RASF.Main.Forms.Manager
{
    partial class MonthlyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyReportForm));
            Janus.Windows.GridEX.GridEXLayout grdreport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.monthlyReportList1 = new RASF.General.Lists.MonthlyReportList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdreport = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdreport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 437);
            this.pnlButton.Size = new System.Drawing.Size(827, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(827, 437);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(622, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(705, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(767, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdreport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش ماهانه";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdreport
            // 
            this.grdreport.AlowRetrieveStructure = false;
            this.grdreport.AlternatingColors = true;
            this.grdreport.BuiltInTextsData = resources.GetString("grdreport.BuiltInTextsData");
            this.grdreport.DataSource = this.monthlyReportList1;
            this.grdreport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdreport_DesignTimeLayout.LayoutString = resources.GetString("grdreport_DesignTimeLayout.LayoutString");
            this.grdreport.DesignTimeLayout = grdreport_DesignTimeLayout;
            this.grdreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdreport.GroupByBoxVisible = false;
            this.grdreport.Location = new System.Drawing.Point(3, 17);
            this.grdreport.Name = "grdreport";
            this.grdreport.Size = new System.Drawing.Size(821, 417);
            this.grdreport.TabIndex = 0;
            this.grdreport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdreport.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdreport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // MonthlyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(827, 467);
            this.Name = "MonthlyReportForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "گزارش ماهانه";
            this.Load += new System.EventHandler(this.MonthlyReportForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.MonthlyReportList monthlyReportList1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdreport;
    }
}
