using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompaniesCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesCostPaper>
    {
        public CompaniesCostPaperList()
        {
            this.spName = "CompaniesCostPaper";
            this.list = new List<RASF.General.Data.CompaniesCostPaper>();
            this.deletedlist = new List<RASF.General.Data.CompaniesCostPaper>();
        }

        public CompaniesCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
