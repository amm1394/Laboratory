namespace RASF.Main.Forms.BillsReports
{
    partial class ContractMatters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractMatters));
            Janus.Windows.GridEX.GridEXLayout grdBills_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdBills = new RASF.General.Controls.Grid();
            this.billsissuedList1 = new RASF.General.Lists.BillsissuedList(this.components);
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.button1 = new RASF.General.Controls.Button();
            this.txtRegion = new RASF.General.Controls.TextBox();
            this.label5 = new RASF.General.Controls.Label();
            this.txtReferal = new RASF.General.Controls.TextBox();
            this.label4 = new RASF.General.Controls.Label();
            this.txtPost = new RASF.General.Controls.TextBox();
            this.label3 = new RASF.General.Controls.Label();
            this.TxtPhone = new RASF.General.Controls.TextBox();
            this.label2 = new RASF.General.Controls.Label();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.label1 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 733);
            this.pnlButton.Size = new System.Drawing.Size(1276, 30);
            // 
            // btnSave
            // 
            this.btnSave.Text = "ذخیره در EX";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(1276, 733);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1154, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1216, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1276, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "محدوده زمانی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(849, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 37);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdBills);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1276, 599);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "صورت حساب های صادر شده";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdBills
            // 
            this.grdBills.AlowRetrieveStructure = false;
            this.grdBills.AlternatingColors = true;
            this.grdBills.BuiltInTextsData = resources.GetString("grdBills.BuiltInTextsData");
            this.grdBills.DataSource = this.billsissuedList1;
            this.grdBills.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBills_DesignTimeLayout.LayoutString = resources.GetString("grdBills_DesignTimeLayout.LayoutString");
            this.grdBills.DesignTimeLayout = grdBills_DesignTimeLayout;
            this.grdBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBills.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdBills.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdBills.GroupByBoxVisible = false;
            this.grdBills.Location = new System.Drawing.Point(3, 17);
            this.grdBills.Name = "grdBills";
            this.grdBills.RecordNavigator = true;
            this.grdBills.Size = new System.Drawing.Size(1270, 579);
            this.grdBills.TabIndex = 0;
            this.grdBills.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBills.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBills.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdBills.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdBills_ColumnButtonClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtRegion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtReferal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtPhone);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDesc);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 656);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1276, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(142, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "ثبت";
            this.button1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.Location = new System.Drawing.Point(307, 47);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(181, 21);
            this.txtRegion.TabIndex = 9;
            this.txtRegion.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(494, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "منطقه";
            // 
            // txtReferal
            // 
            this.txtReferal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReferal.Location = new System.Drawing.Point(307, 12);
            this.txtReferal.Name = "txtReferal";
            this.txtReferal.Size = new System.Drawing.Size(181, 21);
            this.txtReferal.TabIndex = 7;
            this.txtReferal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(494, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "مراجعه";
            // 
            // txtPost
            // 
            this.txtPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPost.Location = new System.Drawing.Point(554, 50);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(181, 21);
            this.txtPost.TabIndex = 5;
            this.txtPost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(741, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "پست";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPhone.Location = new System.Drawing.Point(554, 12);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(181, 21);
            this.TxtPhone.TabIndex = 3;
            this.TxtPhone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(741, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "تماس";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(816, 14);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(384, 57);
            this.txtDesc.TabIndex = 1;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1206, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "شرح وضعیت";
            // 
            // ContractMatters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 763);
            this.Name = "ContractMatters";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdBills;
        private General.Lists.BillsissuedList billsissuedList1;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox txtRegion;
        private General.Controls.Label label5;
        private General.Controls.TextBox txtReferal;
        private General.Controls.Label label4;
        private General.Controls.TextBox txtPost;
        private General.Controls.Label label3;
        private General.Controls.TextBox TxtPhone;
        private General.Controls.Label label2;
        private General.Controls.TextBox txtDesc;
        private General.Controls.Label label1;
        private General.Controls.Button button1;
    }
}
