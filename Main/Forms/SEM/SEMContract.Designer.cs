namespace RASF.Main.Forms.SEM
{
    partial class SEMContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMContract));
            Janus.Windows.GridEX.GridEXLayout grdSem_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdSem = new RASF.General.Controls.Grid();
            this.semContractList1 = new RASF.General.Lists.SEMContractList(this.components);
            //this.pnlButton.SuspendLayout();
            //this.pnlContent.SuspendLayout();
            //this.pnlUpdate.SuspendLayout();
            //this.pnlExit.SuspendLayout();
            //this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            //this.pnlContent.Controls.Add(this.groupBox1);
            //// 
            //// btnUpdate
            //// 
            //this.btnUpdate.Text = "انصراف";
            //this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdSem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdSem
            // 
            this.grdSem.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdSem.AlowRetrieveStructure = false;
            this.grdSem.AlternatingColors = true;
            this.grdSem.BuiltInTextsData = resources.GetString("grdSem.BuiltInTextsData");
            this.grdSem.DataSource = this.semContractList1;
            this.grdSem.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdSem_DesignTimeLayout.LayoutString = resources.GetString("grdSem_DesignTimeLayout.LayoutString");
            this.grdSem.DesignTimeLayout = grdSem_DesignTimeLayout;
            this.grdSem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSem.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdSem.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdSem.GroupByBoxVisible = false;
            this.grdSem.Location = new System.Drawing.Point(3, 8);
            this.grdSem.Name = "grdSem";
            this.grdSem.Size = new System.Drawing.Size(468, 423);
            this.grdSem.TabIndex = 0;
            this.grdSem.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdSem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdSem.DoubleClick += new System.EventHandler(this.grdSem_DoubleClick);
            // 
            // SEMContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 464);
            this.Name = "SEMContract";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SEMContract";
            this.Load += new System.EventHandler(this.SEMContract_Load);
            //this.pnlButton.ResumeLayout(false);
            //this.pnlContent.ResumeLayout(false);
            //this.pnlUpdate.ResumeLayout(false);
            //this.pnlExit.ResumeLayout(false);
            //this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdSem;
        private General.Lists.SEMContractList semContractList1;
    }
}