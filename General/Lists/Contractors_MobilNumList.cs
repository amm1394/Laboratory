using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Contractors_MobilNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contractors_MobilNum>
    {
        public Contractors_MobilNumList()
        {
            this.spName = "Contractors_MobilNum";
            this.list = new List<RASF.General.Data.Contractors_MobilNum>();
            this.deletedlist = new List<RASF.General.Data.Contractors_MobilNum>();
        }

        public Contractors_MobilNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

