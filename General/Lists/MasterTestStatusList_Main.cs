using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
     
    [System.ComponentModel.Category("RASF")]
    public class MasterTestStatusList_Main : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTestStatus>
    {
        public MasterTestStatusList_Main()
        {
            this.spName = "MasterTestStatus_Main";
            this.list = new List<RASF.General.Data.MasterTestStatus>();
            this.deletedlist = new List<RASF.General.Data.MasterTestStatus>();
        }

        public MasterTestStatusList_Main(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
