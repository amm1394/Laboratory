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
    public partial class COMPANIES_FAXNUM : RASF.General.Forms.Base.DockContentForm
    {
        public COMPANIES_FAXNUM()
        {
            InitializeComponent();
        }

        private void COMPANIES_FAXNUM_Load(object sender, EventArgs e)
        {
            this.companiesFaxNumList1.Fill();
            this.grdCOMPANIES_FAXNUM.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesFaxNumList1.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
