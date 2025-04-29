using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class RegisterMarkingList : RASF.General.Lists.Base.BaseList<RASF.General.Data.RegisterMarking>
    {
        public RegisterMarkingList()
        {
            this.spName = "RegisterMarking";
            this.list = new List<RASF.General.Data.RegisterMarking>();
            this.deletedlist = new List<RASF.General.Data.RegisterMarking>();
        }

        public RegisterMarkingList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

