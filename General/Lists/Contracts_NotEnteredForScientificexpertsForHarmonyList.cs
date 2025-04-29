using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Contracts_NotEnteredForScientificexpertsForHarmonyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEntered>
    {
        public Contracts_NotEnteredForScientificexpertsForHarmonyList()
        {
            this.spName = "Contracts_NotEnteredForScientificexpertsForHarmony";
            this.list = new List<RASF.General.Data.ContractsNotEntered>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEntered>();
        }

        public Contracts_NotEnteredForScientificexpertsForHarmonyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        //public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        //{

        //    List<SqlParameter> p1 = new List<SqlParameter>();
        //    p1.Add(new SqlParameter("@LaboratoryCode", RASF.General.Classes.Global.LaboratoryList));

        //    RASF.General.Lists.PartsMasterNotEnteredForScientificexpertsList PartsMasterNotEntered_List = new PartsMasterNotEnteredForScientificexpertsList();
        //    PartsMasterNotEntered_List.Fill(p1);

        //    List<SqlParameter> p2 = new List<SqlParameter>();
        //    p2.Add(new SqlParameter("@LaboratoryCode", RASF.General.Classes.Global.LaboratoryList));

        //    RASF.General.Lists.TestNameNotEnteredForScientificexpertsList TestNameNotEntered_list = new Lists.TestNameNotEnteredForScientificexpertsList();
        //    TestNameNotEntered_list.Fill(p2);

        //    base.Fill(parameters);


        //    foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
        //    {
        //        RASF.General.Lists.PartsMasterNotEnteredForScientificexpertsList ContractsParts = new RASF.General.Lists.PartsMasterNotEnteredForScientificexpertsList();
        //        ContractsParts.AddRange((from Part in PartsMasterNotEntered_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEntered>());
        //        foreach (RASF.General.Data.PartsMasterNotEntered Parts in ContractsParts)
        //        {
        //            RASF.General.Lists.TestNameNotEnteredForScientificexpertsList PartsTest = new Lists.TestNameNotEnteredForScientificexpertsList();
        //            PartsTest.AddRange((from Test in TestNameNotEntered_list where Test.PartsMasterCode == Parts.Parts_Master_Code select Test).ToList<RASF.General.Data.TestNameNotEntered>());
        //            Parts.TestNameNotEntered = PartsTest;
        //        }
        //        Contracts.PartsMasterNotEntered = ContractsParts;
        //    }

        //    return this.list.Count;
        //}

       // public override void Update()
      //  {
            //foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            //{
            //    foreach (RASF.General.Data.PartsMasterNotEntered Parts in Contracts.PartsMasterNotEntered)
            //    {
            //        Parts.TestNameNotEntered.Update();
            //    }
            //}
      //  }
    }

}
