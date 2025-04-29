using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class NumberOfExecutersOutputDetailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.NumberOfExecutersOutput>
    {
        public NumberOfExecutersOutputDetailList()
        {
            this.spName = "NumberOfExecutersOutputDetail";
            this.list = new List<RASF.General.Data.NumberOfExecutersOutput>();
            this.deletedlist = new List<RASF.General.Data.NumberOfExecutersOutput>();
        }

        public NumberOfExecutersOutputDetailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

