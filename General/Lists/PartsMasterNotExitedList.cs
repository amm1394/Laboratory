using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterNotExitedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterNotEntered>
    {
        public PartsMasterNotExitedList()
        {
            this.spName = "PartsMaster_NotExited";
            this.list = new List<RASF.General.Data.PartsMasterNotEntered>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterNotEntered>();
        }

        public PartsMasterNotExitedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
