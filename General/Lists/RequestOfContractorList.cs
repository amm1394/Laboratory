using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RequestOfContractorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RequestOfContractor>
    {
        public RequestOfContractorList()
        {
            this.spName = "RequestOfContractor";
            this.list = new List<RASF.General.Data.RequestOfContractor>();
            this.deletedlist = new List<RASF.General.Data.RequestOfContractor>();
        }

        public RequestOfContractorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

