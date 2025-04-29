namespace RASF.Main.Forms.Harmony
{
    partial class OutPutExecuters
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
            Janus.Windows.GridEX.GridEXLayout grdoutput_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutPutExecuters));
            Janus.Windows.GridEX.GridEXLayout grdDetailOutput_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdoutput = new RASF.General.Controls.Grid();
            this.outPutExecutersList1 = new RASF.General.Lists.OutPutExecutersList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDetailOutput = new RASF.General.Controls.Grid();
            this.outPutExecutersDetailList1 = new RASF.General.Lists.OutPutExecutersDetailList(this.components);
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdoutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 578);
            this.pnlButton.Size = new System.Drawing.Size(976, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(976, 578);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(771, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(854, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(916, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdoutput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "کارکرد پرسنل";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdoutput
            // 
            this.grdoutput.AlowRetrieveStructure = false;
            this.grdoutput.AlternatingColors = true;
            this.grdoutput.BuiltInTextsData = resources.GetString("grdoutput.BuiltInTextsData");
            this.grdoutput.DataSource = this.outPutExecutersList1;
            this.grdoutput.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdoutput_DesignTimeLayout.LayoutString = resources.GetString("grdoutput_DesignTimeLayout.LayoutString");
            this.grdoutput.DesignTimeLayout = grdoutput_DesignTimeLayout;
            this.grdoutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdoutput.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdoutput.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdoutput.GroupByBoxVisible = false;
            this.grdoutput.Location = new System.Drawing.Point(3, 17);
            this.grdoutput.Name = "grdoutput";
            this.grdoutput.Size = new System.Drawing.Size(970, 280);
            this.grdoutput.TabIndex = 0;
            this.grdoutput.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdoutput.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdoutput.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdoutput.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdoutput_FormattingRow);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDetailOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "کارکرد پرسنل به تفکیک آزمون";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDetailOutput
            // 
            this.grdDetailOutput.AlowRetrieveStructure = false;
            this.grdDetailOutput.AlternatingColors = true;
            this.grdDetailOutput.BuiltInTextsData = resources.GetString("grdDetailOutput.BuiltInTextsData");
            this.grdDetailOutput.DataSource = this.outPutExecutersDetailList1;
            this.grdDetailOutput.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetailOutput_DesignTimeLayout.LayoutString = resources.GetString("grdDetailOutput_DesignTimeLayout.LayoutString");
            this.grdDetailOutput.DesignTimeLayout = grdDetailOutput_DesignTimeLayout;
            this.grdDetailOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetailOutput.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDetailOutput.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDetailOutput.GroupByBoxVisible = false;
            this.grdDetailOutput.Location = new System.Drawing.Point(3, 17);
            this.grdDetailOutput.Name = "grdDetailOutput";
            this.grdDetailOutput.Size = new System.Drawing.Size(970, 208);
            this.grdDetailOutput.TabIndex = 1;
            this.grdDetailOutput.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetailOutput.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetailOutput.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(976, 50);
            this.grpDate.TabIndex = 2;
            this.grpDate.Text = "محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(549, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // OutPutExecuters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(976, 608);
            this.Name = "OutPutExecuters";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.OutPutExecuters_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdoutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetailOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdoutput;
        private General.Controls.Grid grdDetailOutput;
        private General.Lists.OutPutExecutersDetailList outPutExecutersDetailList1;
        private General.Lists.OutPutExecutersList outPutExecutersList1;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
    }
}
