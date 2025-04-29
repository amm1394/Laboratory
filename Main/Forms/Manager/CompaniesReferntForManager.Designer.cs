namespace RASF.Main.Forms.Manager
{
    partial class CompaniesReferntForManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesReferntForManager));
            Janus.Windows.GridEX.GridEXLayout grdCompaneis_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.companiesReferntList1 = new RASF.General.Lists.CompaniesReferntList(this.components);
            this.grdCompaneis = new RASF.General.Controls.Grid();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grpdate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.label6 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaneis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).BeginInit();
            this.grpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label6);
            this.pnlButton.Location = new System.Drawing.Point(0, 579);
            this.pnlButton.Size = new System.Drawing.Size(1091, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label6, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "چاپ";
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.grpdate);
            this.pnlContent.Size = new System.Drawing.Size(1091, 579);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(886, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(969, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1031, 0);
            // 
            // grdCompaneis
            // 
            this.grdCompaneis.AlowRetrieveStructure = false;
            this.grdCompaneis.AlternatingColors = true;
            this.grdCompaneis.BuiltInTextsData = resources.GetString("grdCompaneis.BuiltInTextsData");
            this.grdCompaneis.DataSource = this.companiesReferntList1;
            this.grdCompaneis.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompaneis_DesignTimeLayout.LayoutString = resources.GetString("grdCompaneis_DesignTimeLayout.LayoutString");
            this.grdCompaneis.DesignTimeLayout = grdCompaneis_DesignTimeLayout;
            this.grdCompaneis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompaneis.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompaneis.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCompaneis.GroupByBoxVisible = false;
            this.grdCompaneis.Location = new System.Drawing.Point(3, 8);
            this.grdCompaneis.Name = "grdCompaneis";
            this.grdCompaneis.RecordNavigator = true;
            this.grdCompaneis.Size = new System.Drawing.Size(1085, 513);
            this.grdCompaneis.TabIndex = 0;
            this.grdCompaneis.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompaneis.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCompaneis.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCompaneis.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdCompaneis_FormattingRow);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdCompaneis);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.pickDate1);
            this.grpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpdate.Location = new System.Drawing.Point(0, 0);
            this.grpdate.Name = "grpdate";
            this.grpdate.Size = new System.Drawing.Size(1091, 55);
            this.grpdate.TabIndex = 3;
            this.grpdate.Text = "تاریخ پذیرش";
            this.grpdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(664, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 35);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Plum;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "مشتری جدید";
            // 
            // CompaniesReferntForManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1091, 609);
            this.Name = "CompaniesReferntForManager";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CompaniesReferntForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompaneis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).EndInit();
            this.grpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.CompaniesReferntList companiesReferntList1;
        private RASF.General.Controls.Grid grdCompaneis;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.GroupBox grpdate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.Label label6;
    }
}
