namespace RASF.Main.Forms.Reports
{
    partial class MetalPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetalPicture));
            Janus.Windows.GridEX.GridEXLayout grdpic_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdpic = new RASF.General.Controls.Grid();
            this.metal_PicList1 = new RASF.General.Lists.Metal_PicList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 457);
            this.pnlButton.Size = new System.Drawing.Size(704, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdpic);
            this.pnlContent.Size = new System.Drawing.Size(704, 457);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(497, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(582, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(644, 0);
            // 
            // grdpic
            // 
            this.grdpic.AlowRetrieveStructure = false;
            this.grdpic.AlternatingColors = true;
            this.grdpic.BuiltInTextsData = resources.GetString("grdpic.BuiltInTextsData");
            this.grdpic.DataSource = this.metal_PicList1;
            this.grdpic.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdpic_DesignTimeLayout.LayoutString = resources.GetString("grdpic_DesignTimeLayout.LayoutString");
            this.grdpic.DesignTimeLayout = grdpic_DesignTimeLayout;
            this.grdpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdpic.GroupByBoxVisible = false;
            this.grdpic.Location = new System.Drawing.Point(0, 0);
            this.grdpic.Name = "grdpic";
            this.grdpic.Size = new System.Drawing.Size(704, 457);
            this.grdpic.TabIndex = 0;
            this.grdpic.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdpic.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // MetalPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(704, 487);
            this.Name = "MetalPicture";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.MetalPicture_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdpic;
        private RASF.General.Lists.Metal_PicList metal_PicList1;
    }
}
