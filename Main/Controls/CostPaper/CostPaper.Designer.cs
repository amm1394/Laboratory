namespace RASF.Main.Controls
{
    partial class SearchContract
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
            this.numContractNo = new RASF.General.Controls.NumberBox();
            this.btnSearch = new RASF.General.Controls.Button();
            this.lab = new RASF.General.Controls.Label();
            this.findContractsCodeList1 = new RASF.General.Lists.FindContractsCodeList(this.components);
            this.SuspendLayout();
            // 
            // numContractNo
            // 
            this.numContractNo.Location = new System.Drawing.Point(85, 5);
            this.numContractNo.Name = "numContractNo";
            this.numContractNo.Size = new System.Drawing.Size(61, 20);
            this.numContractNo.TabIndex = 2;
            this.numContractNo.Text = "0";
            this.numContractNo.Value = 0;
            this.numContractNo.ValueType = Janus.Windows.GridEX.NumericEditValueType.Int32;
            this.numContractNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
            this.numContractNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numContractNo_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearch.Location = new System.Drawing.Point(4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(152, 9);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(71, 13);
            this.lab.TabIndex = 0;
            this.lab.Text = "شماره قرارداد";
            // 
            // SearchContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.numContractNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lab);
            this.Name = "SearchContract";
            this.Size = new System.Drawing.Size(226, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RASF.General.Controls.Label lab;
        private RASF.General.Controls.Button btnSearch;
        private General.Lists.FindContractsCodeList findContractsCodeList1;
        public General.Controls.NumberBox numContractNo;
    }
}
