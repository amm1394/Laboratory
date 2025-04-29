using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class AcceptGrantList : RASF.General.Lists.Base.BaseList<RASF.General.Data.AcceptGrant>
    {
        public AcceptGrantList()
        {
            this.spName = "AcceptGrant";
            this.list = new List<RASF.General.Data.AcceptGrant>();
            this.deletedlist = new List<RASF.General.Data.AcceptGrant>();
        }

        public AcceptGrantList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

