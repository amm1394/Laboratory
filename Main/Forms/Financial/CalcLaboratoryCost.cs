using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class CalcLaboratoryCost : RASF.General.Forms.Base.DockContentForm
    {
        public CalcLaboratoryCost()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.calcLaboratoryCost1.Update();
            
            this.calcLaboratoryCost1.Fill();
            this.grdLaboratory.Refetch();
        }

        private void CalcLaboratoryCost_Load(object sender, EventArgs e)
        {
            this.calcLaboratoryCost1.Fill();
            this.grdLaboratory.Refetch();
        }
    }
}
