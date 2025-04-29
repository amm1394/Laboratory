using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
     public class
     MasterTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.MasterTest>
    {
        public  MasterTestList()
        {
            this.spName = "MASTERTEST";
            this.list = new List<RASF.General.Data.MasterTest>();
            this.deletedlist = new List<RASF.General.Data.MasterTest>();

        }

        public MasterTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

      
    }
    
}
