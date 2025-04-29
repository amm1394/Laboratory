using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesSpaceSendSMSList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_SpaceSendSMS>
    {
        public CompaniesSpaceSendSMSList()
        {
            this.spName = "Companies_SpaceSendSMS";
            this.list = new List<RASF.General.Data.Companies_SpaceSendSMS>();
            this.deletedlist = new List<RASF.General.Data.Companies_SpaceSendSMS>();

        }

        public CompaniesSpaceSendSMSList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }
}
