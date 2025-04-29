namespace RAFS.Main.Forms
{
    partial class Chash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chash));
            Janus.Windows.GridEX.GridEXLayout grdCash_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCash = new RASF.General.Controls.Grid();
            this.cashList1 = new RASF.General.Lists.CashList(this.components);
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.userList1 = new RASF.General.Lists.UserList(this.components);
            this.companiesAgencyListList1 = new RASF.General.Lists.CompaniesAgencyListList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).BeginInit();
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
            // grdCash
            // 
            this.grdCash.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCash.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCash.AlowRetrieveStructure = true;
            this.grdCash.AlternatingColors = true;
            this.grdCash.BuiltInTextsData = resources.GetString("grdCash.BuiltInTextsData");
            this.grdCash.DataSource = this.cashList1;
            this.grdCash.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCash_DesignTimeLayout.LayoutString = resources.GetString("grdCash_DesignTimeLayout.LayoutString");
            this.grdCash.DesignTimeLayout = grdCash_DesignTimeLayout;
            this.grdCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCash.GroupByBoxVisible = false;
            this.grdCash.Location = new System.Drawing.Point(0, 0);
            this.grdCash.Name = "grdCash";
            this.grdCash.RecordNavigator = true;
            this.grdCash.Size = new System.Drawing.Size(546, 396);
            this.grdCash.TabIndex = 2;
            this.grdCash.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCash.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Chash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdCash);
            this.Name = "Chash";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.Chash_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdCash, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdCash;
        private RASF.General.Lists.CashList cashList1;
        private RASF.General.Lists.ActiveNonActiveList activeNonActiveList1;
        private RASF.General.Lists.UserList userList1;
        private RASF.General.Lists.CompaniesAgencyListList companiesAgencyListList1;
    }
}
