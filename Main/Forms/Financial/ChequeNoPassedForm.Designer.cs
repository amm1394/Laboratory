namespace RASF.Main.Forms.Financial
{
    partial class ChequeNoPassedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeNoPassedForm));
            Janus.Windows.GridEX.GridEXLayout grdCheque_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpDate = new RASF.General.Controls.GroupBox();
            this.chequeNoPassedList1 = new RASF.General.Lists.ChequeNoPassedList(this.components);
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtReason = new RASF.General.Controls.TextBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.grdCheque = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).BeginInit();
            this.grpText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheque)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 526);
            this.pnlButton.Size = new System.Drawing.Size(720, 30);
            // 
            // btnExit
            // 
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpText);
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Controls.Add(this.grpDate);
            this.pnlContent.Size = new System.Drawing.Size(720, 526);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // grpDate
            // 
            this.grpDate.Controls.Add(this.pickDate1);
            this.grpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDate.Location = new System.Drawing.Point(0, 0);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(720, 50);
            this.grpDate.TabIndex = 6;
            this.grpDate.Text = "انتخاب محدوده زمانی";
            this.grpDate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdCheque);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 50);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(720, 289);
            this.grpGrid.TabIndex = 7;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtReason);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpText.Location = new System.Drawing.Point(0, 339);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(720, 187);
            this.grpText.TabIndex = 8;
            this.grpText.Text = "علت باطل کردن قرارداد";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReason
            // 
            this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chequeNoPassedList1, "Description", true));
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(3, 17);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(714, 167);
            this.txtReason.TabIndex = 0;
            this.txtReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(293, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 30);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // grdCheque
            // 
            this.grdCheque.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCheque.AlowRetrieveStructure = false;
            this.grdCheque.AlternatingColors = true;
            this.grdCheque.BuiltInTextsData = resources.GetString("grdCheque.BuiltInTextsData");
            this.grdCheque.DataSource = this.chequeNoPassedList1;
            this.grdCheque.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCheque_DesignTimeLayout.LayoutString = resources.GetString("grdCheque_DesignTimeLayout.LayoutString");
            this.grdCheque.DesignTimeLayout = grdCheque_DesignTimeLayout;
            this.grdCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCheque.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCheque.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCheque.GroupByBoxVisible = false;
            this.grdCheque.Location = new System.Drawing.Point(3, 8);
            this.grdCheque.Name = "grdCheque";
            this.grdCheque.RecordNavigator = true;
            this.grdCheque.Size = new System.Drawing.Size(714, 278);
            this.grdCheque.TabIndex = 8;
            this.grdCheque.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCheque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCheque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ChequeNoPassedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 556);
            this.Name = "ChequeNoPassedForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ReceiveChequeForm";
            this.Load += new System.EventHandler(this.ReceiveChequeForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCheque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpDate;
        private Controls.PickDate.PickDate pickDate1;
        private General.Lists.ChequeNoPassedList chequeNoPassedList1;
        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtReason;
        private General.Controls.Grid grdCheque;
    }
}