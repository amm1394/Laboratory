namespace RASF.Main.Forms.ContractsReport
{
    partial class RecieptionLongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecieptionLongForm));
            Janus.Windows.GridEX.GridEXLayout grdRecieptionLong_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdRecieptionLongTest_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.recieptionLongList1 = new RASF.General.Lists.RecieptionLongList(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdRecieptionLong = new RASF.General.Controls.Grid();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdRecieptionLongTest = new RASF.General.Controls.Grid();
            this.recieptionLongIsHoldTestList1 = new RASF.General.Lists.RecieptionLongIsHoldTestList(this.components);
            this.label11 = new RASF.General.Controls.Label();
            this.label10 = new RASF.General.Controls.Label();
            this.label9 = new RASF.General.Controls.Label();
            this.label8 = new RASF.General.Controls.Label();
            this.label5 = new RASF.General.Controls.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdRecieptionLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecieptionLongTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 644);
            this.pnlButton.Size = new System.Drawing.Size(1218, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "پرینت";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1218, 644);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1013, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1096, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1158, 0);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.gridEXPrintDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // gridEXPrintDocument1
            // 
            this.gridEXPrintDocument1.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns;
            this.gridEXPrintDocument1.PageHeaderCenter = "پذیرش های طولانی";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1218, 644);
            this.splitContainer1.SplitterDistance = 1121;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdRecieptionLong);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1121, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "پذیرش طولانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdRecieptionLong
            // 
            this.grdRecieptionLong.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdRecieptionLong.AlowRetrieveStructure = false;
            this.grdRecieptionLong.AlternatingColors = true;
            this.grdRecieptionLong.BuiltInTextsData = resources.GetString("grdRecieptionLong.BuiltInTextsData");
            this.grdRecieptionLong.DataSource = this.recieptionLongList1;
            this.grdRecieptionLong.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRecieptionLong_DesignTimeLayout.LayoutString = resources.GetString("grdRecieptionLong_DesignTimeLayout.LayoutString");
            this.grdRecieptionLong.DesignTimeLayout = grdRecieptionLong_DesignTimeLayout;
            this.grdRecieptionLong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecieptionLong.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdRecieptionLong.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdRecieptionLong.GroupByBoxVisible = false;
            this.grdRecieptionLong.Location = new System.Drawing.Point(3, 17);
            this.grdRecieptionLong.Name = "grdRecieptionLong";
            this.grdRecieptionLong.RecordNavigator = true;
            this.grdRecieptionLong.Size = new System.Drawing.Size(1115, 300);
            this.grdRecieptionLong.TabIndex = 0;
            this.grdRecieptionLong.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRecieptionLong.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdRecieptionLong.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdRecieptionLong_FormattingRow);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdRecieptionLongTest);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1121, 324);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "پذیرش طولانی قراردادهای تست در حضور یا مسئله دار";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdRecieptionLongTest
            // 
            this.grdRecieptionLongTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdRecieptionLongTest.AlowRetrieveStructure = false;
            this.grdRecieptionLongTest.AlternatingColors = true;
            this.grdRecieptionLongTest.BuiltInTextsData = resources.GetString("grdRecieptionLongTest.BuiltInTextsData");
            this.grdRecieptionLongTest.DataSource = this.recieptionLongIsHoldTestList1;
            this.grdRecieptionLongTest.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRecieptionLongTest_DesignTimeLayout.LayoutString = resources.GetString("grdRecieptionLongTest_DesignTimeLayout.LayoutString");
            this.grdRecieptionLongTest.DesignTimeLayout = grdRecieptionLongTest_DesignTimeLayout;
            this.grdRecieptionLongTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecieptionLongTest.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdRecieptionLongTest.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdRecieptionLongTest.GroupByBoxVisible = false;
            this.grdRecieptionLongTest.Location = new System.Drawing.Point(3, 17);
            this.grdRecieptionLongTest.Name = "grdRecieptionLongTest";
            this.grdRecieptionLongTest.RecordNavigator = true;
            this.grdRecieptionLongTest.Size = new System.Drawing.Size(1115, 304);
            this.grdRecieptionLongTest.TabIndex = 0;
            this.grdRecieptionLongTest.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRecieptionLongTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdRecieptionLongTest.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdRecieptionLongTest_FormattingRow);
            this.grdRecieptionLongTest.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdRecieptionLongTest_LoadingRow);
            this.grdRecieptionLongTest.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdContracts_ColumnButtonClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "علل تخریب";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "خوردگی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(5, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "میکروسکوپ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Titr", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "عملکرد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "مشتری جدید";
            // 
            // RecieptionLongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1218, 674);
            this.Name = "RecieptionLongForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "پذیرش طولانی";
            this.Load += new System.EventHandler(this.RecieptionLongForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecieptionLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecieptionLongTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Lists.RecieptionLongList recieptionLongList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdRecieptionLongTest;
        private General.Controls.Label label11;
        private General.Controls.Label label10;
        private General.Controls.Label label9;
        private General.Controls.Label label8;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdRecieptionLong;
        private General.Lists.RecieptionLongIsHoldTestList recieptionLongIsHoldTestList1;
        private General.Controls.Label label5;
    }
}
