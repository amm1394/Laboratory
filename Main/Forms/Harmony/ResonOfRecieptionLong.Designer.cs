namespace RASF.Main.Forms.Harmony
{
    partial class ResonOfRecieptionLong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResonOfRecieptionLong));
            Janus.Windows.GridEX.GridEXLayout grddilatory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpGrid = new RASF.General.Controls.GroupBox();
            this.grddilatory = new RASF.General.Controls.Grid();
            this.resonOfRecieptionLongList1 = new RASF.General.Lists.ResonOfRecieptionLongList(this.components);
            this.grpText = new RASF.General.Controls.GroupBox();
            this.txtReason = new RASF.General.Controls.TextBox();
            this.chkvalid = new RASF.General.Controls.CheckBox();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).BeginInit();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grddilatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).BeginInit();
            this.grpText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 501);
            this.pnlButton.Size = new System.Drawing.Size(971, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.chkvalid);
            this.pnlContent.Controls.Add(this.grpText);
            this.pnlContent.Controls.Add(this.grpGrid);
            this.pnlContent.Size = new System.Drawing.Size(971, 501);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(766, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(849, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(911, 0);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.grddilatory);
            this.grpGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGrid.Location = new System.Drawing.Point(0, 0);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(971, 289);
            this.grpGrid.TabIndex = 0;
            this.grpGrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grddilatory
            // 
            this.grddilatory.AlowRetrieveStructure = false;
            this.grddilatory.AlternatingColors = true;
            this.grddilatory.BuiltInTextsData = resources.GetString("grddilatory.BuiltInTextsData");
            this.grddilatory.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.resonOfRecieptionLongList1, "Description", true));
            this.grddilatory.DataSource = this.resonOfRecieptionLongList1;
            this.grddilatory.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grddilatory_DesignTimeLayout.LayoutString = resources.GetString("grddilatory_DesignTimeLayout.LayoutString");
            this.grddilatory.DesignTimeLayout = grddilatory_DesignTimeLayout;
            this.grddilatory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grddilatory.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grddilatory.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grddilatory.GroupByBoxVisible = false;
            this.grddilatory.Location = new System.Drawing.Point(3, 8);
            this.grddilatory.Name = "grddilatory";
            this.grddilatory.Size = new System.Drawing.Size(965, 278);
            this.grddilatory.TabIndex = 0;
            this.grddilatory.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grddilatory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grddilatory.SelectionChanged += new System.EventHandler(this.grdIsHold_SelectionChanged);
            // 
            // grpText
            // 
            this.grpText.Controls.Add(this.txtReason);
            this.grpText.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpText.Location = new System.Drawing.Point(0, 289);
            this.grpText.Name = "grpText";
            this.grpText.Size = new System.Drawing.Size(971, 177);
            this.grpText.TabIndex = 1;
            this.grpText.Text = "علت طولانی بودن پذیرش";
            this.grpText.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReason
            // 
            this.txtReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resonOfRecieptionLongList1, "Description", true));
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Location = new System.Drawing.Point(3, 17);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(965, 157);
            this.txtReason.TabIndex = 0;
            this.txtReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkvalid
            // 
            this.chkvalid.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkvalid.Location = new System.Drawing.Point(867, 466);
            this.chkvalid.Name = "chkvalid";
            this.chkvalid.Size = new System.Drawing.Size(104, 35);
            this.chkvalid.TabIndex = 2;
            this.chkvalid.Text = "موجه";
            this.chkvalid.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // ResonOfRecieptionLong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Name = "ResonOfRecieptionLong";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ثبت علت پذیرش های طولانی";
            this.Load += new System.EventHandler(this.IsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGrid)).EndInit();
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grddilatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpText)).EndInit();
            this.grpText.ResumeLayout(false);
            this.grpText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpGrid;
        private General.Controls.GroupBox grpText;
        private General.Controls.TextBox txtReason;
        private General.Controls.Grid grddilatory;
        private General.Lists.ResonOfRecieptionLongList resonOfRecieptionLongList1;
        private General.Controls.CheckBox chkvalid;
    }
}