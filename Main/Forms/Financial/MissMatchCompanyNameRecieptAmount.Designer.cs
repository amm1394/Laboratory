namespace RASF.Main.Forms.Financial
{
    partial class MissMatchCompanyNameRecieptAmount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissMatchCompanyNameRecieptAmount));
            Janus.Windows.GridEX.GridEXLayout grdReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReport = new RASF.General.Controls.Grid();
            this.theamountofdailyintakeList1 = new RASF.General.Lists.TheamountofdailyintakeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 504);
            this.pnlButton.Size = new System.Drawing.Size(906, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(906, 504);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(701, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(784, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(846, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 504);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "عدم تطابق نام شرکت ";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReport
            // 
            this.grdReport.AlowRetrieveStructure = false;
            this.grdReport.AlternatingColors = true;
            this.grdReport.BuiltInTextsData = resources.GetString("grdReport.BuiltInTextsData");
            this.grdReport.DataSource = this.theamountofdailyintakeList1;
            this.grdReport.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReport_DesignTimeLayout.LayoutString = resources.GetString("grdReport_DesignTimeLayout.LayoutString");
            this.grdReport.DesignTimeLayout = grdReport_DesignTimeLayout;
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReport.GroupByBoxVisible = false;
            this.grdReport.Location = new System.Drawing.Point(3, 17);
            this.grdReport.Name = "grdReport";
            this.grdReport.RecordNavigator = true;
            this.grdReport.Size = new System.Drawing.Size(900, 484);
            this.grdReport.TabIndex = 0;
            this.grdReport.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReport.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // MissMatchCompanyNameRecieptAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 534);
            this.Name = "MissMatchCompanyNameRecieptAmount";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "MissMatchCompanyNameRecieptAmount";
            this.Load += new System.EventHandler(this.MissMatchCompanyNameRecieptAmount_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReport;
        private General.Lists.TheamountofdailyintakeList theamountofdailyintakeList1;
    }
}