using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompaniesReferntList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesRefernt>
    {
        public CompaniesReferntList()
        {
            this.spName = "CompaniesRefernt";
            this.list = new List<RASF.General.Data.CompaniesRefernt>();
            this.deletedlist = new List<RASF.General.Data.CompaniesRefernt>();
        }

        public CompaniesReferntList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

