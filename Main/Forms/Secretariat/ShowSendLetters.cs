using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Secretariat
{
    public partial class ShowSendLetters : RASF.General.Forms.Base.DockContentForm
    {
        private Guid sendletterscode;
        public ShowSendLetters(Guid SendLettersCode)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.sendletterscode = SendLettersCode;
            this.showSaveCostPaperList1.spName = "ShowLetterSend";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan3.Dispose();
        }

        private void SaveCostPaper_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.sendletterscode));
            this.showSaveCostPaperList1.Fill(Parameter1);
            if (this.showSaveCostPaperList1.list.Count>0)
            {
                this.letter_Scan3.Document = this.showSaveCostPaperList1.list[0].CostPaper;
            }
        }
    }
}
