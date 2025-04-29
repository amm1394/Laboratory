using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OmitReportPersianList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CancelEnterExitLab>
    {
        public OmitReportPersianList()
        {
            this.spName = "OmitReportPersian";
            this.list = new List<RASF.General.Data.CancelEnterExitLab>();
            this.deletedlist = new List<RASF.General.Data.CancelEnterExitLab>();
        }

        public OmitReportPersianList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

