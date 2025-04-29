namespace RASF.Main.Forms
{
    partial class OperationType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperationType));
            Janus.Windows.GridEX.GridEXLayout grdOperatinType_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdOperatinType = new RASF.General.Controls.Grid();
            this.companiesCooperationTypeList1 = new RASF.General.Lists.CompaniesCooperationTypeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOperatinType)).BeginInit();
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
            // grdOperatinType
            // 
            this.grdOperatinType.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdOperatinType.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdOperatinType.AlowRetrieveStructure = true;
            this.grdOperatinType.AlternatingColors = true;
            this.grdOperatinType.BuiltInTextsData = resources.GetString("grdOperatinType.BuiltInTextsData");
            this.grdOperatinType.DataSource = this.companiesCooperationTypeList1;
            this.grdOperatinType.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdOperatinType_DesignTimeLayout.LayoutString = resources.GetString("grdOperatinType_DesignTimeLayout.LayoutString");
            this.grdOperatinType.DesignTimeLayout = grdOperatinType_DesignTimeLayout;
            this.grdOperatinType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOperatinType.GroupByBoxVisible = false;
            this.grdOperatinType.Location = new System.Drawing.Point(0, 0);
            this.grdOperatinType.Name = "grdOperatinType";
            this.grdOperatinType.RecordNavigator = true;
            this.grdOperatinType.Size = new System.Drawing.Size(546, 396);
            this.grdOperatinType.TabIndex = 2;
            this.grdOperatinType.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdOperatinType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // OperationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.grdOperatinType);
            this.Name = "OperationType";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.OperationType_Load);
            this.Controls.SetChildIndex(this.pnlButton, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.grdOperatinType, 0);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOperatinType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdOperatinType;
        private General.Lists.CompaniesCooperationTypeList companiesCooperationTypeList1;
    }
}
