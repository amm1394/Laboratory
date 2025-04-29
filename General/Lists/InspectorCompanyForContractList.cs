using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class InspectorCompanyForContractList : RASF.General.Lists.Base.BaseList<RASF.General.Data.InspectorCompanyForContract>
    {
        public InspectorCompanyForContractList()
        {
            this.spName = "InspectorCompanyForContract";
            this.list = new List<RASF.General.Data.InspectorCompanyForContract>();
            this.deletedlist = new List<RASF.General.Data.InspectorCompanyForContract>();
        }

        public InspectorCompanyForContractList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

