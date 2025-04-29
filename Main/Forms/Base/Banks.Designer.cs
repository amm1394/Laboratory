namespace RASF.Main.Forms
{
    partial class Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banks));
            Janus.Windows.GridEX.GridEXLayout grdBank_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdBank = new RASF.General.Controls.Grid();
            this.banksList1 = new RASF.General.Lists.BanksList(this.components);
            this.activeNonActiveList1 = new RASF.General.Lists.ActiveNonActiveList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBank)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 314);
            this.pnlButton.Size = new System.Drawing.Size(416, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdBank);
            this.pnlContent.Size = new System.Drawing.Size(416, 314);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(211, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(294, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(356, 0);
            // 
            // grdBank
            // 
            this.grdBank.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBank.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdBank.AlowRetrieveStructure = true;
            this.grdBank.AlternatingColors = true;
            this.grdBank.BuiltInTextsData = resources.GetString("grdBank.BuiltInTextsData");
            this.grdBank.DataSource = this.banksList1;
            this.grdBank.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdBank_DesignTimeLayout.LayoutString = resources.GetString("grdBank_DesignTimeLayout.LayoutString");
            this.grdBank.DesignTimeLayout = grdBank_DesignTimeLayout;
            this.grdBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBank.GroupByBoxVisible = false;
            this.grdBank.Location = new System.Drawing.Point(0, 0);
            this.grdBank.Name = "grdBank";
            this.grdBank.RecordNavigator = true;
            this.grdBank.Size = new System.Drawing.Size(416, 314);
            this.grdBank.TabIndex = 0;
            this.grdBank.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 344);
            this.Name = "Banks";
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
            ((System.ComponentModel.ISupportInitialize)(this.grdBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grdBank;
        private RASF.General.Lists.BanksList banksList1;
        private General.Lists.ActiveNonActiveList activeNonActiveList1;


    }
}