namespace RASF.Main.Forms.Harmony
{
    partial class ReturnVoidPartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnVoidPartForm));
            Janus.Windows.GridEX.GridEXLayout grdPart_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdPart = new RASF.General.Controls.Grid();
            this.returnVoidPartList1 = new RASF.General.Lists.ReturnVoidPartList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 508);
            this.pnlButton.Size = new System.Drawing.Size(742, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(742, 508);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(537, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(620, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(682, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchContract1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "جستجو";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(513, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 33);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdPart);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 455);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "نمونه های باطل شده";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPart
            // 
            this.grdPart.AlowRetrieveStructure = false;
            this.grdPart.AlternatingColors = true;
            this.grdPart.BuiltInTextsData = resources.GetString("grdPart.BuiltInTextsData");
            this.grdPart.DataSource = this.returnVoidPartList1;
            this.grdPart.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPart_DesignTimeLayout.LayoutString = resources.GetString("grdPart_DesignTimeLayout.LayoutString");
            this.grdPart.DesignTimeLayout = grdPart_DesignTimeLayout;
            this.grdPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPart.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdPart.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdPart.GroupByBoxVisible = false;
            this.grdPart.Location = new System.Drawing.Point(3, 17);
            this.grdPart.Name = "grdPart";
            this.grdPart.Size = new System.Drawing.Size(736, 435);
            this.grdPart.TabIndex = 0;
            this.grdPart.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPart.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdPart.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdPart_ColumnButtonClick);
            // 
            // ReturnVoidPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(742, 538);
            this.Name = "ReturnVoidPartForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReturnVoidPartForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdPart;
        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.Main.Controls.SearchContract searchContract1;
        private RASF.General.Lists.ReturnVoidPartList returnVoidPartList1;
    }
}
