using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DetailOfReceptionForCashCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailOfReception>
    {
        public DetailOfReceptionForCashCompanyList()
        {
            this.spName = "DetailOfReceptionForCashCompany";
            this.list = new List<RASF.General.Data.DetailOfReception>();
            this.deletedlist = new List<RASF.General.Data.DetailOfReception>();
        }

        public DetailOfReceptionForCashCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

