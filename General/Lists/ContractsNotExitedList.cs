using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotExitedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEntered>
    {
        public ContractsNotExitedList()
        {
            this.spName = "Contracts_NotExited";
            this.list = new List<RASF.General.Data.ContractsNotEntered>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEntered>();
        }

        public ContractsNotExitedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<SqlParameter> p1 = new List<SqlParameter>();
            p1.Add(new SqlParameter("@Userid", RASF.General.Classes.Global.CurrentUserCode));

            RASF.General.Lists.PartsMasterNotExitedList PartsMasterNotExited_List = new PartsMasterNotExitedList();
            PartsMasterNotExited_List.Fill(p1);

            List<SqlParameter> p2 = new List<SqlParameter>();
            p2.Add(new SqlParameter("@Userid", RASF.General.Classes.Global.CurrentUserCode));

            RASF.General.Lists.TestNameNotExitedList TestNameNotExited_list = new Lists.TestNameNotExitedList();
            TestNameNotExited_list.Fill(p2);

            base.Fill(parameters);


            foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            {
                RASF.General.Lists.PartsMasterNotExitedList ContractsParts = new RASF.General.Lists.PartsMasterNotExitedList();
                ContractsParts.AddRange((from Part in PartsMasterNotExited_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEntered>());
                foreach (RASF.General.Data.PartsMasterNotEntered Parts in ContractsParts)
                {
                    RASF.General.Lists.TestNameNotExitedList PartsTest = new Lists.TestNameNotExitedList();
                    PartsTest.AddRange((from Test in TestNameNotExited_list where Test.PartsMasterCode == Parts.Parts_Master_Code select Test).ToList<RASF.General.Data.TestNameNotEntered>());
                    Parts.TestNameNotEntered = PartsTest;
                }
                Contracts.PartsMasterNotEntered = ContractsParts;
            }

            return this.list.Count;

        }

        public override void Update()
        {
            
            foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            {
                foreach (RASF.General.Data.PartsMasterNotEntered Parts in Contracts.PartsMasterNotEntered)
                {
                                    
                     if (Parts.TestNameNotEntered.Any(p => p.RowState != Enums.RowState.Original))
                    {
                        Parts.TestNameNotEntered.Update();
                    }
                }
            }
        }
    }

}
