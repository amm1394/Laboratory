using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ChangeYearList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ChangeYear>
    {
        public ChangeYearList()
        {
            this.spName = "ChangeYear";
            this.list = new List<RASF.General.Data.ChangeYear>();
            this.deletedlist = new List<RASF.General.Data.ChangeYear>();
        }

        public ChangeYearList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

