using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class LaboratoryMachin : RASF.General.Forms.Base.DockContentForm
    {
        public LaboratoryMachin()
        {
            InitializeComponent();
        }

        private void LaboratoryMachin_Load(object sender, EventArgs e)
        {
            this.laboratoryMachinList1.Fill();

            this.grdMachin.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.laboratoryMachinList1.Update();
        }

      
    }
}
