using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class LaboratoryReportsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.LaboratoryReports>
    {
        public LaboratoryReportsList()
        {
            this.spName = "LaboratoryReports";
            this.list = new List<RASF.General.Data.LaboratoryReports>();
            this.deletedlist = new List<RASF.General.Data.LaboratoryReports>();
        }

        public LaboratoryReportsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
