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
    public partial class DockContentForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public DockContentForm()
        {
            InitializeComponent();
            this.pnlUpdate.Visible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
        }
        /// <summary>
        /// در صورتی که فرم نباید بسته شود این 
        /// Property
        /// را به حالت 
        /// true
        /// درآید فرم بسته نخواهد شد
        /// </summary>
        public Boolean IsAllowClosed { get; set; }
        [Browsable(false)]
        public Form MyMdiParent { get; set; }

        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler Save
        {
            add { this.btnSave.Click += value; }
            remove { this.btnSave.Click -= value; }
        }

        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler Update
        {
            add { this.btnUpdate.Click += value; }
            remove { this.btnUpdate.Click -= value; }
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

        public Boolean ShowpnlUpdate
        {
            get { return this.pnlUpdate.Visible; }
            set { this.pnlUpdate.Visible = value; }
        }

        [System.ComponentModel.Category("RASF")]
        public Boolean ShowpnlButton
        {
            get { return this.pnlButton.Visible; }
            set { this.pnlButton.Visible = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            IsAllowClosed = false;
        }

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = IsAllowClosed;
        }

        public void ShowDocument(WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1)
        {
            this.Show(dockPanel1);
        }
    }
}
