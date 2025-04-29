using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ViewIndicatorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Indicator>
    {
        public ViewIndicatorList()
        {
            this.spName = "ViewIndicator";
            this.list = new List<RASF.General.Data.Indicator>();
            this.deletedlist = new List<RASF.General.Data.Indicator>();
        }

        public ViewIndicatorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

