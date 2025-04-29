using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{

    public partial class EditMessaging : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
        public EditMessaging()
        {
            InitializeComponent();
            this.ShowpnlUpdate = false;
            this.ShowpnlExit = false;
        }

        public EditMessaging(Guid ContractsCode, int ContractNo)
            : this()
        {
            this.searchContractcsForAll1.ContractNo = ContractNo;
            this.searchContractcsForAll1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;

            RefreshGrid(e);
        }

        private void RefreshGrid(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.editMessageList1.Fill(Parameter);
            this.grdEdit.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (this.grdEdit.SelectedItems.Count > 0)
            {
                RASF.General.Data.ShowSendMessage Current_Contract = (RASF.General.Data.ShowSendMessage)this.grdEdit.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Message) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Updated;
                    Current_Contract.UserId = RASF.General.Classes.Global.CurrentUserCode;
                    this.editMessageList1.Update();

                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
                    this.editMessageList1.Fill(Parameter);
                    this.grdEdit.Refetch();


                    txtEdit.Text = "";


                }

            }
        }
    }
}
