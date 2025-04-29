using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class InspectorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Inspector>
    {
        public InspectorList()
        {
            this.spName = "Inspector";
            this.list = new List<RASF.General.Data.Inspector>();
            this.deletedlist = new List<RASF.General.Data.Inspector>();
        }

        public InspectorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

