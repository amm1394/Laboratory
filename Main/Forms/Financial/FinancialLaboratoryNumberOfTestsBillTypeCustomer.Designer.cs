namespace RASF.Main.Forms.Financial
{
    partial class FinancialLaboratoryNumberOfTestsBillTypeCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialLaboratoryNumberOfTestsBillTypeCustomer));
            Janus.Windows.GridEX.GridEXLayout grdKol_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdKol = new RASF.General.Controls.Grid();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDetail = new RASF.General.Controls.Grid();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.financialLaboratoryNumberOfTestsBillTypeCustomerList1 = new RASF.General.Lists.FinancialLaboratoryNumberOfTestsBillTypeCustomerList(this.components);
            this.financialLaboratoryNumberOfTestsBillDetaileList1 = new RASF.General.Lists.FinancialLaboratoryNumberOfTestsBillDetaileList(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 541);
            this.pnlButton.Size = new System.Drawing.Size(1118, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(1118, 541);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(913, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(996, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1058, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1118, 491);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdKol);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "کارکرد تعدادی آزمایشگاه ها (نوع همکاری مشتری)";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdKol
            // 
            this.grdKol.AlowRetrieveStructure = false;
            this.grdKol.AlternatingColors = true;
            this.grdKol.BuiltInTextsData = resources.GetString("grdKol.BuiltInTextsData");
            this.grdKol.DataSource = this.financialLaboratoryNumberOfTestsBillTypeCustomerList1;
            this.grdKol.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdKol_DesignTimeLayout.LayoutString = resources.GetString("grdKol_DesignTimeLayout.LayoutString");
            this.grdKol.DesignTimeLayout = grdKol_DesignTimeLayout;
            this.grdKol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKol.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdKol.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdKol.GroupByBoxVisible = false;
            this.grdKol.Location = new System.Drawing.Point(3, 17);
            this.grdKol.Name = "grdKol";
            this.grdKol.RecordNavigator = true;
            this.grdKol.Size = new System.Drawing.Size(517, 471);
            this.grdKol.TabIndex = 0;
            this.grdKol.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdKol.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdKol.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdKol.SelectionChanged += new System.EventHandler(this.grdKol_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 491);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "جزئیات آزمونهای کارکرد تعدادی آزمایشگاه ها (نوع همکاری مشتری)";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDetail
            // 
            this.grdDetail.AlowRetrieveStructure = false;
            this.grdDetail.AlternatingColors = true;
            this.grdDetail.BuiltInTextsData = resources.GetString("grdDetail.BuiltInTextsData");
            this.grdDetail.DataSource = this.financialLaboratoryNumberOfTestsBillDetaileList1;
            this.grdDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetail_DesignTimeLayout.LayoutString = resources.GetString("grdDetail_DesignTimeLayout.LayoutString");
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDetail.GroupByBoxVisible = false;
            this.grdDetail.Location = new System.Drawing.Point(3, 17);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RecordNavigator = true;
            this.grdDetail.Size = new System.Drawing.Size(585, 471);
            this.grdDetail.TabIndex = 1;
            this.grdDetail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1118, 50);
            this.grpDate.TabIndex = 2;
            this.grpDate.Text = "تاریخ صورت حساب";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(691, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // FinancialLaboratoryNumberOfTestsBillTypeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 571);
            this.Name = "FinancialLaboratoryNumberOfTestsBillTypeCustomer";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "FinancialLaboratoryNumberOfTestsBillTypeCustomer";
            this.Load += new System.EventHandler(this.FinancialLaboratoryNumberOfTestsBillTypeCustomer_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdKol;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDetail;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.FinancialLaboratoryNumberOfTestsBillTypeCustomerList financialLaboratoryNumberOfTestsBillTypeCustomerList1;
        private General.Lists.FinancialLaboratoryNumberOfTestsBillDetaileList financialLaboratoryNumberOfTestsBillDetaileList1;
    }
}