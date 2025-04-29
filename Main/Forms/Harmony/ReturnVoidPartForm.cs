using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ReturnVoidPartForm : RASF.General.Forms.Base.DockContentForm
    {
        public ReturnVoidPartForm()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }
        private Guid ContractsCode;

        public ReturnVoidPartForm(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContract1.ContractNo = ContractNo;
            this.searchContract1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
      
        }

        private void ReturnVoidPartForm_Load(object sender, EventArgs e)
        {

        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", e.ContractsCode));
            this.returnVoidPartList1.Fill(Parameter1);
            this.grdPart.Refetch();
            ContractsCode = e.ContractsCode;
        }

        private void grdPart_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if(this.grdPart.SelectedItems.Count>0)
            {
                RASF.General.Data.Parts_Master Current_Company = (RASF.General.Data.Parts_Master)this.grdPart.SelectedItems[0].GetRow().DataRow;
                Current_Company.RowState = RASF.General.Enums.RowState.Updated;
                this.returnVoidPartList1.Update();

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", ContractsCode));
                this.returnVoidPartList1.Fill(Parameter1);
                this.grdPart.Refetch();

            }
        }
    }
}
