using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class SaveAttachmentFile : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractCode;
        public SaveAttachmentFile(Guid ContractCode)
        {
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
            InitializeComponent();
            this.ContractCode = ContractCode;
            this.showSaveCostPaperList1.spName = "ShowSavedAttachmentFile";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.letter_Scan1.Document != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractCode));
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("CostPaper", this.letter_Scan1.Document));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("SaveAttachment_Insert", Parameter2);

            }
            this.Close();
        }

        private void SaveCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
        }

        private void SaveCostPaper_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractCode));
            this.showSaveCostPaperList1.Fill(Parameter1);
            if (this.showSaveCostPaperList1.list.Count>0)
            {
                this.letter_Scan1.Document = this.showSaveCostPaperList1.list[0].CostPaper;
            }
        }
    }
}
