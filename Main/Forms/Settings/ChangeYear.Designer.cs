namespace RASF.Main.Forms.Settings
{
    partial class ChangeYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeYear));
            Janus.Windows.GridEX.GridEXLayout grdYear_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdYear = new RASF.General.Controls.Grid();
            this.changeYearList1 = new RASF.General.Lists.ChangeYearList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYear)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 227);
            this.pnlButton.Size = new System.Drawing.Size(382, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdYear);
            this.pnlContent.Size = new System.Drawing.Size(382, 227);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(175, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(260, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(322, 0);
            // 
            // grdYear
            // 
            this.grdYear.AlowRetrieveStructure = false;
            this.grdYear.AlternatingColors = true;
            this.grdYear.BuiltInTextsData = resources.GetString("grdYear.BuiltInTextsData");
            this.grdYear.DataSource = this.changeYearList1;
            this.grdYear.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdYear_DesignTimeLayout.LayoutString = resources.GetString("grdYear_DesignTimeLayout.LayoutString");
            this.grdYear.DesignTimeLayout = grdYear_DesignTimeLayout;
            this.grdYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdYear.GroupByBoxVisible = false;
            this.grdYear.Location = new System.Drawing.Point(0, 0);
            this.grdYear.Name = "grdYear";
            this.grdYear.Size = new System.Drawing.Size(382, 227);
            this.grdYear.TabIndex = 0;
            this.grdYear.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdYear.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdYear.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdYear_ColumnButtonClick);
            // 
            // ChangeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 257);
            this.Name = "ChangeYear";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "ChangeYear";
            this.Load += new System.EventHandler(this.ChangeYear_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdYear;
        private General.Lists.ChangeYearList changeYearList1;
    }
}