using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class WorkFlowDescriptionList : RASF.General.Lists.Base.BaseList<RASF.General.Data.WorkFlowDescription>
    {
        public WorkFlowDescriptionList()
        {
            this.spName = "WorkFlowDescription";
            this.list = new List<RASF.General.Data.WorkFlowDescription>();
            this.deletedlist = new List<RASF.General.Data.WorkFlowDescription>();
        }

        public WorkFlowDescriptionList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
