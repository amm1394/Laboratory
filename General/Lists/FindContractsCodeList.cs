using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindContractsCodeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindContractsCode>
    {
        public FindContractsCodeList()
        {
            this.spName = "FindContractsCode";
            this.list = new List<RASF.General.Data.FindContractsCode>();
            this.deletedlist = new List<RASF.General.Data.FindContractsCode>();
        }

        public FindContractsCodeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
