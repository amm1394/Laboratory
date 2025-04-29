using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NumberOfExecutersOutputList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NumberOfExecutersOutput>
    {
        public NumberOfExecutersOutputList()
        {
            this.spName = "NumberOfExecutersOutput";
            this.list = new List<RASF.General.Data.NumberOfExecutersOutput>();
            this.deletedlist = new List<RASF.General.Data.NumberOfExecutersOutput>();
        }

        public NumberOfExecutersOutputList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

