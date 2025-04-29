namespace RASF.Main.Forms.Connector
{
    partial class TypeSendingCostForConnector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeSendingCostForConnector));
            Janus.Windows.GridEX.GridEXLayout grdcost_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdcost = new RASF.General.Controls.Grid();
            this.reportSendingEmailList1 = new RASF.General.Lists.ReportSendingEmailList(this.components);
            this.typesOfCostStatementsList1 = new RASF.General.Lists.TypesOfCostStatementsList(this.components);
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcost)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 646);
            this.pnlButton.Size = new System.Drawing.Size(1180, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1180, 646);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(975, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1058, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1120, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تاریخ تحویل";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdcost);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1180, 600);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcost
            // 
            this.grdcost.AlowRetrieveStructure = false;
            this.grdcost.AlternatingColors = true;
            this.grdcost.BuiltInTextsData = resources.GetString("grdcost.BuiltInTextsData");
            this.grdcost.DataSource = this.reportSendingEmailList1;
            this.grdcost.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcost_DesignTimeLayout.LayoutString = resources.GetString("grdcost_DesignTimeLayout.LayoutString");
            this.grdcost.DesignTimeLayout = grdcost_DesignTimeLayout;
            this.grdcost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcost.GroupByBoxVisible = false;
            this.grdcost.Location = new System.Drawing.Point(3, 8);
            this.grdcost.Name = "grdcost";
            this.grdcost.Size = new System.Drawing.Size(1174, 589);
            this.grdcost.TabIndex = 0;
            this.grdcost.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdcost.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdcost_ColumnButtonClick);
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(753, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // TypeSendingCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1180, 676);
            this.Name = "TypeSendingCost";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.TypeSendingCost_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdcost;
        private General.Lists.ReportSendingEmailList reportSendingEmailList1;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.TypesOfCostStatementsList typesOfCostStatementsList1;
    }
}
