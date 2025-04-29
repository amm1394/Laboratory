using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ViewTarrifList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ViewTarrif>
    {
        public ViewTarrifList()
        {
            this.spName = "ViewTarrif";
            this.list = new List<RASF.General.Data.ViewTarrif>();
            this.deletedlist = new List<RASF.General.Data.ViewTarrif>();
        }

        public ViewTarrifList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

