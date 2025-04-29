using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class WorkFlowDescriptionReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.WorkFlowDescriptionReport>
    {
        public WorkFlowDescriptionReportList()
        {
            this.spName = "WorkFlowDescriptionReport";
            this.list = new List<RASF.General.Data.WorkFlowDescriptionReport>();
            this.deletedlist = new List<RASF.General.Data.WorkFlowDescriptionReport>();
        }

        public WorkFlowDescriptionReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
