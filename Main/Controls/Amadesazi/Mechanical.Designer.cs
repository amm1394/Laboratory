namespace RASF.Main.Controls.Amadesazi
{
    partial class Mechanical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mechanical));
            Janus.Windows.GridEX.GridEXLayout grid1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grid1 = new RASF.General.Controls.Grid();
            this.mechanicalLabDeliveryList1 = new RASF.General.Lists.MechanicalLabDeliveryList(this.components);
            this.panel1 = new RASF.General.Controls.Panel();
            this.panel3 = new RASF.General.Controls.Panel();
            this.panel6 = new RASF.General.Controls.Panel();
            this.panel8 = new RASF.General.Controls.Panel();
            this.label2 = new RASF.General.Controls.Label();
            this.label5 = new RASF.General.Controls.Label();
            this.panel10 = new RASF.General.Controls.Panel();
            this.label8 = new RASF.General.Controls.Label();
            this.label9 = new RASF.General.Controls.Label();
            this.panel9 = new RASF.General.Controls.Panel();
            this.panel7 = new RASF.General.Controls.Panel();
            this.label6 = new RASF.General.Controls.Label();
            this.label7 = new RASF.General.Controls.Label();
            this.panel5 = new RASF.General.Controls.Panel();
            this.label3 = new RASF.General.Controls.Label();
            this.label4 = new RASF.General.Controls.Label();
            this.panel4 = new RASF.General.Controls.Panel();
            this.label1 = new RASF.General.Controls.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grid1
            // 
            this.grid1.AllowCardSizing = false;
            this.grid1.AllowColumnDrag = false;
            this.grid1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grid1.AlowRetrieveStructure = false;
            this.grid1.AlternatingColors = true;
            this.grid1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(191)))));
            this.grid1.BackColor = System.Drawing.Color.Black;
            this.grid1.BuiltInTextsData = resources.GetString("grid1.BuiltInTextsData");
            this.grid1.DataSource = this.mechanicalLabDeliveryList1;
            this.grid1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            grid1_DesignTimeLayout.LayoutString = resources.GetString("grid1_DesignTimeLayout.LayoutString");
            this.grid1.DesignTimeLayout = grid1_DesignTimeLayout;
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.Font = new System.Drawing.Font("B Titr", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.grid1.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
            this.grid1.GroupByBoxVisible = false;
            this.grid1.HeaderFormatStyle.BackColor = System.Drawing.Color.Empty;
            this.grid1.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.Empty;
            this.grid1.Location = new System.Drawing.Point(0, 150);
            this.grid1.Name = "grid1";
            this.grid1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grid1.RowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(98)))));
            this.grid1.RowFormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(210)))), ((int)(((byte)(97)))));
            this.grid1.Size = new System.Drawing.Size(408, 465);
            this.grid1.TabIndex = 1;
            this.grid1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grid1.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2010;
            this.grid1.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.grid1_FormattingRow);
            this.grid1.SizeChanged += new System.EventHandler(this.grid1_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 86);
            this.panel3.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(208, 86);
            this.panel6.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(208, 53);
            this.panel8.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 53);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 53);
            this.label5.TabIndex = 2;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(208, 33);
            this.panel10.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 33);
            this.label8.TabIndex = 3;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Blue;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(53, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 33);
            this.label9.TabIndex = 2;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(208, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 86);
            this.panel9.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 53);
            this.panel7.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 53);
            this.label6.TabIndex = 3;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 53);
            this.label7.TabIndex = 2;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 33);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 33);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Font = new System.Drawing.Font("B Titr", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 33);
            this.label4.TabIndex = 2;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 64);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("B Titr", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mechanical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.panel1);
            this.Name = "Mechanical";
            this.Size = new System.Drawing.Size(408, 615);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RASF.General.Controls.Panel panel1;
        private RASF.General.Controls.Panel panel3;
        private RASF.General.Controls.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private RASF.General.Controls.Label label1;
        private General.Controls.Label label4;
        private General.Controls.Grid grid1;
        private General.Controls.Panel panel5;
        private General.Controls.Panel panel7;
        private General.Controls.Label label6;
        private General.Controls.Label label7;
        private General.Controls.Label label3;
        private General.Controls.Panel panel6;
        private General.Controls.Panel panel8;
        private General.Controls.Label label2;
        private General.Controls.Label label5;
        private General.Controls.Panel panel10;
        private General.Controls.Label label8;
        private General.Controls.Label label9;
        private General.Controls.Panel panel9;
        private General.Lists.MechanicalLabDeliveryList mechanicalLabDeliveryList1;
    }
}
