using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class HasCD : RASF.General.Forms.Base.DockContentForm
    {
        public HasCD()
        {
            InitializeComponent();
        }

        private void HasCD_Load(object sender, EventArgs e)
        {
            this.hasCdMasterList1.Fill();
            this.grdCD.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.hasCdMasterList1.Update();

            this.hasCdMasterList1.Fill();
            this.grdCD.Refetch();
        }
    }
}
