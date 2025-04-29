using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ProcessOfCustomerList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DebPayCompanies>
    {
        public ProcessOfCustomerList()
        {
            this.spName = "ProcessOfCustomer";
            this.list = new List<RASF.General.Data.DebPayCompanies>();
            this.deletedlist = new List<RASF.General.Data.DebPayCompanies>();
        }

        public ProcessOfCustomerList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

