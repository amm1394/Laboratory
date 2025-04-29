using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ConstractorsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contractors>
    {
        public ConstractorsList()
        {
            this.spName = "Contractors";
            this.list = new List<RASF.General.Data.Contractors>();
            this.deletedlist = new List<RASF.General.Data.Contractors>();

        }

        public ConstractorsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
    
}
