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
    public partial class RequestOfContractorDoesnotSendForm : RASF.General.Forms.Base.DockContentForm
    {
        public RequestOfContractorDoesnotSendForm()
        {
            InitializeComponent();
        }

        private void RequestOfContractorDoesnotSendForm_Load(object sender, EventArgs e)
        {
            this.requestOfContractorDoesnotSendList1.Fill();
            this.grdRequest.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.requestOfContractorDoesnotSendList1.Update();

            foreach (RASF.General.Data.RequestOfContractorDoesnotSend RequestOf in requestOfContractorDoesnotSendList1.Where (row => row.Check == true))
            {
                RequestOfContractor.Load(String.Format("{0}\\Report\\RequestOfContractor.mrt", Application.StartupPath));
                RequestOfContractor["@ContractorsCode"] = this.grdRequest.CurrentRow.Cells["ContractorsCode"].Value;
                RequestOfContractor.Show();
            }
        }
    }
}
