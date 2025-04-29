using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowWorkFlowDescriptionList : RASF.General.Lists.Base.BaseList<RASF.General.Data.WorkFlowDescription>
    {
        public ShowWorkFlowDescriptionList()
        {
            this.spName = "ShowWorkFlowDescription";
            this.list = new List<RASF.General.Data.WorkFlowDescription>();
            this.deletedlist = new List<RASF.General.Data.WorkFlowDescription>();
        }

        public ShowWorkFlowDescriptionList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
