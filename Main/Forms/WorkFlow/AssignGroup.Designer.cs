namespace RASF.Main.Forms.WorkFlow
{
    partial class AssignGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignGroup));
            Janus.Windows.GridEX.GridEXLayout grdAssign_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpAssign = new RASF.General.Controls.GroupBox();
            this.grdAssign = new RASF.General.Controls.Grid();
            this.laboratoryForWorkFlowList1 = new RASF.General.Lists.LaboratoryForWorkFlowList(this.components);
            this.assignGroupList1 = new RASF.General.Lists.AssignGroupList(this.components);
            this.dlgSelectPic = new System.Windows.Forms.OpenFileDialog();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAssign)).BeginInit();
            this.grpAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssign)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 537);
            this.pnlButton.Size = new System.Drawing.Size(807, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpAssign);
            this.pnlContent.Size = new System.Drawing.Size(807, 537);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(602, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(685, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(747, 0);
            // 
            // grpAssign
            // 
            this.grpAssign.Controls.Add(this.grdAssign);
            this.grpAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAssign.Location = new System.Drawing.Point(0, 0);
            this.grpAssign.Name = "grpAssign";
            this.grpAssign.Size = new System.Drawing.Size(807, 537);
            this.grpAssign.TabIndex = 0;
            this.grpAssign.Text = "اختصاص گروه ها";
            this.grpAssign.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdAssign
            // 
            this.grdAssign.AlowRetrieveStructure = false;
            this.grdAssign.AlternatingColors = true;
            this.grdAssign.BuiltInTextsData = resources.GetString("grdAssign.BuiltInTextsData");
            this.grdAssign.DataSource = this.laboratoryForWorkFlowList1;
            this.grdAssign.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdAssign_DesignTimeLayout.LayoutString = resources.GetString("grdAssign_DesignTimeLayout.LayoutString");
            this.grdAssign.DesignTimeLayout = grdAssign_DesignTimeLayout;
            this.grdAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAssign.GroupByBoxVisible = false;
            this.grdAssign.Location = new System.Drawing.Point(3, 17);
            this.grdAssign.Name = "grdAssign";
            this.grdAssign.Size = new System.Drawing.Size(801, 517);
            this.grdAssign.TabIndex = 0;
            this.grdAssign.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdAssign.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdAssign.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdAssign_ColumnButtonClick);
            // 
            // dlgSelectPic
            // 
            this.dlgSelectPic.DefaultExt = "*.jpg";
            this.dlgSelectPic.Filter = "\"ImageFiles (.png)|*.png";
            this.dlgSelectPic.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // AssignGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(807, 567);
            this.Name = "AssignGroup";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.AssignGroup_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpAssign)).EndInit();
            this.grpAssign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpAssign;
        private General.Controls.Grid grdAssign;
        private General.Lists.LaboratoryForWorkFlowList laboratoryForWorkFlowList1;
        private General.Lists.AssignGroupList assignGroupList1;
        private System.Windows.Forms.OpenFileDialog dlgSelectPic;
    }
}
