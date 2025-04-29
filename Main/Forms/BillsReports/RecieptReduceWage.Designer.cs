namespace RASF.Main.Forms.BillsReports
{
    partial class RecieptReduceWage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecieptReduceWage));
            Janus.Windows.GridEX.GridEXLayout grdBills_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdBills = new RASF.General.Controls.Grid();
            this.billsissuedList1 = new RASF.General.Lists.BillsissuedList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 711);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(1276, 711);
            // 
            // btnUpdate
            // 
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdBills);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1276, 711);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "صورت حساب های صادر شده";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBills
            // 
            this.grdBills.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdBills.AlowRetrieveStructure = false;
            this.grdBills.AlternatingColors = true;
            this.grdBills.BuiltInTextsData = resources.GetString("grdBills.BuiltInTextsData");
            this.grdBills.DataSource = this.billsissuedList1;
            this.grdBills.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBills_DesignTimeLayout.LayoutString = resources.GetString("grdBills_DesignTimeLayout.LayoutString");
            this.grdBills.DesignTimeLayout = grdBills_DesignTimeLayout;
            this.grdBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBills.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBills.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBills.GroupByBoxVisible = false;
            this.grdBills.Location = new System.Drawing.Point(3, 17);
            this.grdBills.Name = "grdBills";
            this.grdBills.Size = new System.Drawing.Size(1270, 691);
            this.grdBills.TabIndex = 0;
            this.grdBills.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBills.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBills.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // RecieptReduceWage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 741);
            this.Name = "RecieptReduceWage";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportOfGrant_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdBills;
        private General.Lists.BillsissuedList billsissuedList1;
    }
}
