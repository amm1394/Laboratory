namespace RASF.Main.Forms.Harmony
{
    partial class OnceMeetCustomerToBonyad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnceMeetCustomerToBonyad));
            Janus.Windows.GridEX.GridEXLayout grdCustomer_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdCustomer = new RASF.General.Controls.Grid();
            this.onceMeetOfBonyadList1 = new RASF.General.Lists.OnceMeetOfBonyadList(this.components);
            this.grpCompany = new RASF.General.Controls.GroupBox();
            this.grpdate = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).BeginInit();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).BeginInit();
            this.grpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 640);
            this.pnlButton.Size = new System.Drawing.Size(1459, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grpCompany);
            this.pnlContent.Controls.Add(this.grpdate);
            this.pnlContent.Size = new System.Drawing.Size(1459, 640);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(3222, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(1337, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(1399, 0);
            // 
            // grdCustomer
            // 
            this.grdCustomer.AlowRetrieveStructure = false;
            this.grdCustomer.AlternatingColors = true;
            this.grdCustomer.BuiltInTextsData = resources.GetString("grdCustomer.BuiltInTextsData");
            this.grdCustomer.DataSource = this.onceMeetOfBonyadList1;
            this.grdCustomer.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdCustomer_DesignTimeLayout.LayoutString = resources.GetString("grdCustomer_DesignTimeLayout.LayoutString");
            this.grdCustomer.DesignTimeLayout = grdCustomer_DesignTimeLayout;
            this.grdCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomer.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCustomer.GroupByBoxVisible = false;
            this.grdCustomer.Location = new System.Drawing.Point(3, 8);
            this.grdCustomer.Name = "grdCustomer";
            this.grdCustomer.RecordNavigator = true;
            this.grdCustomer.Size = new System.Drawing.Size(1453, 574);
            this.grdCustomer.TabIndex = 0;
            this.grdCustomer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdCustomer.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.grdCustomer);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Location = new System.Drawing.Point(0, 55);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(1459, 585);
            this.grpCompany.TabIndex = 1;
            this.grpCompany.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grpdate
            // 
            this.grpdate.Controls.Add(this.pickDate1);
            this.grpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpdate.Location = new System.Drawing.Point(0, 0);
            this.grpdate.Name = "grpdate";
            this.grpdate.Size = new System.Drawing.Size(1459, 55);
            this.grpdate.TabIndex = 2;
            this.grpdate.Text = "تاریخ ";
            this.grpdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(1032, 16);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 36);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // OnceMeetCustomerToBonyad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 670);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "OnceMeetCustomerToBonyad";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Text = "OnceMeetCustomerToBonyad";
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCompany)).EndInit();
            this.grpCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpdate)).EndInit();
            this.grpdate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.Grid grdCustomer;
        private General.Lists.OnceMeetOfBonyadList onceMeetOfBonyadList1;
        private General.Controls.GroupBox grpCompany;
        private General.Controls.GroupBox grpdate;
        private Controls.PickDate.PickDate pickDate1;
    }
}