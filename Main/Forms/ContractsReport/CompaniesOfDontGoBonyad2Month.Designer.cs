namespace RASF.Main.Forms.ContractsReport
{
    partial class CompaniesOfDontGoBonyad2Month
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
            Janus.Windows.GridEX.GridEXLayout grdconnector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesOfDontGoBonyad2Month));
            Janus.Windows.GridEX.GridEXLayout grdCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdconnector = new RASF.General.Controls.Grid();
            this.companiesOfDontGoBonyad2MonthList1 = new RASF.General.Lists.CompaniesOfDontGoBonyad2MonthList(this.components);
            this.grpMonth = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.btnSea = new RASF.General.Controls.Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.grp = new RASF.General.Controls.GroupBox();
            this.grdCompany = new RASF.General.Controls.Grid();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.label5 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdconnector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMonth)).BeginInit();
            this.grpMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp)).BeginInit();
            this.grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 615);
            this.pnlButton.Size = new System.Drawing.Size(1303, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "چاپ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grp);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(1303, 615);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1098, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1181, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1243, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdconnector);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 563);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "لیست رابطین";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdconnector
            // 
            this.grdconnector.AlowRetrieveStructure = false;
            this.grdconnector.AlternatingColors = true;
            this.grdconnector.BuiltInTextsData = resources.GetString("grdconnector.BuiltInTextsData");
            this.grdconnector.DataSource = this.companiesOfDontGoBonyad2MonthList1;
            this.grdconnector.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdconnector_DesignTimeLayout.LayoutString = resources.GetString("grdconnector_DesignTimeLayout.LayoutString");
            this.grdconnector.DesignTimeLayout = grdconnector_DesignTimeLayout;
            this.grdconnector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdconnector.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdconnector.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdconnector.GroupByBoxVisible = false;
            this.grdconnector.Location = new System.Drawing.Point(3, 16);
            this.grdconnector.Name = "grdconnector";
            this.grdconnector.RecordNavigator = true;
            this.grdconnector.Size = new System.Drawing.Size(797, 544);
            this.grdconnector.TabIndex = 0;
            this.grdconnector.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdconnector.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdconnector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.btnSearch);
            this.grpMonth.Controls.Add(this.textBox1);
            this.grpMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMonth.Location = new System.Drawing.Point(0, 0);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(803, 52);
            this.grpMonth.TabIndex = 1;
            this.grpMonth.Text = "مقدار ماه";
            this.grpMonth.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.Location = new System.Drawing.Point(647, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Location = new System.Drawing.Point(743, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSea);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "جستجو بر حسب ماه";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSea
            // 
            this.btnSea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSea.Location = new System.Drawing.Point(1144, 25);
            this.btnSea.Name = "btnSea";
            this.btnSea.Size = new System.Drawing.Size(75, 23);
            this.btnSea.TabIndex = 1;
            this.btnSea.Text = "جستجو";
            this.btnSea.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSea.Click += new System.EventHandler(this.btnSea_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.Location = new System.Drawing.Point(1225, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(66, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "2";
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.grdCompany);
            this.grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp.Location = new System.Drawing.Point(0, 61);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(1303, 554);
            this.grp.TabIndex = 1;
            this.grp.Text = "شرکت هایی که بیش از چند ماه نیامده اند";
            this.grp.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCompany
            // 
            this.grdCompany.AlowRetrieveStructure = false;
            this.grdCompany.AlternatingColors = true;
            this.grdCompany.BuiltInTextsData = resources.GetString("grdCompany.BuiltInTextsData");
            this.grdCompany.DataSource = this.companiesOfDontGoBonyad2MonthList1;
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
            this.grdCompany.Size = new System.Drawing.Size(1297, 534);
            this.grdCompany.TabIndex = 0;
            this.grdCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompany.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompany.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCompany_FormattingRow);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
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
            this.gridEXPrintDocument1.GridEX = this.grdCompany;
            this.gridEXPrintDocument1.PageHeaderCenter = "شرکت هایی که بیش از چند ماه به بنیاد مراجعه نکرده اند";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "مشتری جدید";
            // 
            // CompaniesOfDontGoBonyad2Month
            // 
            this.AcceptButton = this.btnSea;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1303, 645);
            this.Name = "CompaniesOfDontGoBonyad2Month";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ShowVoidedContracts_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdconnector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMonth)).EndInit();
            this.grpMonth.ResumeLayout(false);
            this.grpMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp)).EndInit();
            this.grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdconnector;
        private General.Lists.CompaniesOfDontGoBonyad2MonthList companiesOfDontGoBonyad2MonthList1;
        private General.Controls.GroupBox grpMonth;
        private General.Controls.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Button btnSea;
        private General.Controls.TextBox txtSearch;
        private General.Controls.GroupBox grp;
        private General.Controls.Grid grdCompany;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private General.Controls.Label label5;

    }
}
