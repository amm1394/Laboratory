using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CooperationGroup_TafahomNameList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CooperationGroup_TafahomName>
    {
        public CooperationGroup_TafahomNameList()
        {
            this.spName = "CooperationGroup_TafahomName";
            this.list = new List<RASF.General.Data.CooperationGroup_TafahomName>();
            this.deletedlist = new List<RASF.General.Data.CooperationGroup_TafahomName>();
        }

        public CooperationGroup_TafahomNameList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
