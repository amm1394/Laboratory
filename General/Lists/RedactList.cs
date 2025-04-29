using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RedactList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Redact>
    {
        public RedactList()
        {
            this.spName = "Redact";
            this.list = new List<RASF.General.Data.Redact>();
            this.deletedlist = new List<RASF.General.Data.Redact>();
        }

        public RedactList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

