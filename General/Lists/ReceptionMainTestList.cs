using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ReceptionMainTestList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceptionMainTest>
    {
        public ReceptionMainTestList()
        {
            this.spName = "ReceptionMainTest";
            this.list = new List<RASF.General.Data.ReceptionMainTest>();
            this.deletedlist = new List<RASF.General.Data.ReceptionMainTest>();
        }

        public ReceptionMainTestList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
