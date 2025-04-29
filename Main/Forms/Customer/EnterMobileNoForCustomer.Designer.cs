namespace RASF.Main.Forms.Customer
{
    partial class EnterMobileNoForCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMobileNoForCustomer));
            Janus.Windows.GridEX.GridEXLayout grdCompany_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCompany = new RASF.General.Controls.Grid();
            this.enterMobileNoForCustomerList1 = new RASF.General.Lists.EnterMobileNoForCustomerList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 366);
            this.pnlButton.Size = new System.Drawing.Size(675, 30);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdCompany);
            this.pnlContent.Size = new System.Drawing.Size(675, 366);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1071, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(553, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(615, 0);
            // 
            // grdCompany
            // 
            this.grdCompany.AlowRetrieveStructure = false;
            this.grdCompany.AlternatingColors = true;
            this.grdCompany.BuiltInTextsData = resources.GetString("grdCompany.BuiltInTextsData");
            this.grdCompany.DataSource = this.enterMobileNoForCustomerList1;
            this.grdCompany.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCompany_DesignTimeLayout.LayoutString = resources.GetString("grdCompany_DesignTimeLayout.LayoutString");
            this.grdCompany.DesignTimeLayout = grdCompany_DesignTimeLayout;
            this.grdCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCompany.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCompany.GroupByBoxVisible = false;
            this.grdCompany.Location = new System.Drawing.Point(0, 0);
            this.grdCompany.Name = "grdCompany";
            this.grdCompany.RecordNavigator = true;
            this.grdCompany.Size = new System.Drawing.Size(675, 366);
            this.grdCompany.TabIndex = 0;
            this.grdCompany.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCompany.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // EnterMobileNoForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 396);
            this.Name = "EnterMobileNoForCustomer";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "Banks";
            this.Save += new System.EventHandler(this.Banks_Save);
            this.Load += new System.EventHandler(this.Banks_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdCompany;
        private General.Lists.EnterMobileNoForCustomerList enterMobileNoForCustomerList1;


    }
}