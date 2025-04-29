namespace RASF.Main.Forms.Financial
{
    partial class InvoiceDaneshBonyan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDaneshBonyan));
            Janus.Windows.GridEX.GridEXLayout grdDaneshBonyan_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDaneshBonyan = new RASF.General.Controls.Grid();
            this.reportOfDaneshBonyanList1 = new RASF.General.Lists.ReportOfDaneshBonyanList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDaneshBonyan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 683);
            this.pnlButton.Size = new System.Drawing.Size(1023, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1023, 683);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(818, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(901, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(963, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "صورت حساب";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(596, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDaneshBonyan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 637);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDaneshBonyan
            // 
            this.grdDaneshBonyan.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDaneshBonyan.AlowRetrieveStructure = false;
            this.grdDaneshBonyan.AlternatingColors = true;
            this.grdDaneshBonyan.BuiltInTextsData = resources.GetString("grdDaneshBonyan.BuiltInTextsData");
            this.grdDaneshBonyan.DataSource = this.reportOfDaneshBonyanList1;
            this.grdDaneshBonyan.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDaneshBonyan_DesignTimeLayout.LayoutString = resources.GetString("grdDaneshBonyan_DesignTimeLayout.LayoutString");
            this.grdDaneshBonyan.DesignTimeLayout = grdDaneshBonyan_DesignTimeLayout;
            this.grdDaneshBonyan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDaneshBonyan.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDaneshBonyan.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDaneshBonyan.GroupByBoxVisible = false;
            this.grdDaneshBonyan.Location = new System.Drawing.Point(3, 8);
            this.grdDaneshBonyan.Name = "grdDaneshBonyan";
            this.grdDaneshBonyan.RecordNavigator = true;
            this.grdDaneshBonyan.Size = new System.Drawing.Size(1017, 626);
            this.grdDaneshBonyan.TabIndex = 0;
            this.grdDaneshBonyan.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDaneshBonyan.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDaneshBonyan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // InvoiceDaneshBonyan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 713);
            this.Name = "InvoiceDaneshBonyan";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "InvoiceDaneshBonyan";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDaneshBonyan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDaneshBonyan;
        private General.Lists.ReportOfDaneshBonyanList reportOfDaneshBonyanList1;
    }
}