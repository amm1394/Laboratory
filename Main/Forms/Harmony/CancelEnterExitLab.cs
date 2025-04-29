using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class CancelEnterExitLab : RASF.General.Forms.Base.DockContentForm
    {
        public CancelEnterExitLab()
        {
            InitializeComponent();
        }

        public CancelEnterExitLab(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContractcsForAll1.ContractNo = ContractNo;
            this.searchContractcsForAll1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            this.searchContractcsForAll2_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            this.searchContractcsForAll3_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            this.searchContractcsForAll4_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            this.searchContractcsForAll5_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
            
        }
        private void grdEnter_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdExit_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdEnterScience_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdExitScience_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

        }

        private void searchContractcsForAll2_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

        }

        private void searchContractcsForAll3_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

        }

        private void searchContractcsForAll4_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

        }

        private void searchContractcsForAll5_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

        }
    }
}
