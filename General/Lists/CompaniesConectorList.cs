using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompaniesConectorList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesConector>
    {
        public CompaniesConectorList()
        {
            this.spName = "CompaniesConector";
            this.list = new List<RASF.General.Data.CompaniesConector>();
            this.deletedlist = new List<RASF.General.Data.CompaniesConector>();
        }

        public CompaniesConectorList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

