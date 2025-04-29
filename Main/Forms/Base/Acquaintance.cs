using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class Acquaintance : RASF.General.Forms.Base.DockContentForm
    {
        public Acquaintance()
        {
            InitializeComponent();
        }

        private void Acquaintance_Load(object sender, EventArgs e)
        {
            this.companiesAcqaintanceList1.Fill();
            this.grdAcquaintance.Refetch();

           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesAcqaintanceList1.Update();
        }
    }
}
