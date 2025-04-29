namespace RASF.Main.Forms.Marketing
{
    partial class ReportMarketingOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMarketingOperation));
            Janus.Windows.GridEX.GridEXLayout grdreport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.reportMarketingOperationList1 = new RASF.General.Lists.ReportMarketingOperationList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdreport = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdreport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 563);
            this.pnlButton.Size = new System.Drawing.Size(1102, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1102, 563);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(897, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(980, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1042, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "محدوده زمانی (تاریخ اقدام)";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(675, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1102, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "توضیحات";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reportMarketingOperationList1, "Description", true));
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(3, 17);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(1096, 80);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdreport);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 417);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.Text = "عملکرد بازاریابی";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010;
            // 
            // grdreport
            // 
            this.grdreport.AlowRetrieveStructure = false;
            this.grdreport.AlternatingColors = true;
            this.grdreport.BuiltInTextsData = resources.GetString("grdreport.BuiltInTextsData");
            this.grdreport.DataSource = this.reportMarketingOperationList1;
            this.grdreport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdreport_DesignTimeLayout.LayoutString = resources.GetString("grdreport_DesignTimeLayout.LayoutString");
            this.grdreport.DesignTimeLayout = grdreport_DesignTimeLayout;
            this.grdreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdreport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdreport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdreport.GroupByBoxVisible = false;
            this.grdreport.Location = new System.Drawing.Point(3, 17);
            this.grdreport.Name = "grdreport";
            this.grdreport.RecordNavigator = true;
            this.grdreport.Size = new System.Drawing.Size(1096, 397);
            this.grdreport.TabIndex = 0;
            this.grdreport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdreport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportMarketingOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 593);
            this.Name = "ReportMarketingOperation";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReportMarketingOperation";
            this.Load += new System.EventHandler(this.ReportMarketingOperation_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdreport;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TextBox txtDesc;
        private General.Lists.ReportMarketingOperationList reportMarketingOperationList1;
    }
}