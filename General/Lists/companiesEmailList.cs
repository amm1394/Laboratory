using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class companiesEmailList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_Email>
    {
        public companiesEmailList()
        {
            this.spName = "Companies_Email";
            this.list = new List<RASF.General.Data.Companies_Email>();
            this.deletedlist = new List<RASF.General.Data.Companies_Email>();
        }

        public companiesEmailList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
