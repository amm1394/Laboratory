using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ViewSabtSamaneList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ViewSabtSamane>
    {
        public ViewSabtSamaneList()
        {
            this.spName = "ViewSabtSamane";
            this.list = new List<RASF.General.Data.ViewSabtSamane>();
            this.deletedlist = new List<RASF.General.Data.ViewSabtSamane>();
        }

        public ViewSabtSamaneList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

