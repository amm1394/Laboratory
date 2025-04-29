namespace RASF.Main.Forms.Manager
{
    partial class ContractsInPending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractsInPending));
            Janus.Windows.GridEX.GridEXLayout grdDelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.grdDelivery = new RASF.General.Controls.Grid();
            this.contractsInPendingList1 = new RASF.General.Lists.ContractsInPendingList(this.components);
            this.label5 = new RASF.General.Controls.Label();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.label5);
            this.pnlButton.Location = new System.Drawing.Point(0, 540);
            this.pnlButton.Size = new System.Drawing.Size(1086, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.label5, 0);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(1086, 540);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(881, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(964, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1026, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdDelivery);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 540);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "قراردادهای در دست انجام";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdDelivery
            // 
            this.grdDelivery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDelivery.AlowRetrieveStructure = false;
            this.grdDelivery.AlternatingColors = true;
            this.grdDelivery.BuiltInTextsData = resources.GetString("grdDelivery.BuiltInTextsData");
            this.grdDelivery.DataSource = this.contractsInPendingList1;
            this.grdDelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdDelivery_DesignTimeLayout.LayoutString = resources.GetString("grdDelivery_DesignTimeLayout.LayoutString");
            this.grdDelivery.DesignTimeLayout = grdDelivery_DesignTimeLayout;
            this.grdDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDelivery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdDelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdDelivery.GroupByBoxVisible = false;
            this.grdDelivery.Location = new System.Drawing.Point(3, 17);
            this.grdDelivery.Name = "grdDelivery";
            this.grdDelivery.RecordNavigator = true;
            this.grdDelivery.Size = new System.Drawing.Size(1080, 520);
            this.grdDelivery.TabIndex = 0;
            this.grdDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdDelivery.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grdDelivery.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdDelivery_FormattingRow);
            this.grdDelivery.LoadingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grdDelivery_LoadingRow);
            this.grdDelivery.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdContracts_ColumnButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Plum;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "مشتری جدید";
            // 
            // ContractsInPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1086, 570);
            this.Name = "ContractsInPending";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "قراردادهای در دست انجام ";
            this.Load += new System.EventHandler(this.DeliveryDayForManager_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private General.Controls.Grid grdDelivery;
        private General.Lists.ContractsInPendingList contractsInPendingList1;
        private General.Controls.Label label5;
    }
}
