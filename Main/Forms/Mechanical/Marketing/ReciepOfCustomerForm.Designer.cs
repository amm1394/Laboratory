namespace RASF.Main.Forms.Marketing
{
    partial class ReciepOfCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciepOfCustomerForm));
            Janus.Windows.GridEX.GridEXLayout grdReciept_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox1 = new RASF.General.Controls.GroupBox();
            this.grdReciept = new RASF.General.Controls.Grid();
            this.reciepOfCustomerList1 = new RASF.General.Lists.ReciepOfCustomerList(this.components);
            this.groupBox2 = new RASF.General.Controls.GroupBox();
            this.pickDate1 = new RASF.Main.Controls.PickDate.PickDate();
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReciept)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 628);
            this.pnlButton.Size = new System.Drawing.Size(937, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox1);
            this.pnlContent.Controls.Add(this.groupBox2);
            this.pnlContent.Size = new System.Drawing.Size(937, 628);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(732, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(815, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(877, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdReciept);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 582);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdReciept
            // 
            this.grdReciept.AlowRetrieveStructure = false;
            this.grdReciept.AlternatingColors = true;
            this.grdReciept.BuiltInTextsData = resources.GetString("grdReciept.BuiltInTextsData");
            this.grdReciept.DataSource = this.reciepOfCustomerList1;
            this.grdReciept.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdReciept_DesignTimeLayout.LayoutString = resources.GetString("grdReciept_DesignTimeLayout.LayoutString");
            this.grdReciept.DesignTimeLayout = grdReciept_DesignTimeLayout;
            this.grdReciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReciept.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdReciept.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdReciept.GroupByBoxVisible = false;
            this.grdReciept.Location = new System.Drawing.Point(3, 8);
            this.grdReciept.Name = "grdReciept";
            this.grdReciept.Size = new System.Drawing.Size(931, 571);
            this.grdReciept.TabIndex = 0;
            this.grdReciept.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdReciept.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pickDate1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(937, 46);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "تاریخ پذیرش";
            this.groupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // pickDate1
            // 
            this.pickDate1.BackColor = System.Drawing.Color.Transparent;
            this.pickDate1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pickDate1.Location = new System.Drawing.Point(510, 17);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(424, 26);
            this.pickDate1.TabIndex = 0;
            this.pickDate1.DateSelected += new RASF.General.Events.ReturnSelectedDates(this.pickDate1_DateSelected);
            // 
            // ReciepOfCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(937, 658);
            this.Name = "ReciepOfCustomerForm";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ReciepOfCustomerForm_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReciept)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private General.Controls.GroupBox groupBox2;
        private Controls.PickDate.PickDate pickDate1;
        private General.Controls.GroupBox groupBox1;
        private General.Controls.Grid grdReciept;
        private General.Lists.ReciepOfCustomerList reciepOfCustomerList1;
    }
}
