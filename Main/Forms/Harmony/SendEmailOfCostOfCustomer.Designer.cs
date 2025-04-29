namespace RASF.Main.Forms.Harmony
{
    partial class SendEmailOfCostOfCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendEmailOfCostOfCustomer));
            Janus.Windows.GridEX.GridEXLayout grdCostomerCost_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.labEmail = new RASF.General.Controls.Label();
            this.txtEmail = new RASF.General.Controls.TextBox();
            this.btnSearch = new RASF.General.Controls.Save_Button();
            this.txtSearch = new RASF.General.Controls.TextBox();
            this.grpMaster = new RASF.General.Controls.GroupBox();
            this.grdCostomerCost = new RASF.General.Controls.Grid();
            this.sendEmailOfCostOfCustomerList1 = new RASF.General.Lists.SendEmailOfCostOfCustomerList(this.components);
            this.grpTemp = new RASF.General.Controls.GroupBox();
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).BeginInit();
            this.grpMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 606);
            this.pnlButton.Size = new System.Drawing.Size(1087, 24);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, -3);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, -3);
            this.btnSave.Text = "ارسال";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpMaster);
            this.pnlContent.Controls.Add(this.grpTemp);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(1087, 606);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(880, -6);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(965, 0);
            this.pnlExit.Size = new System.Drawing.Size(62, 24);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1027, 0);
            this.pnlSave.Size = new System.Drawing.Size(60, 24);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.labEmail);
            this.grpFind.Controls.Add(this.txtEmail);
            this.grpFind.Controls.Add(this.btnSearch);
            this.grpFind.Controls.Add(this.txtSearch);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(1087, 86);
            this.grpFind.TabIndex = 4;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(1051, 50);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(36, 13);
            this.labEmail.TabIndex = 3;
            this.labEmail.Text = "ایمیل:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(87, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(958, 21);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
            this.txtSearch.Size = new System.Drawing.Size(994, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpMaster
            // 
            this.grpMaster.Controls.Add(this.grdCostomerCost);
            this.grpMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMaster.Location = new System.Drawing.Point(0, 86);
            this.grpMaster.Name = "grpMaster";
            this.grpMaster.Size = new System.Drawing.Size(1087, 520);
            this.grpMaster.TabIndex = 5;
            this.grpMaster.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCostomerCost
            // 
            this.grdCostomerCost.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCostomerCost.AlowRetrieveStructure = false;
            this.grdCostomerCost.AlternatingColors = true;
            this.grdCostomerCost.BuiltInTextsData = resources.GetString("grdCostomerCost.BuiltInTextsData");
            this.grdCostomerCost.ColumnAutoResize = true;
            this.grdCostomerCost.DataSource = this.sendEmailOfCostOfCustomerList1;
            this.grdCostomerCost.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCostomerCost_DesignTimeLayout.LayoutString = resources.GetString("grdCostomerCost_DesignTimeLayout.LayoutString");
            this.grdCostomerCost.DesignTimeLayout = grdCostomerCost_DesignTimeLayout;
            this.grdCostomerCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCostomerCost.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCostomerCost.GroupByBoxVisible = false;
            this.grdCostomerCost.Location = new System.Drawing.Point(3, 8);
            this.grdCostomerCost.Name = "grdCostomerCost";
            this.grdCostomerCost.Size = new System.Drawing.Size(1081, 509);
            this.grdCostomerCost.TabIndex = 1;
            this.grdCostomerCost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCostomerCost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpTemp
            // 
            this.grpTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTemp.Location = new System.Drawing.Point(0, 86);
            this.grpTemp.Name = "grpTemp";
            this.grpTemp.Size = new System.Drawing.Size(1087, 520);
            this.grpTemp.TabIndex = 6;
            this.grpTemp.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // SendEmailOfCostOfCustomer
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1087, 630);
            this.Name = "SendEmailOfCostOfCustomer";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMaster)).EndInit();
            this.grpMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCostomerCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.Save_Button btnSearch;
        private RASF.General.Controls.TextBox txtSearch;
        private RASF.General.Controls.GroupBox grpMaster;
        private RASF.General.Controls.GroupBox grpTemp;
        private RASF.General.Lists.FindContractNoList findContractNoList1;
        private General.Controls.Label labEmail;
        private General.Controls.TextBox txtEmail;
        private General.Controls.Grid grdCostomerCost;
        private General.Lists.SendEmailOfCostOfCustomerList sendEmailOfCostOfCustomerList1;
    }
}
