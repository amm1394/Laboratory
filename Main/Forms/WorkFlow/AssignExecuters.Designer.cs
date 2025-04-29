namespace RASF.Main.Forms.WorkFlow
{
    partial class AssignExecuters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignExecuters));
            Janus.Windows.GridEX.GridEXLayout grdExecuters_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdExecuters = new RASF.General.Controls.Grid();
            this.assignExecutersList1 = new RASF.General.Lists.AssignExecutersList(this.components);
            this.assignGroupList1 = new RASF.General.Lists.AssignGroupList(this.components);
            this.dlgSelectPic = new System.Windows.Forms.OpenFileDialog();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExecuters)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 538);
            this.pnlButton.Size = new System.Drawing.Size(822, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Size = new System.Drawing.Size(822, 538);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(617, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(700, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(762, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdExecuters);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdExecuters
            // 
            this.grdExecuters.AlowRetrieveStructure = false;
            this.grdExecuters.AlternatingColors = true;
            this.grdExecuters.BuiltInTextsData = resources.GetString("grdExecuters.BuiltInTextsData");
            this.grdExecuters.DataSource = this.assignExecutersList1;
            this.grdExecuters.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdExecuters_DesignTimeLayout.LayoutString = resources.GetString("grdExecuters_DesignTimeLayout.LayoutString");
            this.grdExecuters.DesignTimeLayout = grdExecuters_DesignTimeLayout;
            this.grdExecuters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExecuters.GroupByBoxVisible = false;
            this.grdExecuters.Location = new System.Drawing.Point(3, 8);
            this.grdExecuters.Name = "grdExecuters";
            this.grdExecuters.Size = new System.Drawing.Size(816, 527);
            this.grdExecuters.TabIndex = 0;
            this.grdExecuters.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdExecuters.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdExecuters.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdExecuters_ColumnButtonClick);
            // 
            // dlgSelectPic
            // 
            this.dlgSelectPic.DefaultExt = "*.jpg";
            this.dlgSelectPic.Filter = "\"ImageFiles (.png)|*.png";
            this.dlgSelectPic.Title = "فایل تصویر مورد نظر را انتخاب کنید";
            // 
            // AssignExecuters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 568);
            this.Name = "AssignExecuters";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "AssignExecuters";
            this.Load += new System.EventHandler(this.AssignExecuters_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExecuters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdExecuters;
        private General.Lists.AssignExecutersList assignExecutersList1;
        private General.Lists.AssignGroupList assignGroupList1;
        private System.Windows.Forms.OpenFileDialog dlgSelectPic;
    }
}