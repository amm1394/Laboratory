using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EarninigOfAgencyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EarninigOfAgency>
    {
        public EarninigOfAgencyList()
        {
            this.spName = "EarningsOfAgency";
            this.list = new List<RASF.General.Data.EarninigOfAgency>();
            this.deletedlist = new List<RASF.General.Data.EarninigOfAgency>();
        }

        public EarninigOfAgencyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

