namespace RASF.Main.Forms.Search
{
    partial class FindBillNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBillNo));
            Janus.Windows.GridEX.GridEXLayout grdBill_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpgrid = new RASF.General.Controls.GroupBox();
            this.grdBill = new RASF.General.Controls.Grid();
            this.findBillNumberList1 = new RASF.General.Lists.FindBillNumberList(this.components);
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).BeginInit();
            this.grpgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 435);
            this.pnlButton.Size = new System.Drawing.Size(1354, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpgrid);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(1354, 435);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1147, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1232, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1294, 0);
            // 
            // grpgrid
            // 
            this.grpgrid.Controls.Add(this.grdBill);
            this.grpgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpgrid.Location = new System.Drawing.Point(0, 51);
            this.grpgrid.Name = "grpgrid";
            this.grpgrid.Size = new System.Drawing.Size(1354, 384);
            this.grpgrid.TabIndex = 6;
            this.grpgrid.Text = "صورت حساب";
            this.grpgrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBill
            // 
            this.grdBill.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdBill.AlowRetrieveStructure = false;
            this.grdBill.AlternatingColors = true;
            this.grdBill.BuiltInTextsData = resources.GetString("grdBill.BuiltInTextsData");
            this.grdBill.DataSource = this.findBillNumberList1;
            this.grdBill.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBill_DesignTimeLayout.LayoutString = resources.GetString("grdBill_DesignTimeLayout.LayoutString");
            this.grdBill.DesignTimeLayout = grdBill_DesignTimeLayout;
            this.grdBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBill.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBill.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBill.GroupByBoxVisible = false;
            this.grdBill.Location = new System.Drawing.Point(3, 17);
            this.grdBill.Name = "grdBill";
            this.grdBill.Size = new System.Drawing.Size(1348, 364);
            this.grdBill.TabIndex = 0;
            this.grdBill.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBill.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdBill.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdBill_ColumnButtonClick);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1354, 51);
            this.grpFind.TabIndex = 5;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(87, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1261, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // FindBillNo
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1354, 465);
            this.Name = "FindBillNo";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).EndInit();
            this.grpgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpgrid;
        private RASF.General.Controls.Grid grdBill;
        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.Save_Button btnSearch;
        private RASF.General.Controls.TextBox txtSearch;
        private RASF.General.Lists.FindBillNumberList findBillNumberList1;
    }
}
