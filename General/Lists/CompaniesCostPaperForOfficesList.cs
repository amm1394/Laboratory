using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompaniesCostPaperForOfficesList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesCostPaper>
    {
        public CompaniesCostPaperForOfficesList()
        {
            this.spName = "CompaniesCostPaperForOffice";
            this.list = new List<RASF.General.Data.CompaniesCostPaper>();
            this.deletedlist = new List<RASF.General.Data.CompaniesCostPaper>();
        }

        public CompaniesCostPaperForOfficesList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
