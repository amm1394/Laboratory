using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Main.Forms.Base
{
    public partial class AgencyFaxNum : RASF.General.Forms.Base.DockContentForm
    {
        public AgencyFaxNum()
        {
            InitializeComponent();

            this.agencyFaxNumList1.Fill();

            this.grdAgencyFaxNum.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.agencyFaxNumList1.Update();
        }

    }
}
