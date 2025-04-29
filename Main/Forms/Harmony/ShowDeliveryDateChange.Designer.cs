namespace RASF.Main.Forms.Harmony
{
    partial class ShowDeliveryDateChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDeliveryDateChange));
            Janus.Windows.GridEX.GridEXLayout grdChangeDelivery_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpFind = new RASF.General.Controls.GroupBox();
            this.searchContract1 = new RASF.Main.Controls.SearchContract();
            this.grpgrid = new RASF.General.Controls.GroupBox();
            this.grdChangeDelivery = new RASF.General.Controls.Grid();
            this.showDeliveryDateChangeList1 = new RASF.General.Lists.ShowDeliveryDateChangeList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).BeginInit();
            this.grpFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).BeginInit();
            this.grpgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 450);
            this.pnlButton.Size = new System.Drawing.Size(779, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpgrid);
            this.pnlContent.Controls.Add(this.grpFind);
            this.pnlContent.Size = new System.Drawing.Size(779, 450);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(877, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(657, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(719, 0);
            // 
            // grpFind
            // 
            this.grpFind.Controls.Add(this.searchContract1);
            this.grpFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFind.Location = new System.Drawing.Point(0, 0);
            this.grpFind.Name = "grpFind";
            this.grpFind.Size = new System.Drawing.Size(779, 51);
            this.grpFind.TabIndex = 4;
            this.grpFind.Text = "جستجو";
            this.grpFind.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // searchContract1
            // 
            this.searchContract1.BackColor = System.Drawing.Color.Transparent;
            this.searchContract1.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchContract1.Location = new System.Drawing.Point(550, 17);
            this.searchContract1.Name = "searchContract1";
            this.searchContract1.Size = new System.Drawing.Size(226, 31);
            this.searchContract1.TabIndex = 0;
            this.searchContract1.ReturnContractsCode += new RASF.General.Events.ReturnContractsCode(this.searchContract1_ReturnContractsCode);
            // 
            // grpgrid
            // 
            this.grpgrid.Controls.Add(this.grdChangeDelivery);
            this.grpgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpgrid.Location = new System.Drawing.Point(0, 51);
            this.grpgrid.Name = "grpgrid";
            this.grpgrid.Size = new System.Drawing.Size(779, 399);
            this.grpgrid.TabIndex = 5;
            this.grpgrid.Text = "تغییرات تاریخ";
            this.grpgrid.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdChangeDelivery
            // 
            this.grdChangeDelivery.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdChangeDelivery.AlowRetrieveStructure = false;
            this.grdChangeDelivery.AlternatingColors = true;
            this.grdChangeDelivery.BuiltInTextsData = resources.GetString("grdChangeDelivery.BuiltInTextsData");
            this.grdChangeDelivery.DataSource = this.showDeliveryDateChangeList1;
            this.grdChangeDelivery.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdChangeDelivery_DesignTimeLayout.LayoutString = resources.GetString("grdChangeDelivery_DesignTimeLayout.LayoutString");
            this.grdChangeDelivery.DesignTimeLayout = grdChangeDelivery_DesignTimeLayout;
            this.grdChangeDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChangeDelivery.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdChangeDelivery.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdChangeDelivery.GroupByBoxVisible = false;
            this.grdChangeDelivery.Location = new System.Drawing.Point(3, 17);
            this.grdChangeDelivery.Name = "grdChangeDelivery";
            this.grdChangeDelivery.Size = new System.Drawing.Size(773, 379);
            this.grdChangeDelivery.TabIndex = 0;
            this.grdChangeDelivery.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdChangeDelivery.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ShowDeliveryDateChange
            // 
            this.AcceptButton = null;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(779, 480);
            this.Name = "ShowDeliveryDateChange";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpFind)).EndInit();
            this.grpFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpgrid)).EndInit();
            this.grpgrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChangeDelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox grpFind;
        private RASF.General.Controls.GroupBox grpgrid;
        private RASF.General.Controls.Grid grdChangeDelivery;
        private RASF.General.Lists.ShowDeliveryDateChangeList showDeliveryDateChangeList1;
        private RASF.Main.Controls.SearchContract searchContract1;

    }
}
