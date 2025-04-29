using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class Executers : RASF.General.Forms.Base.DockContentForm
    {
        public Executers()
        {
            InitializeComponent();
           this.findUsersLaboratoryList1.spName = "Executers";
        }

        private void Executers_Load(object sender, EventArgs e)
        {
            this.findUsersLaboratoryList1.Fill();
            this.grdUser.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.findUsersLaboratoryList1.Update();
        }
    }
}
