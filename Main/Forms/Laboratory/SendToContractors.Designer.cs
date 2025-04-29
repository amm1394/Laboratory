namespace RASF.Main.Forms.Laboratory
{
    partial class SendToContractors
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
            Janus.Windows.GridEX.GridEXLayout grdContractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendToContractors));
            Janus.Windows.GridEX.GridEXLayout GrdEdit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdContractors = new RASF.General.Controls.Grid();
            this.sertPartToContractorsList1 = new RASF.General.Lists.SentPartToContractorsList(this.components);
            this.constractorsList1 = new RASF.General.Lists.ConstractorsList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.GrdEdit = new RASF.General.Controls.Grid();
            this.editContractorsForLabList1 = new RASF.General.Lists.EditContractorsForLabList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContractors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 567);
            this.pnlButton.Size = new System.Drawing.Size(1474, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1474, 567);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(17181, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1352, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1414, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchContract1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1474, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "شماره قرارداد";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(1242, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 37);
            this.searchContract1.TabIndex = 1;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdContractors);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1474, 309);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "انتخاب پیمانکار";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContractors
            // 
            this.grdContractors.AlowRetrieveStructure = false;
            this.grdContractors.AlternatingColors = true;
            this.grdContractors.BuiltInTextsData = resources.GetString("grdContractors.BuiltInTextsData");
            this.grdContractors.DataSource = this.sertPartToContractorsList1;
            this.grdContractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContractors_DesignTimeLayout.LayoutString = resources.GetString("grdContractors_DesignTimeLayout.LayoutString");
            this.grdContractors.DesignTimeLayout = grdContractors_DesignTimeLayout;
            this.grdContractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContractors.GroupByBoxVisible = false;
            this.grdContractors.Location = new System.Drawing.Point(3, 17);
            this.grdContractors.Name = "grdContractors";
            this.grdContractors.Size = new System.Drawing.Size(1468, 289);
            this.grdContractors.TabIndex = 0;
            this.grdContractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContractors.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdContractors_FormattingRow);
            this.grdContractors.SelectionChanged += new System.EventHandler(this.grdContractors_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GrdEdit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1474, 201);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "اصلاح";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // GrdEdit
            // 
            this.GrdEdit.AlowRetrieveStructure = false;
            this.GrdEdit.AlternatingColors = true;
            this.GrdEdit.BuiltInTextsData = resources.GetString("GrdEdit.BuiltInTextsData");
            this.GrdEdit.DataSource = this.editContractorsForLabList1;
            this.GrdEdit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            GrdEdit_DesignTimeLayout.LayoutString = resources.GetString("GrdEdit_DesignTimeLayout.LayoutString");
            this.GrdEdit.DesignTimeLayout = GrdEdit_DesignTimeLayout;
            this.GrdEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdEdit.GroupByBoxVisible = false;
            this.GrdEdit.Location = new System.Drawing.Point(3, 17);
            this.GrdEdit.Name = "GrdEdit";
            this.GrdEdit.Size = new System.Drawing.Size(1468, 181);
            this.GrdEdit.TabIndex = 0;
            this.GrdEdit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.GrdEdit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // SendToContractors
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1474, 597);
            this.Name = "SendToContractors";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.SendToContractors_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContractors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.Main.Controls.SearchContract searchContract1;
        private RASF.General.Controls.Grid grdContractors;
        private RASF.General.Lists.SentPartToContractorsList sertPartToContractorsList1;
        private General.Lists.ConstractorsList constractorsList1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Grid GrdEdit;
        private General.Lists.EditContractorsForLabList editContractorsForLabList1;
    }
}
