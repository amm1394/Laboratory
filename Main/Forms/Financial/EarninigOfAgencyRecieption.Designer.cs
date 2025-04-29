namespace RASF.Main.Forms.ContractsReport
{
    partial class EarninigOfAgencyRecieption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarninigOfAgencyRecieption));
            Janus.Windows.GridEX.GridEXLayout grdAgency_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdAgency = new RASF.General.Controls.Grid();
            this.officesFinancialAgencyList1 = new RASF.General.Lists.OfficesFinancialAgencyList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 592);
            this.pnlButton.Size = new System.Drawing.Size(1180, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1180, 592);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(6621, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1058, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1120, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1180, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "تاریخ پذیرش";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(753, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdAgency);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1180, 546);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "کارهای دریافتی پذیرش ";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgency
            // 
            this.grdAgency.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdAgency.AlowRetrieveStructure = false;
            this.grdAgency.AlternatingColors = true;
            this.grdAgency.BuiltInTextsData = resources.GetString("grdAgency.BuiltInTextsData");
            this.grdAgency.DataSource = this.officesFinancialAgencyList1;
            this.grdAgency.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgency_DesignTimeLayout.LayoutString = resources.GetString("grdAgency_DesignTimeLayout.LayoutString");
            this.grdAgency.DesignTimeLayout = grdAgency_DesignTimeLayout;
            this.grdAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgency.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdAgency.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdAgency.GroupByBoxVisible = false;
            this.grdAgency.Location = new System.Drawing.Point(3, 17);
            this.grdAgency.Name = "grdAgency";
            this.grdAgency.Size = new System.Drawing.Size(1174, 526);
            this.grdAgency.TabIndex = 0;
            this.grdAgency.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgency.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgency.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // EarninigOfAgencyRecieption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1180, 622);
            this.Name = "EarninigOfAgencyRecieption";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.TabText = "کارکرد دفاتر (پذیرش)";
            this.Text = "کارکرد دفاتر (پذیرش)";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdAgency;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.OfficesFinancialAgencyList officesFinancialAgencyList1;
    }
}
