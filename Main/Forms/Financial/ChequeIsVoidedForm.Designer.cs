namespace RASF.Main.Forms.Financial
{
    partial class ChequeIsVoidedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeIsVoidedForm));
            Janus.Windows.GridEX.GridEXLayout grdCheque_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.chequeNoPassedList1 = new RASF.General.Lists.ChequeNoPassedList(this.components);
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grdCheque = new RASF.General.Controls.Grid();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
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
            this.btnExit.Text = "ابطال رسید";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Size = new System.Drawing.Size(720, 526);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Text = "بروزرسانی";
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
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grdCheque);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(720, 526);
            this.grpGrid.TabIndex = 7;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.grdCheque.Size = new System.Drawing.Size(714, 515);
            this.grdCheque.TabIndex = 8;
            this.grdCheque.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCheque.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCheque.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdCheque.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCheque_ColumnButtonClick);
            // 
            // ChequeIsVoidedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 556);
            this.Name = "ChequeIsVoidedForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCheque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Lists.ChequeNoPassedList chequeNoPassedList1;
        private General.Controls.GroupBox grpGrid;
        private General.Controls.Grid grdCheque;
    }
}