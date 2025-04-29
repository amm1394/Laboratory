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
    public partial class Provinses : RASF.General.Forms.Base.DockContentForm
    {
        public Provinses()
        {
            InitializeComponent();
        }

        private void Provinses_Load(object sender, EventArgs e)
        {
            this.companiesProvincisList1.Fill();
            this.grdProvinces.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesProvincisList1.Update();
        }

        
    }
}
