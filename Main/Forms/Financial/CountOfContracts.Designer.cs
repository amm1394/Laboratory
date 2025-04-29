namespace RASF.Main.Forms.Financial
{
    partial class CountOfContracts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountOfContracts));
            Janus.Windows.GridEX.GridEXLayout grdPersonel_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdPersonel = new RASF.General.Controls.Grid();
            this.outPutExecutersDetailList1 = new RASF.General.Lists.OutPutExecutersDetailList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 525);
            this.pnlButton.Size = new System.Drawing.Size(769, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(769, 525);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(564, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(647, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(709, 0);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(769, 50);
            this.grpDate.TabIndex = 4;
            this.grpDate.Text = "تاریخ پذیرش";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(342, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPersonel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 475);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdPersonel
            // 
            this.grdPersonel.AlowRetrieveStructure = false;
            this.grdPersonel.AlternatingColors = true;
            this.grdPersonel.BuiltInTextsData = resources.GetString("grdPersonel.BuiltInTextsData");
            this.grdPersonel.DataSource = this.outPutExecutersDetailList1;
            this.grdPersonel.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdPersonel_DesignTimeLayout.LayoutString = resources.GetString("grdPersonel_DesignTimeLayout.LayoutString");
            this.grdPersonel.DesignTimeLayout = grdPersonel_DesignTimeLayout;
            this.grdPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPersonel.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdPersonel.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdPersonel.GroupByBoxVisible = false;
            this.grdPersonel.Location = new System.Drawing.Point(3, 8);
            this.grdPersonel.Name = "grdPersonel";
            this.grdPersonel.RecordNavigator = true;
            this.grdPersonel.Size = new System.Drawing.Size(763, 464);
            this.grdPersonel.TabIndex = 0;
            this.grdPersonel.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdPersonel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CountOfContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 555);
            this.Name = "CountOfContracts";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CountOfContracts";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdPersonel;
        private General.Lists.OutPutExecutersDetailList outPutExecutersDetailList1;
    }
}