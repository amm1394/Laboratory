namespace RASF.Main.Forms.Financial
{
    partial class DifferenceInvoiceContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DifferenceInvoiceContract));
            Janus.Windows.GridEX.GridEXLayout grdDiffrence_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.differenceInvoiceContractList1 = new RASF.General.Lists.DifferenceInvoiceContractList(this.components);
            this.grdDiffrence = new RASF.General.Controls.Grid();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gridEXPrintDocument1 = new RASF.General.Controls.GridEXPrintDocument();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiffrence)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 565);
            this.pnlButton.Size = new System.Drawing.Size(1053, 30);
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
            this.pnlContent.Controls.Add(this.grdDiffrence);
            this.pnlContent.Size = new System.Drawing.Size(1053, 565);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(848, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(931, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(993, 0);
            // 
            // grdDiffrence
            // 
            this.grdDiffrence.AlowRetrieveStructure = false;
            this.grdDiffrence.AlternatingColors = true;
            this.grdDiffrence.BuiltInTextsData = resources.GetString("grdDiffrence.BuiltInTextsData");
            this.grdDiffrence.DataSource = this.differenceInvoiceContractList1;
            this.grdDiffrence.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDiffrence_DesignTimeLayout.LayoutString = resources.GetString("grdDiffrence_DesignTimeLayout.LayoutString");
            this.grdDiffrence.DesignTimeLayout = grdDiffrence_DesignTimeLayout;
            this.grdDiffrence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDiffrence.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDiffrence.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDiffrence.GroupByBoxVisible = false;
            this.grdDiffrence.Location = new System.Drawing.Point(0, 0);
            this.grdDiffrence.Name = "grdDiffrence";
            this.grdDiffrence.RecordNavigator = true;
            this.grdDiffrence.Size = new System.Drawing.Size(1053, 565);
            this.grdDiffrence.TabIndex = 0;
            this.grdDiffrence.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDiffrence.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDiffrence.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
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
            this.gridEXPrintDocument1.GridEX = this.grdDiffrence;
            this.gridEXPrintDocument1.PageHeaderCenter = "اختلاف مبالغ صورت حساب ها و قراردادها";
            this.gridEXPrintDocument1.PageHeaderFormatStyle.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold);
            this.gridEXPrintDocument1.PageHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
            this.gridEXPrintDocument1.PageHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            // 
            // DifferenceInvoiceContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1053, 595);
            this.Name = "DifferenceInvoiceContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "اختلاف مبالغ صورت حساب ها و قراردادها";
            this.Load += new System.EventHandler(this.DifferenceInvoiceContract_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDiffrence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.DifferenceInvoiceContractList differenceInvoiceContractList1;
        private General.Controls.Grid grdDiffrence;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private General.Controls.GridEXPrintDocument gridEXPrintDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}
