namespace RASF.Main.Forms.Harmony
{
    partial class ViewPartMasterOfContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPartMasterOfContract));
            Janus.Windows.GridEX.GridEXLayout grdMaterList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.masterTestListCostPaperList1 = new RASF.General.Lists.MasterTestListCostPaperList(this.components);
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.findContractNoList1 = new RASF.General.Lists.FindContractNoList(this.components);
            this.grdMaterList = new RASF.General.Controls.Grid();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 807);
            this.pnlButton.Size = new System.Drawing.Size(1236, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdMaterList);
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Controls.Add(this.groupBox6);
            this.pnlContent.Size = new System.Drawing.Size(1236, 807);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1029, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1114, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1176, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.searchContract1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1236, 43);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(1004, 8);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(229, 32);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grdMaterList
            // 
            this.grdMaterList.AlowRetrieveStructure = false;
            this.grdMaterList.AlternatingColors = true;
            this.grdMaterList.BuiltInTextsData = resources.GetString("grdMaterList.BuiltInTextsData");
            this.grdMaterList.DataSource = this.masterTestListCostPaperList1;
            this.grdMaterList.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMaterList_DesignTimeLayout.LayoutString = resources.GetString("grdMaterList_DesignTimeLayout.LayoutString");
            this.grdMaterList.DesignTimeLayout = grdMaterList_DesignTimeLayout;
            this.grdMaterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMaterList.GroupByBoxVisible = false;
            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
            this.grdMaterList.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle;
            this.grdMaterList.Location = new System.Drawing.Point(0, 43);
            this.grdMaterList.Name = "grdMaterList";
            this.grdMaterList.Size = new System.Drawing.Size(1236, 764);
            this.grdMaterList.TabIndex = 10;
            this.grdMaterList.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMaterList.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1236, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // ViewPartMasterOfContract
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 837);
            this.Name = "ViewPartMasterOfContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CostPaper1";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMaterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox6;
        private Controls.SearchContract searchContract1;
        private General.Lists.MasterTestListCostPaperList masterTestListCostPaperList1;
        private General.Lists.FindContractNoList findContractNoList1;
        private General.Controls.Grid grdMaterList;
        private General.Controls.TabControl tabControl1;
     //   private Lable.Letter_Scan letter_Scan1;
     //   private Lable.Letter_Scan letter_Scan2;
    }
}