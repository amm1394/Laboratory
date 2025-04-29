namespace RASF.Main.Forms.ContractsReport
{
    partial class DeliveryDayForMagement
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
            Janus.Windows.GridEX.GridEXLayout grdDelay_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryDayForMagement));
            Janus.Windows.GridEX.GridEXLayout grdHold_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.deliveryDayForMagementList1 = new RASF.General.Lists.DeliveryDayForMagementList(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.grdDelay = new RASF.General.Controls.Grid();
            this.deliveryDayForMagementList2 = new RASF.General.Lists.DeliveryDayForMagementList(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label5 = new RASF.General.Controls.Label();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdHold = new RASF.General.Controls.Grid();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.button1 = new RASF.General.Controls.Button();
            this.gridEXPrintDocument2 = new RASF.General.Controls.GridEXPrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHold)).BeginInit();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.button1);
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 613);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            this.pnlButton.Controls.SetChildIndex(this.button1, 0);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(8, 4);
            this.btnExit.Size = new System.Drawing.Size(78, 23);
            this.btnExit.Text = "پرینت تاخیری";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(1276, 613);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 7);
            this.btnUpdate.Size = new System.Drawing.Size(77, 23);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1035, 0);
            this.pnlUpdate.Size = new System.Drawing.Size(92, 30);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1127, 0);
            this.pnlExit.Size = new System.Drawing.Size(89, 30);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
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
            this.gridEXPrintDocument1.GridEX = this.grdDelay;
            this.gridEXPrintDocument1.PageHeaderCenter = "گزارش کارهای تاخیری";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // grdDelay
            // 
            this.grdDelay.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelay.AlowRetrieveStructure = false;
            this.grdDelay.AlternatingColors = true;
            this.grdDelay.BuiltInTextsData = resources.GetString("grdDelay.BuiltInTextsData");
            this.grdDelay.DataSource = this.deliveryDayForMagementList2;
            this.grdDelay.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelay_DesignTimeLayout.LayoutString = resources.GetString("grdDelay_DesignTimeLayout.LayoutString");
            this.grdDelay.DesignTimeLayout = grdDelay_DesignTimeLayout;
            this.grdDelay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelay.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDelay.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelay.GroupByBoxVisible = false;
            this.grdDelay.Location = new System.Drawing.Point(3, 17);
            this.grdDelay.Name = "grdDelay";
            this.grdDelay.RecordNavigator = true;
            this.grdDelay.Size = new System.Drawing.Size(1266, 569);
            this.grdDelay.TabIndex = 0;
            this.grdDelay.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelay.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDelay.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDelay.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdDelay_FormattingRow);
            this.grdDelay.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDelay_ColumnButtonClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1276, 613);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1272, 589);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "قراردادهای مساله دار";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdHold);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1272, 589);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "قراردادهای مساله دار";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdHold
            // 
            this.grdHold.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdHold.AlowRetrieveStructure = false;
            this.grdHold.AlternatingColors = true;
            this.grdHold.BuiltInTextsData = resources.GetString("grdHold.BuiltInTextsData");
            this.grdHold.DataSource = this.deliveryDayForMagementList1;
            this.grdHold.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdHold_DesignTimeLayout.LayoutString = resources.GetString("grdHold_DesignTimeLayout.LayoutString");
            this.grdHold.DesignTimeLayout = grdHold_DesignTimeLayout;
            this.grdHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdHold.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdHold.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdHold.GroupByBoxVisible = false;
            this.grdHold.Location = new System.Drawing.Point(3, 17);
            this.grdHold.Name = "grdHold";
            this.grdHold.RecordNavigator = true;
            this.grdHold.Size = new System.Drawing.Size(1266, 569);
            this.grdHold.TabIndex = 0;
            this.grdHold.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdHold.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdHold.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdHold.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdDelivery_FormattingRow);
            this.grdHold.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdHold_ColumnButtonClick);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox3);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(1272, 589);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "قراردادهای تاخیری";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdDelay);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1272, 589);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "قراردادهای تاخیری";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(929, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "پرینت مساله دارها";
            this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridEXPrintDocument2
            // 
            this.gridEXPrintDocument2.FitColumns = Janus.Windows.GridEX.FitColumnsMode.SizingColumns;
            this.gridEXPrintDocument2.GridEX = this.grdHold;
            this.gridEXPrintDocument2.PageHeaderCenter = "گزارش کارهای مساله دار";
            this.gridEXPrintDocument2.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument2.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument2.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.gridEXPrintDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog1";
            this.printPreviewDialog2.ShowIcon = false;
            this.printPreviewDialog2.Visible = false;
            // 
            // DeliveryDayForMagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 643);
            this.Name = "DeliveryDayForMagement";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "کارهای مسئله دار و تاخیری";
            this.Load += new System.EventHandler(this.DeliveryDayForMagement_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHold)).EndInit();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.DeliveryDayForMagementList deliveryDayForMagementList1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Controls.Label label5;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdHold;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid grdDelay;
        private General.Lists.DeliveryDayForMagementList deliveryDayForMagementList2;
        private General.Controls.Button button1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
    }
}
