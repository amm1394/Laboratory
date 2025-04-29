namespace RASF.Main.Forms.Harmony
{
    partial class NotDestruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotDestruct));
            Janus.Windows.GridEX.GridEXLayout grdDestruct_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdDestruct = new RASF.General.Controls.Grid();
            this.notDestructList1 = new RASF.General.Lists.NotDestructList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDestruct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdDestruct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "تخریب نشود";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDestruct
            // 
            this.grdDestruct.AlowRetrieveStructure = false;
            this.grdDestruct.AlternatingColors = true;
            this.grdDestruct.BuiltInTextsData = resources.GetString("grdDestruct.BuiltInTextsData");
            this.grdDestruct.DataSource = this.notDestructList1;
            this.grdDestruct.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDestruct_DesignTimeLayout.LayoutString = resources.GetString("grdDestruct_DesignTimeLayout.LayoutString");
            this.grdDestruct.DesignTimeLayout = grdDestruct_DesignTimeLayout;
            this.grdDestruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDestruct.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDestruct.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDestruct.GroupByBoxVisible = false;
            this.grdDestruct.Location = new System.Drawing.Point(3, 17);
            this.grdDestruct.Name = "grdDestruct";
            this.grdDestruct.Size = new System.Drawing.Size(468, 368);
            this.grdDestruct.TabIndex = 0;
            this.grdDestruct.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDestruct.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDestruct.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDestruct_ColumnButtonClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "محدوده زمانی";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(47, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // NotDestruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(474, 464);
            this.Name = "NotDestruct";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.NotDestruct_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDestruct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdDestruct;
        private General.Lists.NotDestructList notDestructList1;
        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate1;
    }
}
