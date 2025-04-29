using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class KarkardCooperationList : RASF.General.Lists.Base.BaseList<RASF.General.Data.KarkardCooperation>
    {
        public KarkardCooperationList()
        {
            this.spName = "KarkardCooperation";
            this.list = new List<RASF.General.Data.KarkardCooperation>();
            this.deletedlist = new List<RASF.General.Data.KarkardCooperation>();
        }

        public KarkardCooperationList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

