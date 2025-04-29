namespace RASF.Main.Forms.Harmony
{
    partial class DetailOfReceptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailOfReceptionForm));
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDetail = new RASF.General.Controls.Grid();
            this.detailOfReceptionList1 = new RASF.General.Lists.DetailOfReceptionList(this.components);
            this.label5 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 512);
            this.pnlButton.Size = new System.Drawing.Size(1142, 30);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(1142, 512);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(937, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1020, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1082, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickDate1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1142, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.Text = "تاریخ پذیرش";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(715, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1142, 466);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.Text = "جزئیات پذیرش";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDetail
            // 
            this.grdDetail.AlowRetrieveStructure = false;
            this.grdDetail.AlternatingColors = true;
            this.grdDetail.BuiltInTextsData = resources.GetString("grdDetail.BuiltInTextsData");
            this.grdDetail.DataSource = this.detailOfReceptionList1;
            this.grdDetail.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDetail_DesignTimeLayout.LayoutString = resources.GetString("grdDetail_DesignTimeLayout.LayoutString");
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDetail.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDetail.GroupByBoxVisible = false;
            this.grdDetail.Location = new System.Drawing.Point(3, 17);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RecordNavigator = true;
            this.grdDetail.Size = new System.Drawing.Size(1136, 446);
            this.grdDetail.TabIndex = 0;
            this.grdDetail.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDetail.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDetail.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdDetail_FormattingRow);
            this.grdDetail.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdDetail_ColumnButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "مشتری جدید";
            // 
            // DetailOfReceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1142, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetailOfReceptionForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.DetailOfReceptionForm_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.Main.Controls.PickDate.PickDate pickDate1;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.Grid grdDetail;
        private General.Lists.DetailOfReceptionList detailOfReceptionList1;
        private General.Controls.Label label5;
    }
}
