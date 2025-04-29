using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindContractNoList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindLetterNoPartsName>
    {
        public FindContractNoList()
        {
            this.spName = "FindContractNo";
            this.list = new List<RASF.General.Data.FindLetterNoPartsName>();
            this.deletedlist = new List<RASF.General.Data.FindLetterNoPartsName>();
        }

        public FindContractNoList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
