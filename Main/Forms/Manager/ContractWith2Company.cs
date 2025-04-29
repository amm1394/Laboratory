using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class ContractWith2Company : RASF.General.Forms.Base.DockContentForm
    {
        public ContractWith2Company()
        {
            InitializeComponent();
        }

        private void ContractWith2Company_Load(object sender, EventArgs e)
        {
            this.contractWith2CompanyList1.Fill();
            this.grdReport.Refetch();
        }
    }
}
