namespace RASF.Main.Forms.Message
{
    partial class SendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessage));
            Janus.Windows.GridEX.GridEXLayout grdReceiver_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.laboratory_UserList1 = new RASF.General.Lists.Laboratory_UserList(this.components);
            this.sendMessageList1 = new RASF.General.Lists.SendMessageList(this.components);
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.label1 = new RASF.General.Controls.Label();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpReceiver = new RASF.General.Controls.GroupBox();
            this.btnSend = new RASF.General.Controls.Save_Button();
            this.grdReceiver = new RASF.General.Controls.Grid();
            this.grpMessagePast = new RASF.General.Controls.GroupBox();
            this.grdMessage = new RASF.General.Controls.Grid();
            this.grpMessage = new RASF.General.Controls.GroupBox();
            this.txtMessage = new RASF.General.Controls.TextBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReceiver)).BeginInit();
            this.grpReceiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessagePast)).BeginInit();
            this.grpMessagePast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).BeginInit();
            this.grpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 461);
            this.pnlButton.Size = new System.Drawing.Size(720, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpMessage);
            this.pnlContent.Controls.Add(this.grpReceiver);
            this.pnlContent.Controls.Add(this.grpMessagePast);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(720, 461);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(515, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(598, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(660, 0);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.label1);
            this.grpFind.Controls.Add(this.searchContract1);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(720, 51);
            this.grpFind.TabIndex = 4;
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(491, 8);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 40);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpReceiver
            // 
            this.grpReceiver.Controls.Add(this.btnSend);
            this.grpReceiver.Controls.Add(this.grdReceiver);
            this.grpReceiver.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpReceiver.Location = new System.Drawing.Point(0, 51);
            this.grpReceiver.Name = "grpReceiver";
            this.grpReceiver.Size = new System.Drawing.Size(267, 252);
            this.grpReceiver.TabIndex = 5;
            this.grpReceiver.Text = "دریافت کننده";
            this.grpReceiver.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(3, 226);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "ارسال";
            this.btnSend.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // grdReceiver
            // 
            this.grdReceiver.AlowRetrieveStructure = false;
            this.grdReceiver.AlternatingColors = true;
            this.grdReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grdReceiver.BuiltInTextsData = resources.GetString("grdReceiver.BuiltInTextsData");
            this.grdReceiver.DataSource = this.laboratory_UserList1;
            this.grdReceiver.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReceiver_DesignTimeLayout.LayoutString = resources.GetString("grdReceiver_DesignTimeLayout.LayoutString");
            this.grdReceiver.DesignTimeLayout = grdReceiver_DesignTimeLayout;
            this.grdReceiver.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReceiver.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReceiver.GroupByBoxVisible = false;
            this.grdReceiver.Location = new System.Drawing.Point(3, 16);
            this.grdReceiver.Name = "grdReceiver";
            this.grdReceiver.Size = new System.Drawing.Size(261, 207);
            this.grdReceiver.TabIndex = 0;
            this.grdReceiver.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReceiver.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpMessagePast
            // 
            this.grpMessagePast.Controls.Add(this.grdMessage);
            this.grpMessagePast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMessagePast.Location = new System.Drawing.Point(0, 303);
            this.grpMessagePast.Name = "grpMessagePast";
            this.grpMessagePast.Size = new System.Drawing.Size(720, 158);
            this.grpMessagePast.TabIndex = 6;
            this.grpMessagePast.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdMessage
            // 
            this.grdMessage.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdMessage.AlowRetrieveStructure = false;
            this.grdMessage.AlternatingColors = true;
            this.grdMessage.BuiltInTextsData = resources.GetString("grdMessage.BuiltInTextsData");
            this.grdMessage.DataSource = this.sendMessageList1;
            this.grdMessage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMessage_DesignTimeLayout.LayoutString = resources.GetString("grdMessage_DesignTimeLayout.LayoutString");
            this.grdMessage.DesignTimeLayout = grdMessage_DesignTimeLayout;
            this.grdMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMessage.GroupByBoxVisible = false;
            this.grdMessage.Location = new System.Drawing.Point(3, 8);
            this.grdMessage.Name = "grdMessage";
            this.grdMessage.Size = new System.Drawing.Size(714, 147);
            this.grdMessage.TabIndex = 0;
            this.grdMessage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdMessage.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.grdMessage_RowDoubleClick);
            // 
            // grpMessage
            // 
            this.grpMessage.Controls.Add(this.txtMessage);
            this.grpMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMessage.Location = new System.Drawing.Point(267, 51);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new System.Drawing.Size(453, 252);
            this.grpMessage.TabIndex = 6;
            this.grpMessage.Text = "متن پیام";
            this.grpMessage.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(3, 17);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(447, 232);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // SendMessage
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 491);
            this.Name = "SendMessage";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SendMessage";
            this.Load += new System.EventHandler(this.SendMessage_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            this.grpFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpReceiver)).EndInit();
            this.grpReceiver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessagePast)).EndInit();
            this.grpMessagePast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpMessage)).EndInit();
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.SendMessageList sendMessageList1;
        private General.Lists.Laboratory_UserList laboratory_UserList1;
        private General.Controls.GroupBox grpMessage;
        private General.Controls.GroupBox grpReceiver;
        private General.Controls.GroupBox grpMessagePast;
        private General.Controls.GroupBox grpFind;
        private General.Controls.Grid grdReceiver;
        private General.Controls.Grid grdMessage;
        private General.Controls.TextBox txtMessage;
        private General.Controls.Save_Button btnSend;
        private Controls.SearchContract searchContract1;
        private General.Controls.Label label1;
    }
}