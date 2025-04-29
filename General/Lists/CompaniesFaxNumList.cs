using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists.Base
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesFaxNumList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_FaxNum>
    {
        public CompaniesFaxNumList()
        {
            this.spName = "Companies_FaxNum";
            this.list = new List<RASF.General.Data.Companies_FaxNum>();
            this.deletedlist = new List<RASF.General.Data.Companies_FaxNum>();

        }

        public CompaniesFaxNumList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
