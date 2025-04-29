using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     
    [System.ComponentModel.Category("RASF")]
    public class MainTestStatusList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MainTestStatus>
    {
        public MainTestStatusList()
        {
            this.spName = "MainTestStatus";
            this.list = new List<RASF.General.Data.MainTestStatus>();
            this.deletedlist = new List<RASF.General.Data.MainTestStatus>();
        }

        public MainTestStatusList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
