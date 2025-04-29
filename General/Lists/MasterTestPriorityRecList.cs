using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
     public class
     MasterTestPriorityRecList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTest>
    {
        public  MasterTestPriorityRecList()
        {
            this.spName = "MasterTestPriorityRec";
            this.list = new List<RASF.General.Data.MasterTest>();
            this.deletedlist = new List<RASF.General.Data.MasterTest>();

        }

        public MasterTestPriorityRecList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }
    
}
