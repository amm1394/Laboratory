namespace RASF.Main.Forms.Reception
{
    partial class CompaniesEnglishReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesEnglishReport));
            Janus.Windows.GridEX.GridEXLayout grdEnglish_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.companiesEnglishList1 = new RASF.General.Lists.CompaniesEnglishList(this.components);
            this.grdEnglish = new RASF.General.Controls.Grid();
            this.pnlContent.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEnglish)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.grdEnglish);
            this.pnlContent.Size = new System.Drawing.Size(833, 149);
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 149);
            this.pnlButton.Size = new System.Drawing.Size(833, 30);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(1485, 0);
            // 
            // grdEnglish
            // 
            this.grdEnglish.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdEnglish.AlowRetrieveStructure = false;
            this.grdEnglish.AlternatingColors = true;
            this.grdEnglish.BuiltInTextsData = resources.GetString("grdEnglish.BuiltInTextsData");
            this.grdEnglish.DataSource = this.companiesEnglishList1;
            this.grdEnglish.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdEnglish_DesignTimeLayout.LayoutString = resources.GetString("grdEnglish_DesignTimeLayout.LayoutString");
            this.grdEnglish.DesignTimeLayout = grdEnglish_DesignTimeLayout;
            this.grdEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEnglish.GroupByBoxVisible = false;
            this.grdEnglish.Location = new System.Drawing.Point(0, 0);
            this.grdEnglish.Name = "grdEnglish";
            this.grdEnglish.Size = new System.Drawing.Size(833, 149);
            this.grdEnglish.TabIndex = 2;
            this.grdEnglish.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdEnglish.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // CompaniesEnglishReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 179);
            this.ControlBox = false;
            this.Name = "CompaniesEnglishReport";
            this.ShowpnlButton = true;
            this.ShowpnlSave = true;
            this.Text = "ثبت نام انگلیسی شرکت";
            this.Load += new System.EventHandler(this.CompaniesEnglishReport_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEnglish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Lists.CompaniesEnglishList companiesEnglishList1;
        private General.Controls.Grid grdEnglish;
    }
}