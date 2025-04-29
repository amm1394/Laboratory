namespace RASF.Main.Forms.Financial
{
    partial class EarnDeliveryDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarnDeliveryDay));
            Janus.Windows.GridEX.GridEXLayout grdDelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDelivery = new RASF.General.Controls.Grid();
            this.earnDeliveryDayList1 = new RASF.General.Lists.EarnDeliveryDayList(this.components);
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
            this.pnlButton.Location = new System.Drawing.Point(0, 540);
            this.pnlButton.Size = new System.Drawing.Size(1086, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1086, 540);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(881, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(964, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1026, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "تاریخ تحویل کار";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(659, 17);
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
            this.groupBox2.Size = new System.Drawing.Size(1086, 494);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "کارهای تحویلی روز که صورت حساب نخورده اند";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDelivery
            // 
            this.grdDelivery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelivery.AlowRetrieveStructure = false;
            this.grdDelivery.AlternatingColors = true;
            this.grdDelivery.BuiltInTextsData = resources.GetString("grdDelivery.BuiltInTextsData");
            this.grdDelivery.DataSource = this.earnDeliveryDayList1;
            this.grdDelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelivery_DesignTimeLayout.LayoutString = resources.GetString("grdDelivery_DesignTimeLayout.LayoutString");
            this.grdDelivery.DesignTimeLayout = grdDelivery_DesignTimeLayout;
            this.grdDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelivery.GroupByBoxVisible = false;
            this.grdDelivery.Location = new System.Drawing.Point(3, 17);
            this.grdDelivery.Name = "grdDelivery";
            this.grdDelivery.Size = new System.Drawing.Size(1080, 474);
            this.grdDelivery.TabIndex = 0;
            this.grdDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelivery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDelivery.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDelivery_ColumnButtonClick);
            // 
            // EarnDeliveryDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1086, 570);
            this.Name = "EarnDeliveryDay";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "درآمد براساس کارهای تحویل روز";
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
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDelivery;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.EarnDeliveryDayList earnDeliveryDayList1;
    }
}
