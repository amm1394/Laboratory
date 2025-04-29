using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OutPutExecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OutPutExecuters>
    {
        public OutPutExecutersList()
        {
            this.spName = "OutPutExecuters";
            this.list = new List<RASF.General.Data.OutPutExecuters>();
            this.deletedlist = new List<RASF.General.Data.OutPutExecuters>();
        }

        public OutPutExecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

