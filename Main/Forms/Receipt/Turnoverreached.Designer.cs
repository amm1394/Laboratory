namespace RASF.Main.Forms.Receipt
{
    partial class Turnoverreached
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turnoverreached));
            Janus.Windows.GridEX.GridEXLayout grdAmount_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdAmount = new RASF.General.Controls.Grid();
            this.turnoverreachedList1 = new RASF.General.Lists.TurnoverreachedList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(693, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Size = new System.Drawing.Size(693, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(486, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(571, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(633, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdAmount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 396);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAmount
            // 
            this.grdAmount.AlowRetrieveStructure = false;
            this.grdAmount.AlternatingColors = true;
            this.grdAmount.BuiltInTextsData = resources.GetString("grdAmount.BuiltInTextsData");
            this.grdAmount.DataSource = this.turnoverreachedList1;
            this.grdAmount.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAmount_DesignTimeLayout.LayoutString = resources.GetString("grdAmount_DesignTimeLayout.LayoutString");
            this.grdAmount.DesignTimeLayout = grdAmount_DesignTimeLayout;
            this.grdAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAmount.GroupByBoxVisible = false;
            this.grdAmount.Location = new System.Drawing.Point(3, 8);
            this.grdAmount.Name = "grdAmount";
            this.grdAmount.Size = new System.Drawing.Size(687, 385);
            this.grdAmount.TabIndex = 0;
            this.grdAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAmount.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Turnoverreached
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(693, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "Turnoverreached";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Turnoverreached_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdAmount;
        private General.Lists.TurnoverreachedList turnoverreachedList1;
    }
}
