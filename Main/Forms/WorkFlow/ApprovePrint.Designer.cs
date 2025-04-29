namespace Main.Forms.WorkFlow
{
    partial class ApprovePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApprovePrint));
            Janus.Windows.GridEX.GridEXLayout grdapprove_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.groupBox3 = new RASF.General.Controls.GroupBox();
            this.textBox1 = new RASF.General.Controls.TextBox();
            this.groupBox4 = new RASF.General.Controls.GroupBox();
            this.grdapprove = new RASF.General.Controls.Grid();
            this.approvePrintList1 = new RASF.General.Lists.ApprovePrintList(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdapprove)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Location = new System.Drawing.Point(0, 530);
            this.pnlButton.Size = new System.Drawing.Size(742, 30);
            // 
            // btnExit
            // 
            this.btnExit.Text = "رد";
            // 
            // btnSave
            // 
            this.btnSave.Text = "تایید";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.groupBox4);
            this.pnlContent.Controls.Add(this.groupBox3);
            this.pnlContent.Size = new System.Drawing.Size(742, 530);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Location = new System.Drawing.Point(537, 0);
            // 
            // pnlExit
            // 
            this.pnlExit.Location = new System.Drawing.Point(620, 0);
            // 
            // pnlSave
            // 
            this.pnlSave.Location = new System.Drawing.Point(682, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(742, 144);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.Text = "توضیحات";
            this.groupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(736, 124);
            this.textBox1.TabIndex = 0;
            this.textBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdapprove);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 386);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.Text = "تایید";
            this.groupBox4.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // grdapprove
            // 
            this.grdapprove.AlowRetrieveStructure = false;
            this.grdapprove.AlternatingColors = true;
            this.grdapprove.BuiltInTextsData = resources.GetString("grdapprove.BuiltInTextsData");
            this.grdapprove.DataSource = this.approvePrintList1;
            this.grdapprove.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grdapprove_DesignTimeLayout.LayoutString = resources.GetString("grdapprove_DesignTimeLayout.LayoutString");
            this.grdapprove.DesignTimeLayout = grdapprove_DesignTimeLayout;
            this.grdapprove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdapprove.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdapprove.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdapprove.GroupByBoxVisible = false;
            this.grdapprove.Location = new System.Drawing.Point(3, 17);
            this.grdapprove.Name = "grdapprove";
            this.grdapprove.Size = new System.Drawing.Size(736, 366);
            this.grdapprove.TabIndex = 0;
            this.grdapprove.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdapprove.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2003;
            // 
            // ApprovePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(742, 560);
            this.Name = "ApprovePrint";
            this.ShowpnlButton = true;
            this.ShowpnlExit = true;
            this.ShowpnlSave = true;
            this.ShowpnlUpdate = true;
            this.Load += new System.EventHandler(this.ApprovePrint_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdapprove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.GroupBox groupBox3;
        private RASF.General.Controls.TextBox textBox1;
        private RASF.General.Controls.GroupBox groupBox4;
        private RASF.General.Controls.Grid grdapprove;
        private RASF.General.Lists.ApprovePrintList approvePrintList1;

    }
}
