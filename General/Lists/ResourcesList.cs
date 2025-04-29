using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ResourcesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Resources>
    {
        public ResourcesList()
        {
            this.spName = "Resources";
            this.list = new List<RASF.General.Data.Resources>();
            this.deletedlist = new List<RASF.General.Data.Resources>();
        }

        public ResourcesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

