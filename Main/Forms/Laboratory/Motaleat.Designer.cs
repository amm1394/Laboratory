namespace RASF.Main.Forms.Laboratory
{
    partial class Motaleat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motaleat));
            Janus.Windows.GridEX.GridEXLayout grid1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grid1 = new RASF.General.Controls.Grid();
            this.motaleatList1 = new RASF.General.Lists.MotaleatList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 674);
            this.pnlButton.Size = new System.Drawing.Size(1091, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grid1);
            this.pnlContent.Size = new System.Drawing.Size(1091, 674);
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
            // grid1
            // 
            this.grid1.AlowRetrieveStructure = false;
            this.grid1.AlternatingColors = true;
            this.grid1.BuiltInTextsData = resources.GetString("grid1.BuiltInTextsData");
            this.grid1.DataSource = this.motaleatList1;
            this.grid1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid1_DesignTimeLayout.LayoutString = resources.GetString("grid1_DesignTimeLayout.LayoutString");
            this.grid1.DesignTimeLayout = grid1_DesignTimeLayout;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.GroupByBoxVisible = false;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(1091, 674);
            this.grid1.TabIndex = 0;
            this.grid1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Motaleat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 704);
            this.Name = "Motaleat";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Motaleat";
            this.Load += new System.EventHandler(this.Motaleat_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grid1;
        private General.Lists.MotaleatList motaleatList1;
    }
}