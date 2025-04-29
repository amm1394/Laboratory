namespace Arl.Forms
{
    partial class Insert_Arl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Arl));
            Janus.Windows.GridEX.GridEXLayout grid3_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grid3 = new RASF.General.Controls.Grid();
            this.arlList1 = new RASF.General.Lists.ArlList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.btnExit = new RASF.General.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid3
            // 
            this.grid3.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grid3.AlowRetrieveStructure = false;
            this.grid3.AlternatingColors = true;
            this.grid3.BuiltInTextsData = resources.GetString("grid3.BuiltInTextsData");
            this.grid3.DataSource = this.arlList1;
            this.grid3.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid3_DesignTimeLayout.LayoutString = resources.GetString("grid3_DesignTimeLayout.LayoutString");
            this.grid3.DesignTimeLayout = grid3_DesignTimeLayout;
            this.grid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid3.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grid3.GroupByBoxVisible = false;
            this.grid3.Location = new System.Drawing.Point(0, 0);
            this.grid3.Name = "grid3";
            this.grid3.Size = new System.Drawing.Size(519, 217);
            this.grid3.TabIndex = 2;
            this.grid3.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            this.grid3.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grid3_ColumnButtonClick);
            // 
            // arlList1
            // 
            this.arlList1.FileName = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(432, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "خروج";
            this.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Insert_Arl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 261);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.panel1);
            this.Name = "Insert_Arl";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Insert_Arl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private RASF.General.Controls.Panel panel1;
        private RASF.General.Lists.ArlList arlList1;
        private RASF.General.Controls.Grid grid3;
        private RASF.General.Controls.Button btnExit;
    }
}