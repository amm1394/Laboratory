using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotEnteredAmadesaziList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEnteredAmadesazi>
    {
        public ContractsNotEnteredAmadesaziList()
        {
            this.spName = "Contracts_NotEnteredAmadeSazi";
            this.list = new List<RASF.General.Data.ContractsNotEnteredAmadesazi>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEnteredAmadesazi>();
        }

        public ContractsNotEnteredAmadesaziList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<SqlParameter> p1 = new List<SqlParameter>();
            p1.Add(new SqlParameter("@userId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.PartsMaster_NotEnteredAmadeSaziList PartsMasterNotEntered_List = new PartsMaster_NotEnteredAmadeSaziList();
            PartsMasterNotEntered_List.Fill(p1);

          

            base.Fill(parameters);


            foreach (RASF.General.Data.ContractsNotEnteredAmadesazi Contracts in this)
            {
                RASF.General.Lists.PartsMaster_NotEnteredAmadeSaziList ContractsParts = new RASF.General.Lists.PartsMaster_NotEnteredAmadeSaziList();
                ContractsParts.AddRange((from Part in PartsMasterNotEntered_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEnteredAmadesazi>());
                Contracts.PartsMasterNotEntered = ContractsParts;
            }

            return this.list.Count;
        }

        public override void Update()
        {
            foreach (RASF.General.Data.ContractsNotEnteredAmadesazi Contracts in this)
            {
                Contracts.PartsMasterNotEntered.Update();
            }
        }
    }

}
