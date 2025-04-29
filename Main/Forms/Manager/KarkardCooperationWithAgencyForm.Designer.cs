namespace RASF.Main.Forms.Manager
{
    partial class KarkardCooperationWithAgencyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarkardCooperationWithAgencyForm));
            Janus.Windows.GridEX.GridEXLayout grdKarkard_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpKarkard = new RASF.General.Controls.GroupBox();
            this.grdKarkard = new RASF.General.Controls.Grid();
            this.karkardCooperationWithAgencyList1 = new RASF.General.Lists.KarkardCooperationWithAgencyList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpKarkard)).BeginInit();
            this.grpKarkard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKarkard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 579);
            this.pnlButton.Size = new System.Drawing.Size(945, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(945, 579);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(740, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(823, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(885, 0);
            // 
            // grpKarkard
            // 
            this.grpKarkard.Controls.Add(this.grdKarkard);
            this.grpKarkard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKarkard.Location = new System.Drawing.Point(0, 46);
            this.grpKarkard.Name = "grpKarkard";
            this.grpKarkard.Size = new System.Drawing.Size(945, 533);
            this.grpKarkard.TabIndex = 0;
            this.grpKarkard.Text = "کارکرد";
            this.grpKarkard.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdKarkard
            // 
            this.grdKarkard.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdKarkard.AlowRetrieveStructure = false;
            this.grdKarkard.AlternatingColors = true;
            this.grdKarkard.BuiltInTextsData = resources.GetString("grdKarkard.BuiltInTextsData");
            this.grdKarkard.DataSource = this.karkardCooperationWithAgencyList1;
            this.grdKarkard.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdKarkard_DesignTimeLayout.LayoutString = resources.GetString("grdKarkard_DesignTimeLayout.LayoutString");
            this.grdKarkard.DesignTimeLayout = grdKarkard_DesignTimeLayout;
            this.grdKarkard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdKarkard.GroupByBoxVisible = false;
            this.grdKarkard.Location = new System.Drawing.Point(3, 17);
            this.grdKarkard.Name = "grdKarkard";
            this.grdKarkard.Size = new System.Drawing.Size(939, 513);
            this.grdKarkard.TabIndex = 0;
            this.grdKarkard.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdKarkard.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "تاریخ صورت حساب";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(518, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // KarkardCooperationWithAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(945, 609);
            this.Controls.Add(this.grpKarkard);
            this.Controls.Add(this.groupBox2);
            this.Name = "KarkardCooperationWithAgencyForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.grpKarkard, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKarkard)).EndInit();
            this.grpKarkard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKarkard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpKarkard;
        private General.Controls.Grid grdKarkard;
        private General.Lists.KarkardCooperationWithAgencyList karkardCooperationWithAgencyList1;
        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate1;
    }
}
