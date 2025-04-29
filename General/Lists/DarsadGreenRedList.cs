using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DarsadGreenRedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfCreditCompany>
    {
        public DarsadGreenRedList()
        {
            this.spName = "DarsadGreenRed";
            this.list = new List<RASF.General.Data.ReportOfCreditCompany>();
            this.deletedlist = new List<RASF.General.Data.ReportOfCreditCompany>();
        }

        public DarsadGreenRedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
