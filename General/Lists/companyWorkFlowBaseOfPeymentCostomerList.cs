using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class companyWorkFlowBaseOfPeymentCostomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.companyWorkFlowBaseOfPeymentCostomer>
    {
        public companyWorkFlowBaseOfPeymentCostomerList()
        {
            this.spName = "companyWorkFlowBaseOfPeymentCostomer";
            this.list = new List<RASF.General.Data.companyWorkFlowBaseOfPeymentCostomer>();
            this.deletedlist = new List<RASF.General.Data.companyWorkFlowBaseOfPeymentCostomer>();
        }

        public companyWorkFlowBaseOfPeymentCostomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

