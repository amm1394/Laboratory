using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    //صدور مجدد صورت حساب
    public class ContractsBaseEditReissuesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Base_Edit>
    {
        public ContractsBaseEditReissuesList()
        {
            this.spName = "Contracts_Base_Edit_Reissues";
            this.list = new List<RASF.General.Data.Contracts_Base_Edit>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Base_Edit>();

        }

        public ContractsBaseEditReissuesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
      

    }
    
}
