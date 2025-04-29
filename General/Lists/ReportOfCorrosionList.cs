using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfCorrosionList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DeliveryDay>
    {
        public ReportOfCorrosionList()
        {
            this.spName = "ReportOfCorrosion";
            this.list = new List<RASF.General.Data.DeliveryDay>();
            this.deletedlist = new List<RASF.General.Data.DeliveryDay>();
        }

        public ReportOfCorrosionList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

