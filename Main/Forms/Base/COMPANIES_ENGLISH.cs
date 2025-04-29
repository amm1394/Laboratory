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
    public partial class COMPANIES_ENGLISH : RASF.General.Forms.Base.DockContentForm
    {
        public COMPANIES_ENGLISH()
        {
            InitializeComponent();
        }

        private void COMPANIES_ENGLISH_Load(object sender, EventArgs e)
        {
            this.companiesEnglishList1.Fill();
            this.grdCOMPANIES_ENGLISH.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesEnglishList1.Update();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
