namespace RASF.Main.Forms.Harmony
{
    partial class CancelIsHoldForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelIsHoldForm));
            Janus.Windows.GridEX.GridEXLayout grdCancelIsHold_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCancelIsHold = new RASF.General.Controls.Grid();
            this.cancel_Contracts_IsHoldList1 = new RASF.General.Lists.Cancel_Contracts_IsHoldList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelIsHold)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(797, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCancelIsHold);
            this.pnlContent.Size = new System.Drawing.Size(797, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(590, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(675, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(737, 0);
            // 
            // grdCancelIsHold
            // 
            this.grdCancelIsHold.AlowRetrieveStructure = false;
            this.grdCancelIsHold.AlternatingColors = true;
            this.grdCancelIsHold.BuiltInTextsData = resources.GetString("grdCancelIsHold.BuiltInTextsData");
            this.grdCancelIsHold.DataSource = this.cancel_Contracts_IsHoldList1;
            this.grdCancelIsHold.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCancelIsHold_DesignTimeLayout.LayoutString = resources.GetString("grdCancelIsHold_DesignTimeLayout.LayoutString");
            this.grdCancelIsHold.DesignTimeLayout = grdCancelIsHold_DesignTimeLayout;
            this.grdCancelIsHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCancelIsHold.GroupByBoxVisible = false;
            this.grdCancelIsHold.Hierarchical = true;
            this.grdCancelIsHold.Location = new System.Drawing.Point(0, 0);
            this.grdCancelIsHold.Name = "grdCancelIsHold";
            this.grdCancelIsHold.Size = new System.Drawing.Size(797, 396);
            this.grdCancelIsHold.TabIndex = 0;
            this.grdCancelIsHold.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCancelIsHold.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CancelIsHoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 426);
            this.Name = "CancelIsHoldForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "CancelIsHoldForm";
            this.Load += new System.EventHandler(this.CancelIsHoldForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCancelIsHold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdCancelIsHold;
        private General.Lists.Cancel_Contracts_IsHoldList cancel_Contracts_IsHoldList1;
    }
}