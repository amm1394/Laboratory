using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OutPutExecutersDetailFormanagerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OutPutExecuters>
    {
        public OutPutExecutersDetailFormanagerList()
        {
            this.spName = "OutPutExecutersDetailFormanager";
            this.list = new List<RASF.General.Data.OutPutExecuters>();
            this.deletedlist = new List<RASF.General.Data.OutPutExecuters>();
        }

        public OutPutExecutersDetailFormanagerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

