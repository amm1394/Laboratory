namespace RASF.Main.Forms.Financial
{
    partial class CurrentWorkOfCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentWorkOfCompany));
            Janus.Windows.GridEX.GridEXLayout grdCo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdCo = new RASF.General.Controls.Grid();
            this.currentWorkOfCompanyList1 = new RASF.General.Lists.CurrentWorkOfCompanyList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(749, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(749, 434);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(544, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(627, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(689, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCo
            // 
            this.grdCo.AlowRetrieveStructure = false;
            this.grdCo.AlternatingColors = true;
            this.grdCo.BuiltInTextsData = resources.GetString("grdCo.BuiltInTextsData");
            this.grdCo.DataSource = this.currentWorkOfCompanyList1;
            this.grdCo.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCo_DesignTimeLayout.LayoutString = resources.GetString("grdCo_DesignTimeLayout.LayoutString");
            this.grdCo.DesignTimeLayout = grdCo_DesignTimeLayout;
            this.grdCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCo.GroupByBoxVisible = false;
            this.grdCo.Location = new System.Drawing.Point(3, 8);
            this.grdCo.Name = "grdCo";
            this.grdCo.Size = new System.Drawing.Size(743, 423);
            this.grdCo.TabIndex = 0;
            this.grdCo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCo.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CurrentWorkOfCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 464);
            this.Name = "CurrentWorkOfCompany";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CurrentWorkOfCompany_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdCo;
        private General.Lists.CurrentWorkOfCompanyList currentWorkOfCompanyList1;
    }
}
