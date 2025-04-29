namespace RASF.Main.Forms.Manager
{
    partial class ReportMounthlyAgency2018To2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMounthlyAgency2018To2019));
            Janus.Windows.GridEX.GridEXLayout grdAgency_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdAgency = new RASF.General.Controls.Grid();
            this.reportMounthlyLaboratory2017To2018List1 = new RASF.General.Lists.ReportMounthlyLaboratory2017To2018List(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAgency);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "گزارش ماهانه دفاتر";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAgency
            // 
            this.grdAgency.AlowRetrieveStructure = false;
            this.grdAgency.AlternatingColors = true;
            this.grdAgency.BuiltInTextsData = resources.GetString("grdAgency.BuiltInTextsData");
            this.grdAgency.DataSource = this.reportMounthlyLaboratory2017To2018List1;
            this.grdAgency.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgency_DesignTimeLayout.LayoutString = resources.GetString("grdAgency_DesignTimeLayout.LayoutString");
            this.grdAgency.DesignTimeLayout = grdAgency_DesignTimeLayout;
            this.grdAgency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgency.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdAgency.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdAgency.GroupByBoxVisible = false;
            this.grdAgency.Location = new System.Drawing.Point(3, 17);
            this.grdAgency.Name = "grdAgency";
            this.grdAgency.Size = new System.Drawing.Size(468, 414);
            this.grdAgency.TabIndex = 0;
            this.grdAgency.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgency.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAgency.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportMounthlyAgency2018To2019
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 464);
            this.Name = "ReportMounthlyAgency2018To2019";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReportMounthlyAgency2018To2019";
            this.Load += new System.EventHandler(this.ReportMounthlyAgency2018To2019_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdAgency;
        private General.Lists.ReportMounthlyLaboratory2017To2018List reportMounthlyLaboratory2017To2018List1;
    }
}