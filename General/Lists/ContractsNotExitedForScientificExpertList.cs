using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotExitedForScientificExpertList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEntered>
    {
        public ContractsNotExitedForScientificExpertList()
        {
            this.spName = "Contracts_NotExitedForScientificExpert";
            this.list = new List<RASF.General.Data.ContractsNotEntered>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEntered>();
        }

        public ContractsNotExitedForScientificExpertList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<SqlParameter> p1 = new List<SqlParameter>();
            p1.Add(new SqlParameter("@LaboratoryCode", RASF.General.Classes.Global.LaboratoryList));

            RASF.General.Lists.PartsMasterNotExitedForScientificExpertList PartsMasterNotExited_List = new PartsMasterNotExitedForScientificExpertList();
            PartsMasterNotExited_List.Fill(p1);

            List<SqlParameter> p2 = new List<SqlParameter>();
            p2.Add(new SqlParameter("@LaboratoryCode", RASF.General.Classes.Global.LaboratoryList));

            RASF.General.Lists.TestNameNotExitedForScientificExpertList TestNameNotExited_list = new Lists.TestNameNotExitedForScientificExpertList();
            TestNameNotExited_list.Fill(p2);

            base.Fill(parameters);


            foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            {
                RASF.General.Lists.PartsMasterNotExitedForScientificExpertList ContractsParts = new RASF.General.Lists.PartsMasterNotExitedForScientificExpertList();
                ContractsParts.AddRange((from Part in PartsMasterNotExited_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEntered>());
                foreach (RASF.General.Data.PartsMasterNotEntered Parts in ContractsParts)
                {
                    RASF.General.Lists.TestNameNotExitedForScientificExpertList PartsTest = new Lists.TestNameNotExitedForScientificExpertList();
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
