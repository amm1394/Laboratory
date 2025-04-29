using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowCompaniesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Connector_PeapleRelated>
    {
        public ShowCompaniesList()
        {
            this.spName = "ShowCompanies";
            this.list = new List<RASF.General.Data.Connector_PeapleRelated>();
            this.deletedlist = new List<RASF.General.Data.Connector_PeapleRelated>();
        }

        public ShowCompaniesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
