namespace RASF.Main.Forms.Marketing
{
    partial class RegidterMarketingActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegidterMarketingActivity));
            Janus.Windows.GridEX.GridEXLayout grdcompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdcompany = new RASF.General.Controls.Grid();
            this.marketingActivityList1 = new RASF.General.Lists.MarketingActivityList(this.components);
            this.DatePickerReceptionDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.groupBox5 = new RASF.General.Controls.GroupBox();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.trackingStatusMarketingList1 = new RASF.General.Lists.TrackingStatusMarketingList(this.components);
            this.label3 = new RASF.General.Controls.Label();
            this.label1 = new RASF.General.Controls.Label();
            this.label4 = new RASF.General.Controls.Label();
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label4);
            this.pnlButton.Controls.Add(this.label3);
            this.pnlButton.Controls.Add(this.label1);
            this.pnlButton.Location = new System.Drawing.Point(0, 522);
            this.pnlButton.Size = new System.Drawing.Size(880, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label1, 0);
            this.pnlButton.Controls.SetChildIndex(this.label3, 0);
            this.pnlButton.Controls.SetChildIndex(this.label4, 0);
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
            this.pnlContent.Size = new System.Drawing.Size(880, 522);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(675, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(758, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(820, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdcompany);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "شرکت ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcompany
            // 
            this.grdcompany.AlowRetrieveStructure = false;
            this.grdcompany.AlternatingColors = true;
            this.grdcompany.BuiltInTextsData = resources.GetString("grdcompany.BuiltInTextsData");
            this.grdcompany.DataSource = this.marketingActivityList1;
            this.grdcompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcompany_DesignTimeLayout.LayoutString = resources.GetString("grdcompany_DesignTimeLayout.LayoutString");
            this.grdcompany.DesignTimeLayout = grdcompany_DesignTimeLayout;
            this.grdcompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdcompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdcompany.GroupByBoxVisible = false;
            this.grdcompany.Location = new System.Drawing.Point(3, 17);
            this.grdcompany.Name = "grdcompany";
            this.grdcompany.RecordNavigator = true;
            this.grdcompany.Size = new System.Drawing.Size(874, 227);
            this.grdcompany.TabIndex = 0;
            this.grdcompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcompany.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdcompany_FormattingRow);
            this.grdcompany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcompany_ColumnButtonClick);
            // 
            // DatePickerReceptionDate
            // 
            this.DatePickerReceptionDate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.marketingActivityList1, "DateWork", true));
            this.DatePickerReceptionDate.IsNull = false;
            this.DatePickerReceptionDate.Location = new System.Drawing.Point(149, 16);
            this.DatePickerReceptionDate.Name = "DatePickerReceptionDate";
            this.DatePickerReceptionDate.Size = new System.Drawing.Size(250, 20);
            this.DatePickerReceptionDate.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 57);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 8);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(874, 46);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DatePickerReceptionDate);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(498, 46);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.Text = "تاریخ انجام";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.faDatePicker1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(372, 46);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.Text = "تاریخ پیگیری";
            this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.marketingActivityList1, "TrackingDate", true));
            this.faDatePicker1.IsNull = false;
            this.faDatePicker1.Location = new System.Drawing.Point(58, 16);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(250, 20);
            this.faDatePicker1.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(880, 218);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marketingActivityList1, "Description", true));
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(3, 17);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(874, 198);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(408, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "پذیرش شده";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(523, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "تاخیر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(312, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "اهمیت بالا";
            // 
            // RegidterMarketingActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(880, 552);
            this.Name = "RegidterMarketingActivity";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.RegidterMarketingActivity_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox txtDesc;
        private General.Controls.GroupBox groupBox2;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerReceptionDate;
        private General.Controls.Grid grdcompany;
        private General.Lists.MarketingActivityList marketingActivityList1;
        private General.Lists.TrackingStatusMarketingList trackingStatusMarketingList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox4;
        private General.Controls.GroupBox groupBox5;
        protected FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private General.Controls.Label label3;
        private General.Controls.Label label1;
        private General.Controls.Label label4;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;
    }
}
