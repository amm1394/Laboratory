using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Contractors_FaxNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contractors_FaxNum>
    {
        public Contractors_FaxNumList()
        {
            this.spName = "Contractors_FaxNum";
            this.list = new List<RASF.General.Data.Contractors_FaxNum>();
            this.deletedlist = new List<RASF.General.Data.Contractors_FaxNum>();
        }

        public Contractors_FaxNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

