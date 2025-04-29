using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class GetDocumentForPrintList : RASF.General.Lists.Base.BaseList<RASF.General.Data.GetDocumentForPrint>
    {
        public GetDocumentForPrintList()
        {
            this.spName = "GetDocumentForPrint";
            this.list = new List<RASF.General.Data.GetDocumentForPrint>();
            this.deletedlist = new List<RASF.General.Data.GetDocumentForPrint>();
        }

        public GetDocumentForPrintList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
