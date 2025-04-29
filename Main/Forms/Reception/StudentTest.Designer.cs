namespace RASF.Main.Forms.Reception
{
    partial class StudentTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentTest));
            Janus.Windows.GridEX.GridEXLayout grid1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grid1 = new RASF.General.Controls.Grid();
            this.panel1 = new RASF.General.Controls.Panel();
            this.btnSave = new RASF.General.Controls.Button();
            this.receiptStudentList1 = new RASF.General.Lists.ReceiptStudentList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AlowRetrieveStructure = true;
            this.grid1.AlternatingColors = true;
            this.grid1.BuiltInTextsData = resources.GetString("grid1.BuiltInTextsData");
            this.grid1.DataSource = this.receiptStudentList1;
            this.grid1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid1_DesignTimeLayout.LayoutString = resources.GetString("grid1_DesignTimeLayout.LayoutString");
            this.grid1.DesignTimeLayout = grid1_DesignTimeLayout;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grid1.GroupByBoxVisible = false;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(993, 424);
            this.grid1.TabIndex = 4;
            this.grid1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 40);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(929, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(52, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "ثبت";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // StudentTest
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 464);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentTest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Grid grid1;
        private RASF.General.Controls.Panel panel1;
        private General.Controls.Button btnSave;
        private General.Lists.ReceiptStudentList receiptStudentList1;
    }
}