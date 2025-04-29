using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Cancel_Contracts_IsHoldList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Cancel_Contracts_IsHold>
    {
        public Cancel_Contracts_IsHoldList()
        {
            this.spName = "Cancel_Contracts_IsHold";
            this.list = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Cancel_Contracts_IsHold>();
        }

        public Cancel_Contracts_IsHoldList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            RASF.General.Lists.Cancel_Contracts_IsHoldDetailList Cancel_Contracts_IsHoldDetailList = new Cancel_Contracts_IsHoldDetailList();

            foreach (RASF.General.Data.Cancel_Contracts_IsHold Contracts in this)
            {
                List<System.Data.SqlClient.SqlParameter> IsHoldDetail = new List<System.Data.SqlClient.SqlParameter>();
                IsHoldDetail.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", Contracts.ContractsCode));
                Cancel_Contracts_IsHoldDetailList.Fill(IsHoldDetail);

                RASF.General.Lists.Cancel_Contracts_IsHoldDetailList ContractsIsHold = new RASF.General.Lists.Cancel_Contracts_IsHoldDetailList();
                ContractsIsHold.AddRange((from IsHold in Cancel_Contracts_IsHoldDetailList where IsHold.ContractsCode == Contracts.ContractsCode select IsHold).ToList<RASF.General.Data.Cancel_Contracts_IsHoldDetail>());

                Contracts.Cancel_Contracts_IsHoldDetail = ContractsIsHold;
            }

            return this.list.Count;
        }

   }
   }

