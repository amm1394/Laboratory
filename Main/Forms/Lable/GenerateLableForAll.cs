using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Lable
{
    public partial class GenerateLableForAll : RASF.General.Forms.Base.DockContentForm
    {
        public GenerateLableForAll()
        {
            InitializeComponent();
            this.ShowpnlSave = false;
            this.generateLabelList1.spName = "GenerateLabelForAll";
        }

        public GenerateLableForAll(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.generateLabelList1.Fill(Parameter);

            this.generate_Label1.DoWork(this.generateLabelList1);
        }
    }
}
