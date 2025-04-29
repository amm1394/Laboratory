using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ConnectorOfCompaniesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ConnectorOfCompanies>
    {
        public ConnectorOfCompaniesList()
        {
            this.spName = "ConnectorOfCompanies";
            this.list = new List<RASF.General.Data.ConnectorOfCompanies>();
            this.deletedlist = new List<RASF.General.Data.ConnectorOfCompanies>();
        }

        public ConnectorOfCompaniesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

