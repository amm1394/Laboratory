namespace RASF.Main.Forms.Financial
{
    partial class OfficeofFinancialConditionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfficeofFinancialConditionReport));
            Janus.Windows.GridEX.GridEXLayout grdOffices_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpOfficesName = new RASF.General.Controls.GroupBox();
            this.officesName1 = new RASF.Main.Controls.Offices.OfficesName();
            this.grpReport = new RASF.General.Controls.GroupBox();
            this.grdOffices = new RASF.General.Controls.Grid();
            this.officeofFinancialConditionReportList1 = new RASF.General.Lists.OfficeofFinancialConditionReportList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.panel2 = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).BeginInit();
            this.grpOfficesName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).BeginInit();
            this.grpReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOffices)).BeginInit();
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
            this.pnlUpdate.Location = new System.Drawing.Point(992, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1075, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1137, 0);
            // 
            // grpOfficesName
            // 
            this.grpOfficesName.Controls.Add(this.officesName1);
            this.grpOfficesName.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpOfficesName.Location = new System.Drawing.Point(941, 0);
            this.grpOfficesName.Name = "grpOfficesName";
            this.grpOfficesName.Size = new System.Drawing.Size(256, 50);
            this.grpOfficesName.TabIndex = 2;
            this.grpOfficesName.Text = "انتخاب نام دفتر";
            this.grpOfficesName.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // officesName1
            // 
            this.officesName1.BackColor = System.Drawing.Color.Transparent;
            this.officesName1.Dock = System.Windows.Forms.DockStyle.Right;
            this.officesName1.Location = new System.Drawing.Point(10, 17);
            this.officesName1.Name = "officesName1";
            this.officesName1.Size = new System.Drawing.Size(243, 30);
            this.officesName1.TabIndex = 0;
            this.officesName1.SelectedValueChanged += new System.EventHandler(this.officesName1_SelectedValueChanged);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.grdOffices);
            this.grpReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpReport.Location = new System.Drawing.Point(0, 50);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(1197, 601);
            this.grpReport.TabIndex = 0;
            this.grpReport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdOffices
            // 
            this.grdOffices.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdOffices.AlowRetrieveStructure = false;
            this.grdOffices.AlternatingColors = true;
            this.grdOffices.BuiltInTextsData = resources.GetString("grdOffices.BuiltInTextsData");
            this.grdOffices.DataSource = this.officeofFinancialConditionReportList1;
            this.grdOffices.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdOffices_DesignTimeLayout.LayoutString = resources.GetString("grdOffices_DesignTimeLayout.LayoutString");
            this.grdOffices.DesignTimeLayout = grdOffices_DesignTimeLayout;
            this.grdOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOffices.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdOffices.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdOffices.GroupByBoxVisible = false;
            this.grdOffices.Location = new System.Drawing.Point(3, 8);
            this.grdOffices.Name = "grdOffices";
            this.grdOffices.Size = new System.Drawing.Size(1191, 590);
            this.grdOffices.TabIndex = 0;
            this.grdOffices.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdOffices.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdOffices.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdOffices.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdOffices_ColumnButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grpOfficesName);
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
            this.grpDate.Size = new System.Drawing.Size(936, 50);
            this.grpDate.TabIndex = 4;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(509, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(936, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 50);
            this.panel2.TabIndex = 3;
            // 
            // OfficeofFinancialConditionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1197, 681);
            this.Name = "OfficeofFinancialConditionReport";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpOfficesName)).EndInit();
            this.grpOfficesName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpReport)).EndInit();
            this.grpReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOffices)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpOfficesName;
        private General.Controls.GroupBox grpReport;
        private Controls.Offices.OfficesName officesName1;
        private General.Controls.Grid grdOffices;
        private General.Lists.OfficeofFinancialConditionReportList officeofFinancialConditionReportList1;
        private General.Controls.Panel panel1;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Panel panel2;
    }
}
