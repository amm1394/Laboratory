namespace RASF.Main.Forms.Harmony
{
    partial class Theseparationofoffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theseparationofoffices));
            Janus.Windows.GridEX.GridEXLayout grdOffices_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.theseparationofofficesList1 = new RASF.General.Lists.TheseparationofofficesList(this.components);
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grdOffices = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 578);
            this.pnlButton.Size = new System.Drawing.Size(1098, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdOffices);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1098, 578);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(891, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(976, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1038, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "محدوده زمانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(671, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 36);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // grdOffices
            // 
            this.grdOffices.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdOffices.AlowRetrieveStructure = false;
            this.grdOffices.AlternatingColors = true;
            this.grdOffices.BuiltInTextsData = resources.GetString("grdOffices.BuiltInTextsData");
            this.grdOffices.DataSource = this.theseparationofofficesList1;
            this.grdOffices.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdOffices_DesignTimeLayout.LayoutString = resources.GetString("grdOffices_DesignTimeLayout.LayoutString");
            this.grdOffices.DesignTimeLayout = grdOffices_DesignTimeLayout;
            this.grdOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOffices.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdOffices.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdOffices.GroupByBoxVisible = false;
            this.grdOffices.Location = new System.Drawing.Point(0, 56);
            this.grdOffices.Name = "grdOffices";
            this.grdOffices.Size = new System.Drawing.Size(1098, 522);
            this.grdOffices.TabIndex = 2;
            this.grdOffices.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdOffices.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdOffices.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdOffices.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdOffices_ColumnButtonClick);
            // 
            // Theseparationofoffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1098, 608);
            this.Name = "Theseparationofoffices";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Theseparationofoffices_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOffices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.TheseparationofofficesList theseparationofofficesList1;
        private General.Controls.Grid grdOffices;
        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
    }
}
