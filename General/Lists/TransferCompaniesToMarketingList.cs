using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TransferCompaniesToMarketingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Base>
    {
        public TransferCompaniesToMarketingList()
        {
            this.spName = "TransferCompaniesToMarketing";
            this.list = new List<RASF.General.Data.Companies_Base>();
            this.deletedlist = new List<RASF.General.Data.Companies_Base>();
        }

        public TransferCompaniesToMarketingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
