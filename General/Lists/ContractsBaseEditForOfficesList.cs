using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ContractsBaseEditForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Base_Edit>
    {
        public ContractsBaseEditForOfficesList()
        {
            this.spName = "Contracts_Base_EditForOffices";
            this.list = new List<RASF.General.Data.Contracts_Base_Edit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Base_Edit>();

        }

        public ContractsBaseEditForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
      

    }
    
}
