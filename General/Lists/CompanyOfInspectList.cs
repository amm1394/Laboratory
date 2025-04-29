using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompanyOfInspectList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompanyOfInspect>
    {
        public CompanyOfInspectList()
        {
            this.spName = "CompanyOfInspect";
            this.list = new List<RASF.General.Data.CompanyOfInspect>();
            this.deletedlist = new List<RASF.General.Data.CompanyOfInspect>();
        }

        public CompanyOfInspectList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

