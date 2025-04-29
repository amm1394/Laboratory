namespace RASF.Main.Forms.Financial
{
    partial class ContractsWithoutBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsWithoutBills));
            Janus.Windows.GridEX.GridEXLayout grdContracts_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpReport = new RASF.General.Controls.GroupBox();
            this.grdContracts = new RASF.General.Controls.Grid();
            this.contractsWithoutBillsList1 = new RASF.General.Lists.ContractsWithoutBillsList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.panel2 = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 651);
            this.pnlButton.Size = new System.Drawing.Size(1197, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpReport);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Size = new System.Drawing.Size(1197, 651);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(990, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1075, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1137, 0);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.grdContracts);
            this.grpReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReport.Location = new System.Drawing.Point(0, 50);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(1197, 601);
            this.grpReport.TabIndex = 0;
            this.grpReport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdContracts
            // 
            this.grdContracts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContracts.AlowRetrieveStructure = false;
            this.grdContracts.AlternatingColors = true;
            this.grdContracts.BuiltInTextsData = resources.GetString("grdContracts.BuiltInTextsData");
            this.grdContracts.DataSource = this.contractsWithoutBillsList1;
            this.grdContracts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdContracts_DesignTimeLayout.LayoutString = resources.GetString("grdContracts_DesignTimeLayout.LayoutString");
            this.grdContracts.DesignTimeLayout = grdContracts_DesignTimeLayout;
            this.grdContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContracts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContracts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContracts.GroupByBoxVisible = false;
            this.grdContracts.Location = new System.Drawing.Point(3, 8);
            this.grdContracts.Name = "grdContracts";
            this.grdContracts.Size = new System.Drawing.Size(1191, 590);
            this.grdContracts.TabIndex = 0;
            this.grdContracts.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdContracts.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContracts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdContracts.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdOffices_ColumnButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 50);
            this.panel1.TabIndex = 1;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(1192, 50);
            this.grpDate.TabIndex = 4;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(765, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1192, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 3;
            // 
            // ContractsWithoutBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1197, 681);
            this.Name = "ContractsWithoutBills";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContracts)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpReport;
        private General.Controls.Grid grdContracts;
        private General.Controls.Panel panel1;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Panel panel2;
        private General.Lists.ContractsWithoutBillsList contractsWithoutBillsList1;
    }
}
