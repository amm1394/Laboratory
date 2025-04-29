using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterNotEnteredForScientificexpertsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterNotEntered>
    {
        public PartsMasterNotEnteredForScientificexpertsList()
        {
            this.spName = "PartsMaster_NotEnteredForScientificexperts";
            this.list = new List<RASF.General.Data.PartsMasterNotEntered>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterNotEntered>();
        }

        public PartsMasterNotEnteredForScientificexpertsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
