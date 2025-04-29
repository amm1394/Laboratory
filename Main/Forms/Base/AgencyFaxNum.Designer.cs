namespace Main.Forms.Base
{
    partial class AgencyFaxNum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyFaxNum));
            Janus.Windows.GridEX.GridEXLayout grdAgencyFaxNum_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdAgencyFaxNum = new RASF.General.Controls.Grid();
            this.agencyFaxNumList1 = new RASF.General.Lists.AgencyFaxNumList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyFaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 396);
            this.pnlButton.Size = new System.Drawing.Size(546, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdAgencyFaxNum);
            this.pnlContent.Size = new System.Drawing.Size(546, 396);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(339, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(424, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(486, 0);
            // 
            // grdAgencyFaxNum
            // 
            this.grdAgencyFaxNum.AlowRetrieveStructure = false;
            this.grdAgencyFaxNum.AlternatingColors = true;
            this.grdAgencyFaxNum.BuiltInTextsData = resources.GetString("grdAgencyFaxNum.BuiltInTextsData");
            this.grdAgencyFaxNum.DataSource = this.agencyFaxNumList1;
            this.grdAgencyFaxNum.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAgencyFaxNum_DesignTimeLayout.LayoutString = resources.GetString("grdAgencyFaxNum_DesignTimeLayout.LayoutString");
            this.grdAgencyFaxNum.DesignTimeLayout = grdAgencyFaxNum_DesignTimeLayout;
            this.grdAgencyFaxNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAgencyFaxNum.GroupByBoxVisible = false;
            this.grdAgencyFaxNum.Location = new System.Drawing.Point(0, 0);
            this.grdAgencyFaxNum.Name = "grdAgencyFaxNum";
            this.grdAgencyFaxNum.Size = new System.Drawing.Size(546, 396);
            this.grdAgencyFaxNum.TabIndex = 0;
            this.grdAgencyFaxNum.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAgencyFaxNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // AgencyFaxNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Name = "AgencyFaxNum";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAgencyFaxNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdAgencyFaxNum;
        private RASF.General.Lists.AgencyFaxNumList agencyFaxNumList1;
    }
}
