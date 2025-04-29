using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Connector_PeapleRelatedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Connector_PeapleRelated>
    {
        public Connector_PeapleRelatedList()
        {
            this.spName = "Connector_PeapleRelated";
            this.list = new List<RASF.General.Data.Connector_PeapleRelated>();
            this.deletedlist = new List<RASF.General.Data.Connector_PeapleRelated>();
        }

        public Connector_PeapleRelatedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
