using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindContractNoForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindLetterNoPartsName>
    {
        public FindContractNoForOfficesList()
        {
            this.spName = "FindContractNoForOffices";
            this.list = new List<RASF.General.Data.FindLetterNoPartsName>();
            this.deletedlist = new List<RASF.General.Data.FindLetterNoPartsName>();
        }

        public FindContractNoForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
