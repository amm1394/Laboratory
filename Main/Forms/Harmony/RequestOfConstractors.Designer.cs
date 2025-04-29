namespace RASF.Main.Forms.Harmony
{
    partial class RequestOfConstractors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestOfConstractors));
            Janus.Windows.GridEX.GridEXLayout grdcontractors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpSearch = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpContractors = new RASF.General.Controls.GroupBox();
            this.grdcontractors = new RASF.General.Controls.Grid();
            this.requestOfContractorList1 = new RASF.General.Lists.RequestOfContractorList(this.components);
            this.constractorsList1 = new RASF.General.Lists.ConstractorsList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).BeginInit();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).BeginInit();
            this.grpContractors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 440);
            this.pnlButton.Size = new System.Drawing.Size(773, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpContractors);
            this.pnlContent.Controls.Add(this.grpSearch);
            this.pnlContent.Size = new System.Drawing.Size(773, 440);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(566, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(651, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(713, 0);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.searchContract1);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(773, 48);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.Text = "جستجو";
            this.grpSearch.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(544, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 28);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpContractors
            // 
            this.grpContractors.Controls.Add(this.grdcontractors);
            this.grpContractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContractors.Location = new System.Drawing.Point(0, 48);
            this.grpContractors.Name = "grpContractors";
            this.grpContractors.Size = new System.Drawing.Size(773, 392);
            this.grpContractors.TabIndex = 1;
            this.grpContractors.Text = "انتخاب پیمانکاران";
            this.grpContractors.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdcontractors
            // 
            this.grdcontractors.AlowRetrieveStructure = false;
            this.grdcontractors.AlternatingColors = true;
            this.grdcontractors.BuiltInTextsData = resources.GetString("grdcontractors.BuiltInTextsData");
            this.grdcontractors.DataSource = this.requestOfContractorList1;
            this.grdcontractors.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdcontractors_DesignTimeLayout.LayoutString = resources.GetString("grdcontractors_DesignTimeLayout.LayoutString");
            this.grdcontractors.DesignTimeLayout = grdcontractors_DesignTimeLayout;
            this.grdcontractors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdcontractors.GroupByBoxVisible = false;
            this.grdcontractors.Location = new System.Drawing.Point(3, 17);
            this.grdcontractors.Name = "grdcontractors";
            this.grdcontractors.Size = new System.Drawing.Size(767, 372);
            this.grdcontractors.TabIndex = 0;
            this.grdcontractors.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdcontractors.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RequestOfConstractors
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Name = "RequestOfConstractors";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "RequestOfConstractors";
            this.Load += new System.EventHandler(this.RequestOfConstractors_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpSearch)).EndInit();
            this.grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpContractors)).EndInit();
            this.grpContractors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdcontractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpSearch;
        private General.Controls.GroupBox grpContractors;
        private General.Controls.Grid grdcontractors;
        private General.Lists.RequestOfContractorList requestOfContractorList1;
        private Controls.SearchContract searchContract1;
        private General.Lists.ConstractorsList constractorsList1;
    }
}