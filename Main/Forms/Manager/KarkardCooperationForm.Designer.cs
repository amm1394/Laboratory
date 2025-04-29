namespace RASF.Main.Forms.Manager
{
    partial class KarkardCooperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KarkardCooperationForm));
            Janus.Windows.GridEX.GridEXLayout grdAgency_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdAgency = new RASF.General.Controls.Grid();
            this.karkardCooperationList1 = new RASF.General.Lists.KarkardCooperationList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 563);
            this.pnlButton.Size = new System.Drawing.Size(911, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(911, 563);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(706, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(789, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(851, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAgency);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "کارکرد دفاتر به تفکیک نوع همکاری";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgency
            // 
            this.grdAgency.AlowRetrieveStructure = false;
            this.grdAgency.AlternatingColors = true;
            this.grdAgency.BuiltInTextsData = resources.GetString("grdAgency.BuiltInTextsData");
            this.grdAgency.DataSource = this.karkardCooperationList1;
            this.grdAgency.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgency_DesignTimeLayout.LayoutString = resources.GetString("grdAgency_DesignTimeLayout.LayoutString");
            this.grdAgency.DesignTimeLayout = grdAgency_DesignTimeLayout;
            this.grdAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgency.GroupByBoxVisible = false;
            this.grdAgency.Location = new System.Drawing.Point(3, 17);
            this.grdAgency.Name = "grdAgency";
            this.grdAgency.Size = new System.Drawing.Size(905, 497);
            this.grdAgency.TabIndex = 0;
            this.grdAgency.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgency.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgency.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.Text = "تاریخ صورت حساب";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(484, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // KarkardCooperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(911, 593);
            this.Name = "KarkardCooperationForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.KarkardCooperationForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdAgency;
        private General.Lists.KarkardCooperationList karkardCooperationList1;
        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate1;
    }
}
