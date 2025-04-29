using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class HoldContractNotCompleted : RASF.General.Forms.Base.DockContentForm
    {
        public HoldContractNotCompleted()
        {
            InitializeComponent();
        }

        private void HoldContractNotCompleted_Load(object sender, EventArgs e)
        {
            this.holdContractNotCompletedList1.Fill();

            this.grdHoldContract.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdHoldContract.ExportToExcel("قراردادهای مسئله دار");
        }
    }
}
