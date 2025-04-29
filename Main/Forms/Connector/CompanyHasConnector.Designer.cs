namespace RASF.Main.Forms.Connector
{
    partial class CompanyHasConnector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyHasConnector));
            Janus.Windows.GridEX.GridEXLayout grdConnector_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdConnector = new RASF.General.Controls.Grid();
            this.recieptionDayList1 = new RASF.General.Lists.RecieptionDayList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConnector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Size = new System.Drawing.Size(1003, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(1003, 434);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(798, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(881, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(943, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdConnector);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdConnector
            // 
            this.grdConnector.AlowRetrieveStructure = false;
            this.grdConnector.AlternatingColors = true;
            this.grdConnector.BuiltInTextsData = resources.GetString("grdConnector.BuiltInTextsData");
            this.grdConnector.DataSource = this.recieptionDayList1;
            this.grdConnector.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdConnector_DesignTimeLayout.LayoutString = resources.GetString("grdConnector_DesignTimeLayout.LayoutString");
            this.grdConnector.DesignTimeLayout = grdConnector_DesignTimeLayout;
            this.grdConnector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConnector.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdConnector.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdConnector.GroupByBoxVisible = false;
            this.grdConnector.Location = new System.Drawing.Point(3, 8);
            this.grdConnector.Name = "grdConnector";
            this.grdConnector.RecordNavigator = true;
            this.grdConnector.Size = new System.Drawing.Size(997, 377);
            this.grdConnector.TabIndex = 0;
            this.grdConnector.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdConnector.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "محدوده زمانی";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(576, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // CompanyHasConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CompanyHasConnector";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CompanyHasConnector";
            this.Load += new System.EventHandler(this.CompanyHasConnector_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConnector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdConnector;
        private General.Lists.RecieptionDayList recieptionDayList1;
        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate1;
    }
}