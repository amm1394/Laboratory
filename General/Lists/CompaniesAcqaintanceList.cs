using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesAcqaintanceList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Acquaintance>
    {
        public CompaniesAcqaintanceList()
        {
            this.spName = "Companies_Acquaintance";
            this.list = new List<RASF.General.Data.Companies_Acquaintance>();
            this.deletedlist = new List<RASF.General.Data.Companies_Acquaintance>();
        }

        public CompaniesAcqaintanceList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
