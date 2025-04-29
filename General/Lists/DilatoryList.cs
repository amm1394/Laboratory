using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DilatoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_IsHold>
    {
        public DilatoryList()
        {
            this.spName = "Contracts_dilatory";
            this.list = new List<RASF.General.Data.Contracts_IsHold>();
            this.deletedlist = new List<RASF.General.Data.Contracts_IsHold>();
        }

        public DilatoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

