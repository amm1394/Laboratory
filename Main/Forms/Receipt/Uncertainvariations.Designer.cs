namespace RASF.Main.Forms.Receipt
{
    partial class Uncertainvariations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uncertainvariations));
            Janus.Windows.GridEX.GridEXLayout grdAmount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new RASF.General.Controls.Label();
            this.DatePickerReciept = new FarsiLibrary.Win.Controls.FADatePicker();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.labAmount = new RASF.General.Controls.Label();
            this.txtAmount = new RASF.General.Controls.TextBox();
            this.labNo = new RASF.General.Controls.Label();
            this.txtRecieptNo = new RASF.General.Controls.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdAmount = new RASF.General.Controls.Grid();
            this.uncertainvariationsList1 = new RASF.General.Lists.UncertainvariationsList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.grdCompany = new RASF.General.Controls.Grid();
            this.companiesBaseList1 = new RASF.General.Lists.CompaniesBaseList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 614);
            this.pnlButton.Size = new System.Drawing.Size(1359, 30);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 4);
            this.btnExit.Size = new System.Drawing.Size(59, 23);
            this.btnExit.Text = "بروزرسانی";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1359, 614);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "ذخیره در EX";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1237, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1299, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1359, 614);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1359, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "ذخیره اطلاعات";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 17);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.DatePickerReciept);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(1353, 97);
            this.splitContainer3.SplitterDistance = 437;
            this.splitContainer3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "تاریخ حواله";
            // 
            // DatePickerReciept
            // 
            this.DatePickerReciept.IsNull = false;
            this.DatePickerReciept.Location = new System.Drawing.Point(170, 44);
            this.DatePickerReciept.Name = "DatePickerReciept";
            this.DatePickerReciept.SelectedDateTime = new System.DateTime(2014, 3, 15, 0, 0, 0, 0);
            this.DatePickerReciept.Size = new System.Drawing.Size(145, 20);
            this.DatePickerReciept.TabIndex = 10;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.labAmount);
            this.splitContainer4.Panel1.Controls.Add(this.txtAmount);
            this.splitContainer4.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.labNo);
            this.splitContainer4.Panel2.Controls.Add(this.txtRecieptNo);
            this.splitContainer4.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer4.Size = new System.Drawing.Size(912, 97);
            this.splitContainer4.SplitterDistance = 462;
            this.splitContainer4.TabIndex = 0;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.Location = new System.Drawing.Point(304, 41);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(54, 13);
            this.labAmount.TabIndex = 12;
            this.labAmount.Text = "مبلغ حواله";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(87, 38);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.Size = new System.Drawing.Size(211, 21);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // labNo
            // 
            this.labNo.AutoSize = true;
            this.labNo.Location = new System.Drawing.Point(305, 35);
            this.labNo.Name = "labNo";
            this.labNo.Size = new System.Drawing.Size(64, 13);
            this.labNo.TabIndex = 12;
            this.labNo.Text = "شماره حواله";
            this.labNo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRecieptNo
            // 
            this.txtRecieptNo.Location = new System.Drawing.Point(94, 33);
            this.txtRecieptNo.Name = "txtRecieptNo";
            this.txtRecieptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRecieptNo.Size = new System.Drawing.Size(205, 21);
            this.txtRecieptNo.TabIndex = 1;
            this.txtRecieptNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtRecieptNo.Leave += new System.EventHandler(this.txtRecieptNo_Leave);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(1359, 493);
            this.splitContainer2.SplitterDistance = 660;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdAmount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 493);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "گزارش واریزی های نا مشخص";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAmount
            // 
            this.grdAmount.AlowRetrieveStructure = false;
            this.grdAmount.AlternatingColors = true;
            this.grdAmount.BuiltInTextsData = resources.GetString("grdAmount.BuiltInTextsData");
            this.grdAmount.DataSource = this.uncertainvariationsList1;
            this.grdAmount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAmount_DesignTimeLayout.LayoutString = resources.GetString("grdAmount_DesignTimeLayout.LayoutString");
            this.grdAmount.DesignTimeLayout = grdAmount_DesignTimeLayout;
            this.grdAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAmount.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdAmount.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdAmount.GroupByBoxVisible = false;
            this.grdAmount.Location = new System.Drawing.Point(3, 17);
            this.grdAmount.Name = "grdAmount";
            this.grdAmount.RecordNavigator = true;
            this.grdAmount.Size = new System.Drawing.Size(654, 473);
            this.grdAmount.TabIndex = 0;
            this.grdAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAmount.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdCompany);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(695, 493);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.Text = "شرکت ها";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompany
            // 
            this.grdCompany.AlowRetrieveStructure = false;
            this.grdCompany.AlternatingColors = true;
            this.grdCompany.BuiltInTextsData = resources.GetString("grdCompany.BuiltInTextsData");
            this.grdCompany.DataSource = this.companiesBaseList1;
            this.grdCompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompany_DesignTimeLayout.LayoutString = resources.GetString("grdCompany_DesignTimeLayout.LayoutString");
            this.grdCompany.DesignTimeLayout = grdCompany_DesignTimeLayout;
            this.grdCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompany.GroupByBoxVisible = false;
            this.grdCompany.Location = new System.Drawing.Point(3, 17);
            this.grdCompany.Name = "grdCompany";
            this.grdCompany.RecordNavigator = true;
            this.grdCompany.Size = new System.Drawing.Size(689, 473);
            this.grdCompany.TabIndex = 1;
            this.grdCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCompany_ColumnButtonClick);
            // 
            // Uncertainvariations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 644);
            this.Name = "Uncertainvariations";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Uncertainvariations";
            this.Load += new System.EventHandler(this.Uncertainvariations_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private General.Controls.Label label1;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerReciept;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private General.Controls.Label labAmount;
        private General.Controls.TextBox txtAmount;
        private General.Controls.Label labNo;
        private General.Controls.TextBox txtRecieptNo;
        private General.Controls.Grid grdAmount;
        private General.Controls.Grid grdCompany;
        private General.Lists.UncertainvariationsList uncertainvariationsList1;
        private General.Lists.CompaniesBaseList companiesBaseList1;
    }
}