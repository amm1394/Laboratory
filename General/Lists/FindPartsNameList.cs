using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindPartsNameList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindLetterNoPartsName>
    {
        public FindPartsNameList()
        {
            this.spName = "FindPartsName";
            this.list = new List<RASF.General.Data.FindLetterNoPartsName>();
            this.deletedlist = new List<RASF.General.Data.FindLetterNoPartsName>();
        }

        public FindPartsNameList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
