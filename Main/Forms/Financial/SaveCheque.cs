using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class SaveCheque : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ReceiptAmountMasterCode;
        public SaveCheque(Guid ReceiptAmountMasterCode)
        {
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            InitializeComponent();
            this.ReceiptAmountMasterCode = ReceiptAmountMasterCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.letter_Scan3.Document != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ReceiptAmountMasterCode", this.ReceiptAmountMasterCode));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("Cheque", this.letter_Scan3.Document));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("SaveCheque_Insert", Parameter2);

            }
            this.Close();
        }

        private void SaveCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan3.Dispose();
        }

        private void SaveCostPaper_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ReceiptAmountMasterCode", this.ReceiptAmountMasterCode));
            this.showSaveChequeList1 .Fill(Parameter1);
            if (this.showSaveChequeList1.list.Count > 0)
            {
                this.letter_Scan3.Document = this.showSaveChequeList1.list[0].Cheque;
            }
        }
    }
}
