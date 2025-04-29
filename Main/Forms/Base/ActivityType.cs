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
    public partial class ActivityType : RASF.General.Forms.Base.DockContentForm
    {
        public ActivityType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesActivityTypeList1.Update();
        }

        private void ActivityType_Load(object sender, EventArgs e)
        {
            this.companiesActivityTypeList1.Fill();
            this.grdActivityType.Refetch(); 
        }
    }
}
