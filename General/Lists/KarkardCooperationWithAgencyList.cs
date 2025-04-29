using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class KarkardCooperationWithAgencyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.KarkardCooperationWithAgency>
    {
        public KarkardCooperationWithAgencyList()
        {
            this.spName = "KarkardCooperationWithAgency";
            this.list = new List<RASF.General.Data.KarkardCooperationWithAgency>();
            this.deletedlist = new List<RASF.General.Data.KarkardCooperationWithAgency>();
        }

        public KarkardCooperationWithAgencyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

