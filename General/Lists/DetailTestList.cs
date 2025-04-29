using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class DetailTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailTest>
    {
        public DetailTestList()
        {
            this.spName = "DetailTest";
            this.list = new List<RASF.General.Data.DetailTest>();
            this.deletedlist = new List<RASF.General.Data.DetailTest>();

        }

        public DetailTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        

    }
    
}
