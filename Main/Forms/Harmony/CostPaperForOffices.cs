using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class CostPaperForOffices : RASF.General.Forms.Base.DockContentForm
    {
        public CostPaperForOffices()
        {
            InitializeComponent();
            this.ShowpnlSave = false;
            this.grdMaterList.GroupByBoxVisible = true;
        }

        public CostPaperForOffices(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.companiesCostPaperForOfficesList1.Fill(Parameter);
           
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.recieptHistoryList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.masterTestListCostPaperForOfficesList1.Fill(Parameter2);

            this.grdCompanisInvoice.Refetch();
            this.grdReciptHistory.Refetch();
            this.grdMaterList.Refetch();

            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
        }

        
    }
}
