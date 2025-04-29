using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class StandardsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Standards>
    {
        public StandardsList()
        {
            this.spName = "RegisterStandards";
            this.list = new List<RASF.General.Data.Standards>();
            this.deletedlist = new List<RASF.General.Data.Standards>();
        }

        public StandardsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

