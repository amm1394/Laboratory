namespace RASF.Main.Forms
{
    partial class MACHINS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MACHINS));
            Janus.Windows.GridEX.GridEXLayout grdMACHINS_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdMACHINS = new RASF.General.Controls.Grid();
            this.machinslist1 = new RASF.General.Lists.Machinslist(this.components);
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.labList1 = new RASF.General.Lists.LaboratoryList(this.components);
            this.userList1 = new RASF.General.Lists.UserList(this.components);
            this.laboratoryMachinList1 = new RASF.General.Lists.LaboratoryMachinList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMACHINS)).BeginInit();
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
            // grdMACHINS
            // 
            this.grdMACHINS.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMACHINS.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdMACHINS.AlowRetrieveStructure = true;
            this.grdMACHINS.AlternatingColors = true;
            this.grdMACHINS.BuiltInTextsData = resources.GetString("grdMACHINS.BuiltInTextsData");
            this.grdMACHINS.DataSource = this.machinslist1;
            this.grdMACHINS.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdMACHINS_DesignTimeLayout.LayoutString = resources.GetString("grdMACHINS_DesignTimeLayout.LayoutString");
            this.grdMACHINS.DesignTimeLayout = grdMACHINS_DesignTimeLayout;
            this.grdMACHINS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMACHINS.GroupByBoxVisible = false;
            this.grdMACHINS.Location = new System.Drawing.Point(0, 0);
            this.grdMACHINS.Name = "grdMACHINS";
            this.grdMACHINS.RecordNavigator = true;
            this.grdMACHINS.Size = new System.Drawing.Size(546, 396);
            this.grdMACHINS.TabIndex = 2;
            this.grdMACHINS.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdMACHINS.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // MACHINS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdMACHINS);
            this.Name = "MACHINS";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.MACHINS_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdMACHINS, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMACHINS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdMACHINS;
        private RASF.General.Lists.Machinslist machinslist1;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;
        private General.Lists.LaboratoryList labList1;
        private General.Lists.UserList userList1;
        private General.Lists.LaboratoryMachinList laboratoryMachinList1;
    }
}
