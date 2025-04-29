using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class ConstractsExecutersList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Contracts_Executers>
    {
        public ConstractsExecutersList()
        {
            this.spName = "Contracts_Executers";
            this.list = new List<RASF.General.Data.Contracts_Executers>();
            this.deletedlist = new List<RASF.General.Data.Contracts_Executers>();

        }

        public ConstractsExecutersList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

     

    }
    
}
