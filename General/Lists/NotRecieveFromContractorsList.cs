using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NotRecieveFromContractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NotRecieveFromContractors>
    {
        public NotRecieveFromContractorsList()
        {
            this.spName = "NotRecieveFromContractors";
            this.list = new List<RASF.General.Data.NotRecieveFromContractors>();
            this.deletedlist = new List<RASF.General.Data.NotRecieveFromContractors>();
        }

        public NotRecieveFromContractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill()
        {
            RASF.General.Lists.DetailOfNotRecieveFromContractorsList DetailOfNotRecieve = new DetailOfNotRecieveFromContractorsList();
            DetailOfNotRecieve.Fill();

            base.Fill();


            foreach (RASF.General.Data.NotRecieveFromContractors Contracts in this)
            {
                RASF.General.Lists.DetailOfNotRecieveFromContractorsList ContractsParts = new RASF.General.Lists.DetailOfNotRecieveFromContractorsList();
                ContractsParts.AddRange((from Detail in DetailOfNotRecieve where Detail.ContractsCode == Contracts.ContractsCode select Detail).ToList<RASF.General.Data.DetailOfNotRecieveFromContractors>());
                Contracts.DetailOfNotRecieveFromContractors = ContractsParts;
            }

            return this.list.Count;
            
        }

        public override void Update()
        {
            foreach (RASF.General.Data.NotRecieveFromContractors Contracts in this)
            {
                Contracts.DetailOfNotRecieveFromContractors.Update();
            }
        }
    }
    
}
