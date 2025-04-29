using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CountTestOfLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CountTestOfLaboratory>
    {
        public CountTestOfLaboratoryList()
        {
            this.spName = "CountTestOfLaboratory";
            this.list = new List<RASF.General.Data.CountTestOfLaboratory>();
            this.deletedlist = new List<RASF.General.Data.CountTestOfLaboratory>();
        }

        public CountTestOfLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

