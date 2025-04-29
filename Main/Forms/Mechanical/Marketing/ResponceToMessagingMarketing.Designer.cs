namespace RASF.Main.Forms.Marketing
{
    partial class ResponceToMessagingMarketing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponceToMessagingMarketing));
            Janus.Windows.GridEX.GridEXLayout grdMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdMessage = new RASF.General.Controls.Grid();
            this.responceToMessagingMarketingList1 = new RASF.General.Lists.ResponceToMessagingMarketingList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtdesc = new RASF.General.Controls.TextBox();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.txtSender = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 650);
            this.pnlButton.Size = new System.Drawing.Size(1052, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.splitContainer1);
            this.pnlContent.Size = new System.Drawing.Size(1052, 650);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(847, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(930, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(992, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdMessage);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 550);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "پیام های ارسال شده";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMessage
            // 
            this.grdMessage.AlowRetrieveStructure = false;
            this.grdMessage.AlternatingColors = true;
            this.grdMessage.BuiltInTextsData = resources.GetString("grdMessage.BuiltInTextsData");
            this.grdMessage.DataSource = this.responceToMessagingMarketingList1;
            this.grdMessage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMessage_DesignTimeLayout.LayoutString = resources.GetString("grdMessage_DesignTimeLayout.LayoutString");
            this.grdMessage.DesignTimeLayout = grdMessage_DesignTimeLayout;
            this.grdMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMessage.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdMessage.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdMessage.GroupByBoxVisible = false;
            this.grdMessage.Location = new System.Drawing.Point(3, 17);
            this.grdMessage.Name = "grdMessage";
            this.grdMessage.Size = new System.Drawing.Size(1046, 530);
            this.grdMessage.TabIndex = 0;
            this.grdMessage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMessage.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdMessage_ColumnButtonClick);
            this.grdMessage.SelectionChanged += new System.EventHandler(this.grdMessage_SelectionChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 550);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1052, 100);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "توضیحات";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtdesc
            // 
            this.txtdesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdesc.Location = new System.Drawing.Point(3, 17);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(517, 80);
            this.txtdesc.TabIndex = 0;
            this.txtdesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSender);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.Text = "پیام فرستنده";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtSender
            // 
            this.txtSender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSender.Location = new System.Drawing.Point(3, 17);
            this.txtSender.Multiline = true;
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(519, 80);
            this.txtSender.TabIndex = 1;
            this.txtSender.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ResponceToMessagingMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 680);
            this.Name = "ResponceToMessagingMarketing";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ResponceToMessagingMarketing";
            this.Load += new System.EventHandler(this.ResponceToMessagingMarketing_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdMessage;
        private General.Lists.ResponceToMessagingMarketingList responceToMessagingMarketingList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.TextBox txtdesc;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox txtSender;
    }
}