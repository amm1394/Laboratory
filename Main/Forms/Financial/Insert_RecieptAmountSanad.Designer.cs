namespace RASF.Main.Forms.Financial
{
    partial class Insert_RecieptAmountSanad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_RecieptAmountSanad));
            Janus.Windows.GridEX.GridEXLayout grdSanad_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpsanad = new RASF.General.Controls.GroupBox();
            this.grdSanad = new RASF.General.Controls.Grid();
            this.insert_RecieptAmountSanadList1 = new RASF.General.Lists.Insert_RecieptAmountSanadList(this.components);
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.pickDateFrom1 = new RASF.Main.Controls.PickDate.PickDateFrom();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpsanad)).BeginInit();
            this.grpsanad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSanad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 635);
            this.pnlButton.Size = new System.Drawing.Size(911, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpsanad);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(911, 635);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(704, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(789, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(851, 0);
            // 
            // grpsanad
            // 
            this.grpsanad.Controls.Add(this.grdSanad);
            this.grpsanad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpsanad.Location = new System.Drawing.Point(0, 46);
            this.grpsanad.Name = "grpsanad";
            this.grpsanad.Size = new System.Drawing.Size(911, 589);
            this.grpsanad.TabIndex = 0;
            this.grpsanad.Text = "صدور فاکتور";
            this.grpsanad.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdSanad
            // 
            this.grdSanad.AlowRetrieveStructure = false;
            this.grdSanad.AlternatingColors = true;
            this.grdSanad.AutoEdit = true;
            this.grdSanad.BuiltInTextsData = resources.GetString("grdSanad.BuiltInTextsData");
            this.grdSanad.DataSource = this.insert_RecieptAmountSanadList1;
            this.grdSanad.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdSanad_DesignTimeLayout.LayoutString = resources.GetString("grdSanad_DesignTimeLayout.LayoutString");
            this.grdSanad.DesignTimeLayout = grdSanad_DesignTimeLayout;
            this.grdSanad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSanad.GroupByBoxVisible = false;
            this.grdSanad.Location = new System.Drawing.Point(3, 17);
            this.grdSanad.Name = "grdSanad";
            this.grdSanad.Size = new System.Drawing.Size(905, 569);
            this.grdSanad.TabIndex = 0;
            this.grdSanad.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdSanad.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdSanad.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDateFrom1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(911, 46);
            this.grpDate.TabIndex = 1;
            this.grpDate.Text = "محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDateFrom1
            // 
            this.pickDateFrom1.BackColor = System.Drawing.Color.Transparent;
            this.pickDateFrom1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDateFrom1.Location = new System.Drawing.Point(667, 17);
            this.pickDateFrom1.Name = "pickDateFrom1";
            this.pickDateFrom1.Size = new System.Drawing.Size(241, 26);
            this.pickDateFrom1.TabIndex = 0;
            this.pickDateFrom1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDateFrom1_DateSelected);
            // 
            // Insert_RecieptAmountSanad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(911, 665);
            this.Name = "Insert_RecieptAmountSanad";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpsanad)).EndInit();
            this.grpsanad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSanad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpsanad;
        private General.Controls.Grid grdSanad;
        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDateFrom pickDateFrom1;
        private General.Lists.Insert_RecieptAmountSanadList insert_RecieptAmountSanadList1;
    }
}
