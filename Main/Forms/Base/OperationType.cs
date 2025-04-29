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
    public partial class OperationType : RASF.General.Forms.Base.DockContentForm
    {
        public OperationType()
        {
            InitializeComponent();
        }

        private void OperationType_Load(object sender, EventArgs e)
        {
            this.companiesCooperationTypeList1.Fill();
            this.grdOperatinType.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.companiesCooperationTypeList1.Update();
        }

      
    }
}
