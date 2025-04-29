using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class CancelToExitForLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        List<RASF.Messaging.General.Classes.Packet> packets = new List<RASF.Messaging.General.Classes.Packet>();
        private string Description;
        public CancelToExitForLaboratory()
        {
            InitializeComponent();
            this.ShowpnlExit = true;
            this.ShowpnlUpdate = true;
            this.masterTestListCostPaperList1.spName = "CancelExitForMasterNameForLaboratory";
        }

           
        private void btnSave_Click(object sender, EventArgs e)
        {
           txtExit.Text= RASF.General.Classes.Utility.CorrectFileName(txtExit.Text);
            if (txtExit.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("لطفا علت خروج را به طور کامل وارد نمایید");
            }
            else
            {

                if (this.grdContracts.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Contracts_CancelToExit Current_Contract = (RASF.General.Data.Contracts_CancelToExit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                    if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                    {
                        Current_Contract.RowState = General.Enums.RowState.Added;
                        Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                        this.contractsCancelToExitList1.Update();
                        this.Description = Current_Contract.Description;

                        foreach (RASF.General.Data.MasterTestListCostPaper MasterTestListCostPaper in this.masterTestListCostPaperList1)
                        {
                            if (MasterTestListCostPaper.Checked == true)
                            {
                                MasterTestListCostPaper.Description = this.Description;
                                MasterTestListCostPaper.UserName = RASF.General.Classes.Global.CurrentUserName;
                                
                            }
                        }
                        this.masterTestListCostPaperList1.Update();
                        List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract.ContractsCode));
                        string ConnectorId = (string)RASF.General.Lists.BanksList.FillScalar("ConnectorOfInvoice", Parameter2);

                        if (ConnectorId != "00000000-0000-0000-0000-000000000000")
                        {

                            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver",Guid.Parse(ConnectorId)));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", Current_Contract.Description));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract.ContractsCode));
                            Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                            RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode,Guid.Parse(ConnectorId), Current_Contract.Description, Messaging.General.Enums.DataIdentifier.Message);
                            packets.Add(packet);
                        }

                        List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
                        Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract.ContractsCode));
                        string ConnectorId2 = (string)RASF.General.Lists.BanksList.FillScalar("ConnectorOfReport", Parameter3);

                        if (ConnectorId2 != "00000000-0000-0000-0000-000000000000" && ConnectorId2 != ConnectorId)
                        {
                            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Sender", RASF.General.Classes.Global.CurrentUserCode));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Receiver",Guid.Parse(ConnectorId2)));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("Message", Current_Contract.Description));
                            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Current_Contract.ContractsCode));
                            Guid Id = (Guid)this.sendMessageList1.FillScalar(Parameter);
                            RASF.Messaging.General.Classes.Packet packet = new Messaging.General.Classes.Packet(Id, RASF.General.Classes.Global.CurrentUserCode,Guid.Parse(ConnectorId2), Current_Contract.Description, Messaging.General.Enums.DataIdentifier.Message);
                            packets.Add(packet);
                        }

                        FillContract();

                        this.txtExit.Text = String.Empty;
                    }

                    RASF.Main.Forms.Harmony.DeliveryDateChange DeliveryDateChange = new Harmony.DeliveryDateChange();
                    DeliveryDateChange.ShowDialog();
                }
            }
        }

        private void CancelToExit_Load(object sender, EventArgs e)
        {
               FillContract();
        }

        private void FillContract()
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            this.contractsCancelToExitList1.Fill(Parameters);
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = "قرارداد" + " " + this.grdContracts.CurrentRow.Cells["ContractNo"].Value.ToString();

                List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractCode", this.grdContracts.CurrentRow.Cells["ContractsCode"].Value));
                this.masterTestListCostPaperList1.Fill(Parameters);
                this.grdMaster.Refetch();
            }
            else
            {
                this.grpContracts.Text = "";
            }
        }

        private void txtExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar <= '9' && e.KeyChar >= '0')// && e.KeyChar == '*' && e.KeyChar == '@' && e.KeyChar == '#' && e.KeyChar == '.')
            //    e.Handled = true;
            //else
            //    e.Handled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContract();
        }
    }
}
