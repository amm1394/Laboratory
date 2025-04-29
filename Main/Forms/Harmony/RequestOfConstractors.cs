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
    public partial class RequestOfConstractors : RASF.General.Forms.Base.DockContentForm
    {
        public RequestOfConstractors()
        {
            InitializeComponent();
        }

        public RequestOfConstractors(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new RASF.General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            
        }
        private void searchContract1_ReturnContractsCode (RASF.General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.requestOfContractorList1.Fill(Parameter);

            General.Classes.Utility.Create_DropDown(this.grdcontractors.RootTable.Columns["ContractorCode"], this.constractorsList1, "ContractorCode", "Name");
            this.grdcontractors.RootTable.Columns["ContractorCode"].DefaultValue = this.constractorsList1[0].ContractorCode;

            this.grdcontractors.Refetch();
        }

        private void RequestOfConstractors_Load(object sender, EventArgs e)
        {
            this.constractorsList1.Fill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
               
                this.requestOfContractorList1.Update();
          
        }
    }
}
