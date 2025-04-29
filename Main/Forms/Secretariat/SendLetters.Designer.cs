namespace RASF.Main.Forms.Secretariat
{
    partial class SendLetters
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
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCompanyName = new RASF.General.Controls.TextBox();
            this.sendLettersList1 = new RASF.General.Lists.SendLettersList(this.components);
            this.label4 = new RASF.General.Controls.Label();
            this.txtReciever = new RASF.General.Controls.TextBox();
            this.label5 = new RASF.General.Controls.Label();
            this.txtDescForSendType = new RASF.General.Controls.TextBox();
            this.label3 = new RASF.General.Controls.Label();
            this.drpSendType = new RASF.General.Controls.DropDown();
            this.label2 = new RASF.General.Controls.Label();
            this.drpGroup = new RASF.General.Controls.DropDown();
            this.label1 = new RASF.General.Controls.Label();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtSubjectOfLetters = new RASF.General.Controls.TextBox();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.sendTypeList1 = new RASF.General.Lists.SendTypeList(this.components);
            this.actingGroupList1 = new RASF.General.Lists.ActingGroupList(this.components);
            this.partGroupingList1 = new RASF.General.Lists.PartGroupingList(this.components);
            this.letter_Scan1 = new RASF.Main.Controls.Letter_Scan();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlButton.Location = new System.Drawing.Point(0, 785);
            this.pnlButton.Size = new System.Drawing.Size(1705, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1705, 785);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1500, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1583, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1645, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1705, 785);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "نامه های ارسالی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCompanyName);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtReciever);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescForSendType);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.drpSendType);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.drpGroup);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1699, 765);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendLettersList1, "Reciever", true));
            this.txtCompanyName.Location = new System.Drawing.Point(364, 76);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(237, 21);
            this.txtCompanyName.TabIndex = 16;
            this.txtCompanyName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "شرکت";
            // 
            // txtReciever
            // 
            this.txtReciever.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReciever.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendLettersList1, "Reciever", true));
            this.txtReciever.Location = new System.Drawing.Point(39, 77);
            this.txtReciever.Name = "txtReciever";
            this.txtReciever.Size = new System.Drawing.Size(237, 21);
            this.txtReciever.TabIndex = 14;
            this.txtReciever.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "دریافت کننده";
            // 
            // txtDescForSendType
            // 
            this.txtDescForSendType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescForSendType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendLettersList1, "DescForSendType", true));
            this.txtDescForSendType.Location = new System.Drawing.Point(692, 74);
            this.txtDescForSendType.Name = "txtDescForSendType";
            this.txtDescForSendType.Size = new System.Drawing.Size(237, 21);
            this.txtDescForSendType.TabIndex = 10;
            this.txtDescForSendType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(935, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "توضیحات ارسال";
            // 
            // drpSendType
            // 
            this.drpSendType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpSendType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpSendType.Location = new System.Drawing.Point(1128, 77);
            this.drpSendType.Name = "drpSendType";
            this.drpSendType.Size = new System.Drawing.Size(145, 21);
            this.drpSendType.TabIndex = 8;
            this.drpSendType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1279, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "نحوه ارسال";
            // 
            // drpGroup
            // 
            this.drpGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drpGroup.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.drpGroup.Location = new System.Drawing.Point(1439, 77);
            this.drpGroup.Name = "drpGroup";
            this.drpGroup.Size = new System.Drawing.Size(172, 21);
            this.drpGroup.TabIndex = 6;
            this.drpGroup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1644, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "بخش";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSubjectOfLetters);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1699, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "موضوع نامه";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtSubjectOfLetters
            // 
            this.txtSubjectOfLetters.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sendLettersList1, "SubjectOfLetters", true));
            this.txtSubjectOfLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSubjectOfLetters.Location = new System.Drawing.Point(3, 17);
            this.txtSubjectOfLetters.Multiline = true;
            this.txtSubjectOfLetters.Name = "txtSubjectOfLetters";
            this.txtSubjectOfLetters.Size = new System.Drawing.Size(1693, 42);
            this.txtSubjectOfLetters.TabIndex = 0;
            this.txtSubjectOfLetters.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.letter_Scan1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1699, 638);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.Text = "ثبت نامه";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // letter_Scan1
            // 
            this.letter_Scan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letter_Scan1.Document = null;
            this.letter_Scan1.Location = new System.Drawing.Point(3, 17);
            this.letter_Scan1.Name = "letter_Scan1";
            this.letter_Scan1.Size = new System.Drawing.Size(1693, 618);
            this.letter_Scan1.TabIndex = 0;
            // 
            // SendLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1705, 815);
            this.Name = "SendLetters";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "SendLetters";
            this.Load += new System.EventHandler(this.SendLetters_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.Label label1;
        private General.Controls.Label label5;
        private General.Controls.Label label3;
        protected General.Controls.DropDown drpSendType;
        private General.Controls.Label label2;
        protected General.Controls.DropDown drpGroup;
        private General.Controls.Label label4;
        protected General.Controls.TextBox txtSubjectOfLetters;
        protected General.Controls.TextBox txtReciever;
        protected General.Controls.TextBox txtDescForSendType;
        protected General.Controls.TextBox txtCompanyName;
      //  protected Controls.Letter_Scan letter_Scan1;
        protected General.Lists.SendLettersList sendLettersList1;
        protected General.Lists.SendTypeList sendTypeList1;
        protected General.Lists.ActingGroupList actingGroupList1;
        protected General.Lists.PartGroupingList partGroupingList1;
        private Controls.Letter_Scan letter_Scan1;
    }
}