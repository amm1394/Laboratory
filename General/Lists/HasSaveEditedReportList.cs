using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HasSaveEditedReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HasContracsLetter>
    {
        public HasSaveEditedReportList()
        {
            this.spName = "HasSaveEditedReport";
            this.list = new List<RASF.General.Data.HasContracsLetter>();
            this.deletedlist = new List<RASF.General.Data.HasContracsLetter>();
        }

        public HasSaveEditedReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
