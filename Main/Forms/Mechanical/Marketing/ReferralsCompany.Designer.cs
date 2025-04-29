namespace RASF.Main.Forms.Marketing
{
    partial class ReferralsCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferralsCompany));
            Janus.Windows.GridEX.GridEXLayout grdCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdCompany = new RASF.General.Controls.Grid();
            this.referralsCompanyList1 = new RASF.General.Lists.ReferralsCompanyList(this.components);
            this.connectorOfCompaniesList1 = new RASF.General.Lists.ConnectorOfCompaniesList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatePickerReceptionDate = new FarsiLibrary.Win.Controls.FADatePicker();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.splitContainer2);
            this.pnlButton.Location = new System.Drawing.Point(0, 569);
            this.pnlButton.Size = new System.Drawing.Size(834, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.splitContainer2, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "ذخیره در EX";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(834, 569);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(629, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(712, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(774, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCompany);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "ارجاع شرکت ها";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompany
            // 
            this.grdCompany.AlowRetrieveStructure = false;
            this.grdCompany.AlternatingColors = true;
            this.grdCompany.BuiltInTextsData = resources.GetString("grdCompany.BuiltInTextsData");
            this.grdCompany.DataSource = this.referralsCompanyList1;
            this.grdCompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompany_DesignTimeLayout.LayoutString = resources.GetString("grdCompany_DesignTimeLayout.LayoutString");
            this.grdCompany.DesignTimeLayout = grdCompany_DesignTimeLayout;
            this.grdCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompany.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompany.GroupByBoxVisible = false;
            this.grdCompany.Location = new System.Drawing.Point(3, 17);
            this.grdCompany.Name = "grdCompany";
            this.grdCompany.Size = new System.Drawing.Size(828, 504);
            this.grdCompany.TabIndex = 0;
            this.grdCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompany.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCompany_FormattingRow);
            this.grdCompany.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCompany_ColumnButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
            this.groupBox2.Location = new System.Drawing.Point(0, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "تاریخ ارجاع";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatePickerReceptionDate);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(834, 25);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 12;
            // 
            // DatePickerReceptionDate
            // 
            this.DatePickerReceptionDate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedDateTime", this.referralsCompanyList1, "ReferralDate", true));
            this.DatePickerReceptionDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.DatePickerReceptionDate.IsNull = false;
            this.DatePickerReceptionDate.Location = new System.Drawing.Point(24, 0);
            this.DatePickerReceptionDate.Name = "DatePickerReceptionDate";
            this.DatePickerReceptionDate.SelectedDateTime = new System.DateTime(2018, 6, 9, 0, 0, 0, 0);
            this.DatePickerReceptionDate.Size = new System.Drawing.Size(250, 25);
            this.DatePickerReceptionDate.TabIndex = 11;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(629, 30);
            this.splitContainer2.SplitterDistance = 521;
            this.splitContainer2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Goldenrod;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(13, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "اهمیت بالا";
            // 
            // ReferralsCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(834, 599);
            this.Name = "ReferralsCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReferralsCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdCompany;
        private RASF.General.Lists.ReferralsCompanyList referralsCompanyList1;
        private RASF.General.Lists.ConnectorOfCompaniesList connectorOfCompaniesList1;
        private General.Controls.GroupBox groupBox2;
        protected FarsiLibrary.Win.Controls.FADatePicker DatePickerReceptionDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private General.Controls.Label label4;
    }
}
