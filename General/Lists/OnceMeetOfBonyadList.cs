using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OnceMeetOfBonyadList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OnceMeetOfBonyad>
    {
        public OnceMeetOfBonyadList()
        {
            this.spName = "OnceMeetOfBonyad";
            this.list = new List<RASF.General.Data.OnceMeetOfBonyad>();
            this.deletedlist = new List<RASF.General.Data.OnceMeetOfBonyad>();
        }

        public OnceMeetOfBonyadList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

