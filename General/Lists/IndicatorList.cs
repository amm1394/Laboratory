using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class IndicatorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Indicator>
    {
        public IndicatorList()
        {
            this.spName = "Indicator";
            this.list = new List<RASF.General.Data.Indicator>();
            this.deletedlist = new List<RASF.General.Data.Indicator>();
        }

        public IndicatorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

