namespace RASF.Main.Forms.Manager
{
    partial class ReportDeliveryReportThetNotIsCompleted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDeliveryReportThetNotIsCompleted));
            Janus.Windows.GridEX.GridEXLayout grdDelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDelivery = new RASF.General.Controls.Grid();
            this.deliveryDayForHarmonyList1 = new RASF.General.Lists.DeliveryDayForHarmonyList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 675);
            this.pnlButton.Size = new System.Drawing.Size(1301, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1301, 675);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1096, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1179, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1241, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تاریخ تحویل";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(874, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDelivery);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1301, 629);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "کارهای تاخیری";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDelivery
            // 
            this.grdDelivery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelivery.AlowRetrieveStructure = false;
            this.grdDelivery.AlternatingColors = true;
            this.grdDelivery.BuiltInTextsData = resources.GetString("grdDelivery.BuiltInTextsData");
            this.grdDelivery.DataSource = this.deliveryDayForHarmonyList1;
            this.grdDelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelivery_DesignTimeLayout.LayoutString = resources.GetString("grdDelivery_DesignTimeLayout.LayoutString");
            this.grdDelivery.DesignTimeLayout = grdDelivery_DesignTimeLayout;
            this.grdDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelivery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelivery.GroupByBoxVisible = false;
            this.grdDelivery.Location = new System.Drawing.Point(3, 17);
            this.grdDelivery.Name = "grdDelivery";
            this.grdDelivery.RecordNavigator = true;
            this.grdDelivery.Size = new System.Drawing.Size(1295, 609);
            this.grdDelivery.TabIndex = 0;
            this.grdDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelivery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ReportDeliveryReportThetNotIsCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 705);
            this.Name = "ReportDeliveryReportThetNotIsCompleted";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReportDeliveryReportThetNotIsCompleted";
            this.Load += new System.EventHandler(this.ReportDeliveryReportThetNotIsCompleted_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDelivery;
        private General.Lists.DeliveryDayForHarmonyList deliveryDayForHarmonyList1;
    }
}