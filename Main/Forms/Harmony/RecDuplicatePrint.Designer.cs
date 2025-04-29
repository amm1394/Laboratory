namespace RASF.Main.Forms.Harmony
{
    partial class RecDuplicatePrint
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
            Janus.Windows.GridEX.GridEXLayout grdDuplicate_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecDuplicatePrint));
            Janus.Windows.GridEX.GridEXLayout grdReprint_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCopy_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdDuplicate = new RASF.General.Controls.Grid();
            this.recDuplicatePrintList1 = new RASF.General.Lists.RecDuplicatePrintList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.txtDesc = new RASF.General.Controls.TextBox();
            this.tabControl1 = new RASF.General.Controls.TabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grdReprint = new RASF.General.Controls.Grid();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.txtReprint = new RASF.General.Controls.TextBox();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.groupBox6 = new RASF.General.Controls.GroupBox();
            this.grdCopy = new RASF.General.Controls.Grid();
            this.groupBox5 = new RASF.General.Controls.GroupBox();
            this.txtCopy = new RASF.General.Controls.TextBox();
            this.copyPrintList1 = new RASF.General.Lists.CopyPrintList(this.components);
            this.repeatePrintList1 = new RASF.General.Lists.RepeatePrintList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDuplicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 503);
            this.pnlButton.Size = new System.Drawing.Size(749, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.tabControl1);
            this.pnlContent.Size = new System.Drawing.Size(749, 503);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(544, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(627, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(689, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdDuplicate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "درخواست چاپ المثنی";
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDuplicate
            // 
            this.grdDuplicate.AlowRetrieveStructure = false;
            this.grdDuplicate.AlternatingColors = true;
            this.grdDuplicate.BuiltInTextsData = resources.GetString("grdDuplicate.BuiltInTextsData");
            this.grdDuplicate.DataSource = this.recDuplicatePrintList1;
            this.grdDuplicate.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDuplicate_DesignTimeLayout.LayoutString = resources.GetString("grdDuplicate_DesignTimeLayout.LayoutString");
            this.grdDuplicate.DesignTimeLayout = grdDuplicate_DesignTimeLayout;
            this.grdDuplicate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDuplicate.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDuplicate.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDuplicate.GroupByBoxVisible = false;
            this.grdDuplicate.Location = new System.Drawing.Point(3, 17);
            this.grdDuplicate.Name = "grdDuplicate";
            this.grdDuplicate.Size = new System.Drawing.Size(739, 459);
            this.grdDuplicate.TabIndex = 0;
            this.grdDuplicate.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDuplicate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "توضیحات";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDesc
            // 
            this.txtDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.recDuplicatePrintList1, "RecDescription", true));
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(3, 17);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(739, 124);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(749, 503);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2,
            this.uiTabPage3});
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.groupBox4);
            this.uiTabPage1.Controls.Add(this.groupBox3);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(745, 479);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "چاپ مجدد";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdReprint);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 335);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.Text = "درخواست چاپ مجدد";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReprint
            // 
            this.grdReprint.AlowRetrieveStructure = false;
            this.grdReprint.AlternatingColors = true;
            this.grdReprint.BuiltInTextsData = resources.GetString("grdReprint.BuiltInTextsData");
            this.grdReprint.DataSource = this.repeatePrintList1;
            this.grdReprint.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReprint_DesignTimeLayout.LayoutString = resources.GetString("grdReprint_DesignTimeLayout.LayoutString");
            this.grdReprint.DesignTimeLayout = grdReprint_DesignTimeLayout;
            this.grdReprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReprint.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReprint.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReprint.GroupByBoxVisible = false;
            this.grdReprint.Location = new System.Drawing.Point(3, 17);
            this.grdReprint.Name = "grdReprint";
            this.grdReprint.Size = new System.Drawing.Size(739, 315);
            this.grdReprint.TabIndex = 0;
            this.grdReprint.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReprint.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReprint);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 144);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReprint
            // 
            this.txtReprint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.repeatePrintList1, "RecDescription", true));
            this.txtReprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReprint.Location = new System.Drawing.Point(3, 17);
            this.txtReprint.Multiline = true;
            this.txtReprint.Name = "txtReprint";
            this.txtReprint.Size = new System.Drawing.Size(739, 124);
            this.txtReprint.TabIndex = 0;
            this.txtReprint.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.groupBox2);
            this.uiTabPage2.Controls.Add(this.groupBox1);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(745, 479);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "چاپ المثنی";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.groupBox6);
            this.uiTabPage3.Controls.Add(this.groupBox5);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 21);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(745, 479);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "چاپ کپی برابر اصل";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.grdCopy);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(745, 335);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.Text = "درخواست چاپ کپی برابر اصل";
            this.groupBox6.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdCopy
            // 
            this.grdCopy.AlowRetrieveStructure = false;
            this.grdCopy.AlternatingColors = true;
            this.grdCopy.BuiltInTextsData = resources.GetString("grdCopy.BuiltInTextsData");
            this.grdCopy.DataSource = this.copyPrintList1;
            this.grdCopy.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCopy_DesignTimeLayout.LayoutString = resources.GetString("grdCopy_DesignTimeLayout.LayoutString");
            this.grdCopy.DesignTimeLayout = grdCopy_DesignTimeLayout;
            this.grdCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCopy.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCopy.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCopy.GroupByBoxVisible = false;
            this.grdCopy.Location = new System.Drawing.Point(3, 17);
            this.grdCopy.Name = "grdCopy";
            this.grdCopy.Size = new System.Drawing.Size(739, 315);
            this.grdCopy.TabIndex = 0;
            this.grdCopy.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCopy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCopy);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(745, 144);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.Text = "توضیحات";
            this.groupBox5.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtCopy
            // 
            this.txtCopy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.copyPrintList1, "RecDescription", true));
            this.txtCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCopy.Location = new System.Drawing.Point(3, 17);
            this.txtCopy.Multiline = true;
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(739, 124);
            this.txtCopy.TabIndex = 0;
            this.txtCopy.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // RecDuplicatePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(749, 533);
            this.Name = "RecDuplicatePrint";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.RecDuplicatePrint_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDuplicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox1;
        private RASF.General.Controls.Grid grdDuplicate;
        private RASF.General.Controls.GroupBox groupBox2;
        private RASF.General.Controls.TextBox txtDesc;
        private RASF.General.Lists.RecDuplicatePrintList recDuplicatePrintList1;
        private General.Controls.TabControl tabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private General.Controls.GroupBox groupBox4;
        private General.Controls.Grid grdReprint;
        private General.Controls.GroupBox groupBox3;
        private General.Controls.TextBox txtReprint;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private General.Controls.GroupBox groupBox6;
        private General.Controls.Grid grdCopy;
        private General.Controls.GroupBox groupBox5;
        private General.Controls.TextBox txtCopy;
        private General.Lists.RepeatePrintList repeatePrintList1;
        private General.Lists.CopyPrintList copyPrintList1;
    }
}
