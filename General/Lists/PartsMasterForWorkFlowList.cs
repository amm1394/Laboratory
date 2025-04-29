using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterForWorkFlowList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterForWorkFlow>
    {
        public PartsMasterForWorkFlowList()
        {
            this.spName = "PartsMasterForWorkFlow";
            this.list = new List<RASF.General.Data.PartsMasterForWorkFlow>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterForWorkFlow>();
        }

        public PartsMasterForWorkFlowList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

