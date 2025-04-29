using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Darsad98List : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportMounthlyLaboratory>
    {
        public Darsad98List()
        {
            this.spName = "Darsad98";
            this.list = new List<RASF.General.Data.ReportMounthlyLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ReportMounthlyLaboratory>();
        }

        public Darsad98List(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

