using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotEnteredAzmoonAmadesaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEnteredAzmoonAmadesazi>
    {
        public ContractsNotEnteredAzmoonAmadesaziList()
        {
            this.spName = "Contracts_NotEnteredAzmoonAmadesazi";
            this.list = new List<RASF.General.Data.ContractsNotEnteredAzmoonAmadesazi>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEnteredAzmoonAmadesazi>();
        }

        public ContractsNotEnteredAzmoonAmadesaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<SqlParameter> p1 = new List<SqlParameter>();
            p1.Add(new SqlParameter("@userId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.PartsMasterNotEnteredAzmoonAmadesaziList PartsMasterNotEntered_List = new PartsMasterNotEnteredAzmoonAmadesaziList();
            PartsMasterNotEntered_List.Fill(p1);

            List<SqlParameter> p2 = new List<SqlParameter>();
            p2.Add(new SqlParameter("@userId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.TestNameNotEnteredAzmoonAmadesaziList TestNameNotEntered_list = new Lists.TestNameNotEnteredAzmoonAmadesaziList();
            TestNameNotEntered_list.Fill(p2);

            base.Fill(parameters);


            foreach (RASF.General.Data.ContractsNotEnteredAzmoonAmadesazi Contracts in this)
            {
                RASF.General.Lists.PartsMasterNotEnteredAzmoonAmadesaziList ContractsParts = new RASF.General.Lists.PartsMasterNotEnteredAzmoonAmadesaziList();
                ContractsParts.AddRange((from Part in PartsMasterNotEntered_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi>());
                foreach (RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi Parts in ContractsParts)
                {
                    RASF.General.Lists.TestNameNotEnteredAzmoonAmadesaziList PartsTest = new Lists.TestNameNotEnteredAzmoonAmadesaziList();
                    PartsTest.AddRange((from Test in TestNameNotEntered_list where Test.PartsMasterCode == Parts.Parts_Master_Code select Test).ToList<RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi>());
                    Parts.TestNameNotEntered = PartsTest;
                }
                Contracts.PartsMasterNotEntered = ContractsParts;
            }

            return this.list.Count;
        }

        public override void Update()
        {
            foreach (RASF.General.Data.ContractsNotEnteredAzmoonAmadesazi Contracts in this)
            {
                foreach (RASF.General.Data.PartsMasterNotEnteredAzmoonAmadesazi Parts in Contracts.PartsMasterNotEntered)
                {
                    //if (test.list[0].TestExecutersCodeEnter != null )
                   // {
                        Parts.TestNameNotEntered.Update();
                   // }
                }
            }
        }
    }

}
