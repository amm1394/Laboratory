using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CurrentWorkOfCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CurrentWorkOfCompany>
    {
        public CurrentWorkOfCompanyList()
        {
            this.spName = "CurrentWorkOfCompany";
            this.list = new List<RASF.General.Data.CurrentWorkOfCompany>();
            this.deletedlist = new List<RASF.General.Data.CurrentWorkOfCompany>();
        }

        public CurrentWorkOfCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

