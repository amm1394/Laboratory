using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ExecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Executers>
    {
        public ExecutersList()
        {
            this.spName = "Executers";
            this.list = new List<RASF.General.Data.Executers>();
            this.deletedlist = new List<RASF.General.Data.Executers>();

        }

        public ExecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
