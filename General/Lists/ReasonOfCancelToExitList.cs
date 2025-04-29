using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReasonOfCancelToExitList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHold>
    {
        public ReasonOfCancelToExitList()
        {
            this.spName = "ReasonOfCancelToExit";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
        }

        public ReasonOfCancelToExitList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            RASF.General.Lists.ReasonOfCancelToExitDetailList ReasonOfCancelToExitDetailList = new ReasonOfCancelToExitDetailList();

            foreach (RASF.General.Data.Cancel_Contracts_IsHold Contracts in this)
            {
                List<System.Data.SqlClient.SqlParameter> CancelExit = new List<System.Data.SqlClient.SqlParameter>();
                CancelExit.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Contracts.ContractsCode));
                ReasonOfCancelToExitDetailList.Fill(CancelExit);

                RASF.General.Lists.Cancel_Contracts_IsHoldDetailList ContractsCancelExit = new RASF.General.Lists.Cancel_Contracts_IsHoldDetailList();
                ContractsCancelExit.AddRange((from CancelToExited in ReasonOfCancelToExitDetailList where CancelToExited.ContractsCode == Contracts.ContractsCode select CancelToExited).ToList<RASF.General.Data.Cancel_Contracts_IsHoldDetail>());

                Contracts.Cancel_Contracts_IsHoldDetail = ContractsCancelExit;
            }

            return this.list.Count;
        }

   }
   }

