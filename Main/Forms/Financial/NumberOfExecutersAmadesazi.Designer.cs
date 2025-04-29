namespace RASF.Main.Forms.Financial
{
    partial class NumberOfExecutersAmadesazi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberOfExecutersAmadesazi));
            Janus.Windows.GridEX.GridEXLayout grdRuz_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdshab_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdRuz = new RASF.General.Controls.Grid();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.grpgrid = new RASF.General.Controls.GroupBox();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdshab = new RASF.General.Controls.Grid();
            this.numberOfExecutersAmadesaziRuzList1 = new RASF.General.Lists.NumberOfExecutersAmadesaziRuzList(this.components);
            this.numberOfExecutersAmadesaziShabList1 = new RASF.General.Lists.NumberOfExecutersAmadesaziShabList(this.components);
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRuz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).BeginInit();
            this.grpgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdshab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 548);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "چاپ";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(1276, 548);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "نمودار";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
            // 
            // grdRuz
            // 
            this.grdRuz.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdRuz.AlowRetrieveStructure = false;
            this.grdRuz.AlternatingColors = true;
            this.grdRuz.BuiltInTextsData = resources.GetString("grdRuz.BuiltInTextsData");
            this.grdRuz.DataSource = this.numberOfExecutersAmadesaziRuzList1;
            this.grdRuz.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdRuz_DesignTimeLayout.LayoutString = resources.GetString("grdRuz_DesignTimeLayout.LayoutString");
            this.grdRuz.DesignTimeLayout = grdRuz_DesignTimeLayout;
            this.grdRuz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRuz.GroupByBoxVisible = false;
            this.grdRuz.Location = new System.Drawing.Point(3, 17);
            this.grdRuz.Name = "grdRuz";
            this.grdRuz.Size = new System.Drawing.Size(1270, 212);
            this.grdRuz.TabIndex = 0;
            this.grdRuz.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdRuz.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdRuz.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1276, 50);
            this.grpDate.TabIndex = 2;
            this.grpDate.Text = "(تاریخ خروج)";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpgrid
            // 
            this.grpgrid.Controls.Add(this.grdRuz);
            this.grpgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpgrid.Location = new System.Drawing.Point(0, 0);
            this.grpgrid.Name = "grpgrid";
            this.grpgrid.Size = new System.Drawing.Size(1276, 232);
            this.grpgrid.TabIndex = 3;
            this.grpgrid.Text = "روز کار";
            this.grpgrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdshab);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "شب کار";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdshab
            // 
            this.grdshab.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdshab.AlowRetrieveStructure = false;
            this.grdshab.AlternatingColors = true;
            this.grdshab.BuiltInTextsData = resources.GetString("grdshab.BuiltInTextsData");
            this.grdshab.DataSource = this.numberOfExecutersAmadesaziShabList1;
            this.grdshab.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdshab_DesignTimeLayout.LayoutString = resources.GetString("grdshab_DesignTimeLayout.LayoutString");
            this.grdshab.DesignTimeLayout = grdshab_DesignTimeLayout;
            this.grdshab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdshab.GroupByBoxVisible = false;
            this.grdshab.Location = new System.Drawing.Point(3, 17);
            this.grdshab.Name = "grdshab";
            this.grdshab.Size = new System.Drawing.Size(1270, 242);
            this.grdshab.TabIndex = 0;
            this.grdshab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdshab.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdshab.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(849, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpgrid);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1276, 498);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 1;
            // 
            // NumberOfExecutersAmadesazi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 578);
            this.Name = "NumberOfExecutersAmadesazi";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.DailyProcessReport_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRuz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).EndInit();
            this.grpgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdshab)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdRuz;
        private General.Controls.GroupBox grpgrid;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdshab;
        private General.Lists.NumberOfExecutersAmadesaziShabList numberOfExecutersAmadesaziShabList1;
        private General.Lists.NumberOfExecutersAmadesaziRuzList numberOfExecutersAmadesaziRuzList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
