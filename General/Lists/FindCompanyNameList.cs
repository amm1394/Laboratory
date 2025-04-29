using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindCompanyNameList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindLetterNoPartsName>
    {
        public FindCompanyNameList()
        {
            this.spName = "FindCompanyName";
            this.list = new List<RASF.General.Data.FindLetterNoPartsName>();
            this.deletedlist = new List<RASF.General.Data.FindLetterNoPartsName>();
        }

        public FindCompanyNameList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
