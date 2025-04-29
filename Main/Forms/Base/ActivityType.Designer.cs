namespace RASF.Main.Forms
{
    partial class ActivityType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityType));
            Janus.Windows.GridEX.GridEXLayout grdActivityType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdActivityType = new RASF.General.Controls.Grid();
            this.companiesActivityTypeList1 = new RASF.General.Lists.CompaniesActivityTypeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdActivityType)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(339, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
            // 
            // grdActivityType
            // 
            this.grdActivityType.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdActivityType.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdActivityType.AlowRetrieveStructure = true;
            this.grdActivityType.AlternatingColors = true;
            this.grdActivityType.BuiltInTextsData = resources.GetString("grdActivityType.BuiltInTextsData");
            this.grdActivityType.DataSource = this.companiesActivityTypeList1;
            this.grdActivityType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdActivityType_DesignTimeLayout.LayoutString = resources.GetString("grdActivityType_DesignTimeLayout.LayoutString");
            this.grdActivityType.DesignTimeLayout = grdActivityType_DesignTimeLayout;
            this.grdActivityType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdActivityType.GroupByBoxVisible = false;
            this.grdActivityType.Location = new System.Drawing.Point(0, 0);
            this.grdActivityType.Name = "grdActivityType";
            this.grdActivityType.RecordNavigator = true;
            this.grdActivityType.Size = new System.Drawing.Size(546, 396);
            this.grdActivityType.TabIndex = 2;
            this.grdActivityType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdActivityType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ActivityType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdActivityType);
            this.Name = "ActivityType";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ActivityType_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdActivityType, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdActivityType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdActivityType;
        private General.Lists.CompaniesActivityTypeList companiesActivityTypeList1;
    }
}
