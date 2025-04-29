namespace RASF.Main.Forms.Financial
{
    partial class ShowOpenInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOpenInvoice));
            Janus.Windows.GridEX.GridEXLayout grdBill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpBill = new RASF.General.Controls.GroupBox();
            this.grdBill = new RASF.General.Controls.Grid();
            this.showOpenInvoiceList1 = new RASF.General.Lists.ShowOpenInvoiceList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpBill)).BeginInit();
            this.grpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 653);
            this.pnlButton.Size = new System.Drawing.Size(1156, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpBill);
            this.pnlContent.Size = new System.Drawing.Size(1156, 653);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(951, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1034, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1096, 0);
            // 
            // grpBill
            // 
            this.grpBill.Controls.Add(this.grdBill);
            this.grpBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBill.Location = new System.Drawing.Point(0, 0);
            this.grpBill.Name = "grpBill";
            this.grpBill.Size = new System.Drawing.Size(1156, 653);
            this.grpBill.TabIndex = 0;
            this.grpBill.Text = "صورت حساب های باز";
            this.grpBill.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBill
            // 
            this.grdBill.AlowRetrieveStructure = false;
            this.grdBill.AlternatingColors = true;
            this.grdBill.BuiltInTextsData = resources.GetString("grdBill.BuiltInTextsData");
            this.grdBill.DataSource = this.showOpenInvoiceList1;
            this.grdBill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBill_DesignTimeLayout.LayoutString = resources.GetString("grdBill_DesignTimeLayout.LayoutString");
            this.grdBill.DesignTimeLayout = grdBill_DesignTimeLayout;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.GroupByBoxVisible = false;
            this.grdBill.Location = new System.Drawing.Point(3, 17);
            this.grdBill.Name = "grdBill";
            this.grdBill.Size = new System.Drawing.Size(1150, 633);
            this.grdBill.TabIndex = 0;
            this.grdBill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdBill.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdBill_ColumnButtonClick);
            // 
            // ShowOpenInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1156, 683);
            this.Name = "ShowOpenInvoice";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ShowOpenInvoice_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpBill)).EndInit();
            this.grpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpBill;
        private General.Controls.Grid grdBill;
        private General.Lists.ShowOpenInvoiceList showOpenInvoiceList1;
    }
}
