namespace RASF.Main.Forms.Message
{
    partial class OpenMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenMessage));
            Janus.Windows.GridEX.GridEXLayout grdShowMessage_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdShowMessage = new RASF.General.Controls.Grid();
            this.readOfUnreadMessageList1 = new RASF.General.Lists.ReadOfUnreadMessageList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdShowMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 498);
            this.pnlButton.Size = new System.Drawing.Size(769, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdShowMessage);
            this.pnlContent.Size = new System.Drawing.Size(769, 498);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(564, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(647, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(709, 0);
            // 
            // grdShowMessage
            // 
            this.grdShowMessage.AlowRetrieveStructure = false;
            this.grdShowMessage.AlternatingColors = true;
            this.grdShowMessage.BuiltInTextsData = resources.GetString("grdShowMessage.BuiltInTextsData");
            this.grdShowMessage.DataSource = this.readOfUnreadMessageList1;
            this.grdShowMessage.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdShowMessage_DesignTimeLayout.LayoutString = resources.GetString("grdShowMessage_DesignTimeLayout.LayoutString");
            this.grdShowMessage.DesignTimeLayout = grdShowMessage_DesignTimeLayout;
            this.grdShowMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdShowMessage.GroupByBoxVisible = false;
            this.grdShowMessage.Location = new System.Drawing.Point(0, 0);
            this.grdShowMessage.Name = "grdShowMessage";
            this.grdShowMessage.Size = new System.Drawing.Size(769, 498);
            this.grdShowMessage.TabIndex = 0;
            this.grdShowMessage.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdShowMessage.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdShowMessage.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdShowMessage_ColumnButtonClick);
            // 
            // OpenMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 528);
            this.Name = "OpenMessage";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "OpenMessage";
            this.Load += new System.EventHandler(this.OpenMessage_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdShowMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdShowMessage;
        private General.Lists.ReadOfUnreadMessageList readOfUnreadMessageList1;
    }
}