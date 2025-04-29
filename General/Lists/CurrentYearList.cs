using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CurrentYearList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ChangeYear>
    {
        public CurrentYearList()
        {
            this.spName = "CurrentYear";
            this.list = new List<RASF.General.Data.ChangeYear>();
            this.deletedlist = new List<RASF.General.Data.ChangeYear>();
        }

        public CurrentYearList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

