using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class Banks : RASF.General.Forms.Base.DockContentForm
    {
        public Banks()
        {
            InitializeComponent();
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            this.banksList1.Fill();
            this.activeNonActiveList1.Fill();
            this.grdBank.Refetch();

            this.grdBank.RemoveBindingContextChanged();

            General.Classes.Utility.Create_DropDown(this.grdBank.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            this.grdBank.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;
       }

        private void Banks_Save(object sender, EventArgs e)
        {
            this.banksList1.Update();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
