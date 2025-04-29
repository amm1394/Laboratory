using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DeleteAttachmentOfReportsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HasContracsLetter>
    {
        public DeleteAttachmentOfReportsList()
        {
            this.spName = "DeleteAttachmentOfReports";
            this.list = new List<RASF.General.Data.HasContracsLetter>();
            this.deletedlist = new List<RASF.General.Data.HasContracsLetter>();
        }

        public DeleteAttachmentOfReportsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
