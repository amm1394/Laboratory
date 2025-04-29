namespace RASF.Main.Forms.Manager
{
    partial class ReportOfRemindHaghighi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOfRemindHaghighi));
            Janus.Windows.GridEX.GridEXLayout grid1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpdate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grid1 = new RASF.General.Controls.Grid();
            this.reportOfRemindHaghighiList1 = new RASF.General.Lists.ReportOfRemindHaghighiList(this.components);
            this.visualStyleManager1 = new Janus.Windows.Common.VisualStyleManager(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).BeginInit();
            this.grpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 598);
            this.pnlButton.Size = new System.Drawing.Size(1059, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpdate);
            this.pnlContent.Size = new System.Drawing.Size(1059, 598);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(854, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(937, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(999, 0);
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.pickDate1);
            this.grpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpdate.Location = new System.Drawing.Point(0, 0);
            this.grpdate.Name = "grpdate";
            this.grpdate.Size = new System.Drawing.Size(1059, 55);
            this.grpdate.TabIndex = 4;
            this.grpdate.Text = "تاریخ پذیرش";
            this.grpdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(632, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 35);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 543);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.Text = "مانده بدهی مشتریان حقیقی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grid1
            // 
            this.grid1.AlowRetrieveStructure = false;
            this.grid1.AlternatingColors = true;
            this.grid1.BuiltInTextsData = resources.GetString("grid1.BuiltInTextsData");
            this.grid1.DataSource = this.reportOfRemindHaghighiList1;
            this.grid1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid1_DesignTimeLayout.LayoutString = resources.GetString("grid1_DesignTimeLayout.LayoutString");
            this.grid1.DesignTimeLayout = grid1_DesignTimeLayout;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grid1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grid1.GroupByBoxVisible = false;
            this.grid1.Location = new System.Drawing.Point(3, 17);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1053, 523);
            this.grid1.TabIndex = 0;
            this.grid1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid1.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grid1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grid1.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grid1_ColumnButtonClick);
            // 
            // ReportOfRemindHaghighi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 628);
            this.Name = "ReportOfRemindHaghighi";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReportOfRemindHaghighi";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).EndInit();
            this.grpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpdate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grid1;
        private General.Lists.ReportOfRemindHaghighiList reportOfRemindHaghighiList1;
        private Janus.Windows.Common.VisualStyleManager visualStyleManager1;
    }
}