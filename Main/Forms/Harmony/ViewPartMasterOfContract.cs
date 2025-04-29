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
    public partial class ViewPartMasterOfContract : RASF.General.Forms.Base.DockContentForm
    {
        public ViewPartMasterOfContract()
        {
            InitializeComponent();
            this.ShowpnlSave = false;
            this.grdMaterList.GroupByBoxVisible = true;
        }

        public ViewPartMasterOfContract(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.masterTestListCostPaperList1.Fill(Parameter2);

            this.grdMaterList.Refetch();

            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
        }

    }
}
