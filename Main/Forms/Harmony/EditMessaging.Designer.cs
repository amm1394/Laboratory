namespace RASF.Main.Forms.Harmony
{
    partial class EditMessaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMessaging));
            Janus.Windows.GridEX.GridEXLayout grdEdit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.GrpEdit = new RASF.General.Controls.GroupBox();
            this.grdEdit = new RASF.General.Controls.Grid();
            this.editMessageList1 = new RASF.General.Lists.EditMessageList(this.components);
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContractcsForAll1 = new RASF.Main.Controls.SearchContractcsForAll();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtEdit = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpEdit)).BeginInit();
            this.GrpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 523);
            this.pnlButton.Size = new System.Drawing.Size(698, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.GrpEdit);
            this.pnlContent.Controls.Add(this.groupBox6);
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(698, 523);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(493, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(576, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(638, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(294, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 0;
            // 
            // GrpEdit
            // 
            this.GrpEdit.Controls.Add(this.grdEdit);
            this.GrpEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrpEdit.Location = new System.Drawing.Point(0, 43);
            this.GrpEdit.Name = "GrpEdit";
            this.GrpEdit.Size = new System.Drawing.Size(698, 292);
            this.GrpEdit.TabIndex = 1;
            this.GrpEdit.Text = "ویرایش پیام";
            this.GrpEdit.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdEdit
            // 
            this.grdEdit.AlowRetrieveStructure = false;
            this.grdEdit.AlternatingColors = true;
            this.grdEdit.BuiltInTextsData = resources.GetString("grdEdit.BuiltInTextsData");
            this.grdEdit.DataSource = this.editMessageList1;
            this.grdEdit.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEdit_DesignTimeLayout.LayoutString = resources.GetString("grdEdit_DesignTimeLayout.LayoutString");
            this.grdEdit.DesignTimeLayout = grdEdit_DesignTimeLayout;
            this.grdEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEdit.GroupByBoxVisible = false;
            this.grdEdit.Location = new System.Drawing.Point(3, 17);
            this.grdEdit.Name = "grdEdit";
            this.grdEdit.Size = new System.Drawing.Size(692, 272);
            this.grdEdit.TabIndex = 0;
            this.grdEdit.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEdit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContractcsForAll1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(698, 43);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContractcsForAll1
            // 
            this.searchContractcsForAll1.BackColor = System.Drawing.Color.Transparent;
            this.searchContractcsForAll1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContractcsForAll1.Location = new System.Drawing.Point(469, 8);
            this.searchContractcsForAll1.Name = "searchContractcsForAll1";
            this.searchContractcsForAll1.Size = new System.Drawing.Size(226, 32);
            this.searchContractcsForAll1.TabIndex = 0;
            this.searchContractcsForAll1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContractcsForAll1_ReturnContractsCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEdit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "ویرایش متن";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtEdit
            // 
            this.txtEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editMessageList1, "Message", true));
            this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdit.Location = new System.Drawing.Point(3, 17);
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(692, 168);
            this.txtEdit.TabIndex = 0;
            this.txtEdit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // EditMessaging
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 553);
            this.Name = "EditMessaging";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpEdit)).EndInit();
            this.GrpEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.TabControl tabControl1;
        private General.Controls.GroupBox GrpEdit;
        private General.Controls.Grid grdEdit;
        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContractcsForAll searchContractcsForAll1;
        private General.Lists.EditMessageList editMessageList1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TextBox txtEdit;
    }
}
