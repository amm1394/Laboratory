namespace RASF.Main.Forms.Financial
{
    partial class ViewReceiptDemandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReceiptDemandForm));
            Janus.Windows.GridEX.GridEXLayout grdWorkFlow_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grpWorkFlow = new RASF.General.Controls.GroupBox();
            this.grdWorkFlow = new RASF.General.Controls.Grid();
            this.viewReceiptDemandList1 = new RASF.General.Lists.ViewReceiptDemandList(this.components);
            this.btnPrint = new RASF.General.Controls.Button();
            this.pnlPrint = new RASF.General.Controls.Panel();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).BeginInit();
            this.grpWorkFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).BeginInit();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.pnlPrint);
            this.pnlButton.Location = new System.Drawing.Point(0, 585);
            this.pnlButton.Size = new System.Drawing.Size(1021, 30);
            this.pnlButton.Controls.SetChildIndex(this.pnlSave, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlExit, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlUpdate, 0);
            this.pnlButton.Controls.SetChildIndex(this.pnlPrint, 0);
            // 
            // btnExit
            // 
            this.btnExit.Text = "بروزرسانی";
         //   this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
          //  this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpWorkFlow);
            this.pnlContent.Size = new System.Drawing.Size(1021, 585);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(816, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(899, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(961, 0);
            // 
            // grpWorkFlow
            // 
            this.grpWorkFlow.Controls.Add(this.grdWorkFlow);
            this.grpWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWorkFlow.Location = new System.Drawing.Point(0, 0);
            this.grpWorkFlow.Name = "grpWorkFlow";
            this.grpWorkFlow.Size = new System.Drawing.Size(1021, 585);
            this.grpWorkFlow.TabIndex = 1;
            this.grpWorkFlow.Text = "توضیحات";
            this.grpWorkFlow.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdWorkFlow
            // 
            this.grdWorkFlow.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdWorkFlow.AlowRetrieveStructure = false;
            this.grdWorkFlow.AlternatingColors = true;
            this.grdWorkFlow.BuiltInTextsData = resources.GetString("grdWorkFlow.BuiltInTextsData");
            this.grdWorkFlow.DataSource = this.viewReceiptDemandList1;
            this.grdWorkFlow.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdWorkFlow_DesignTimeLayout.LayoutString = resources.GetString("grdWorkFlow_DesignTimeLayout.LayoutString");
            this.grdWorkFlow.DesignTimeLayout = grdWorkFlow_DesignTimeLayout;
            this.grdWorkFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkFlow.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdWorkFlow.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdWorkFlow.GroupByBoxVisible = false;
            this.grdWorkFlow.Location = new System.Drawing.Point(3, 17);
            this.grdWorkFlow.Name = "grdWorkFlow";
            this.grdWorkFlow.Size = new System.Drawing.Size(1015, 565);
            this.grdWorkFlow.TabIndex = 1;
            this.grdWorkFlow.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdWorkFlow.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
         //   this.grdWorkFlow.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdWorkFlow_ColumnButtonClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(3, 1);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 26);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
          //  this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlPrint
            // 
            this.pnlPrint.Controls.Add(this.btnPrint);
            this.pnlPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPrint.Location = new System.Drawing.Point(745, 0);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(71, 30);
            this.pnlPrint.TabIndex = 5;
            // 
            // ViewReceiptDemandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1021, 615);
            this.Name = "ViewReceiptDemandForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.CompanyWorkFlow_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpWorkFlow)).EndInit();
            this.grpWorkFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkFlow)).EndInit();
            this.pnlPrint.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox grpWorkFlow;
        private General.Controls.Grid grdWorkFlow;
        private General.Controls.Button btnPrint;
        private General.Controls.Panel pnlPrint;
        private General.Lists.ViewReceiptDemandList viewReceiptDemandList1;
    }
}
