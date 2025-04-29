using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DetailOfSanadList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailOfSanad>
    {
        public DetailOfSanadList()
        {
            this.spName = "DetailOfSanad";
            this.list = new List<RASF.General.Data.DetailOfSanad>();
            this.deletedlist = new List<RASF.General.Data.DetailOfSanad>();
        }

        public DetailOfSanadList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

