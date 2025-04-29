using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.General.Forms.Base
{
    public partial class GeneralForm : Form
    {
        /// <summary>
        /// در صورتی که فرم نباید بسته شود این 
        /// Property
        /// را به حالت 
        /// true
        /// درآید فرم بسته نخواهد شد
        /// </summary>
        public Boolean IsAllowClosed { get; set; }

        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler Save
        {
            add { this.btnSave.Click += value; }
            remove { this.btnSave.Click -= value; }
        }

        [System.ComponentModel.Category("RASF")]
        public Boolean ShowpnlSave
        {
            get { return this.pnlSave.Visible; }
            set { this.pnlSave.Visible = value; }
        }

        [System.ComponentModel.Category("RASF")]
        public Boolean ShowpnlExit
        {
            get { return this.pnlExit.Visible; }
            set { this.pnlExit.Visible = value; }
        }

        [System.ComponentModel.Category("RASF")]
        public Boolean ShowpnlButton
        {
            get { return this.pnlButton.Visible; }
            set { this.pnlButton.Visible = value; }
        }

        public GeneralForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            IsAllowClosed = false;
//            this.Close();            
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = IsAllowClosed;
        }
    }
}
