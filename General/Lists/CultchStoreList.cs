using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CultchStoreList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CultchStore>
    {
        public CultchStoreList()
        {
            this.spName = "CultchStore";
            this.list = new List<RASF.General.Data.CultchStore>();
            this.deletedlist = new List<RASF.General.Data.CultchStore>();
        }

        public CultchStoreList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

