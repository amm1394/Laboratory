using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class VoidedContractsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.VoidedContracts>
    {
        public VoidedContractsList()
        {
            this.spName = "VoidedContracts";
            this.list = new List<RASF.General.Data.VoidedContracts>();
            this.deletedlist = new List<RASF.General.Data.VoidedContracts>();
        }

        public VoidedContractsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public int Fill(DateTime From, DateTime To)
        {
            List<System.Data.SqlClient.SqlParameter> VoidContract_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            VoidContract_Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            VoidContract_Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            base.Fill(VoidContract_Parameters);

            List<System.Data.SqlClient.SqlParameter> VoidContractDescription_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            VoidContractDescription_Parameters.Add(new System.Data.SqlClient.SqlParameter("From", From));
            VoidContractDescription_Parameters.Add(new System.Data.SqlClient.SqlParameter("To", To));
            RASF.General.Lists.VoidedContractsDescriptionList VoidedContractsDescriptionList = new Lists.VoidedContractsDescriptionList();
            VoidedContractsDescriptionList.Fill(VoidContractDescription_Parameters);

            foreach (RASF.General.Data.VoidedContracts VoidedContracts in this)
            {
                RASF.General.Lists.VoidedContractsDescriptionList Contracts = new RASF.General.Lists.VoidedContractsDescriptionList();
                Contracts.AddRange((from Part in VoidedContractsDescriptionList where Part.ContractCode == VoidedContracts.ContractsCode select Part).ToList<RASF.General.Data.VoidedContractsDescription>());

                VoidedContracts.VoidedContractsDescription = Contracts;
            }

            return this.list.Count;
                      

        }
    }


    
}
