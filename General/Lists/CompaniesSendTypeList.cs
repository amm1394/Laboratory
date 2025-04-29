using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class CompaniesSendTypeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_SendType>
    {
        public CompaniesSendTypeList()
        {
            this.spName = "Companies_SendType";
            this.list = new List<RASF.General.Data.Companies_SendType>();
            this.deletedlist = new List<RASF.General.Data.Companies_SendType>();

        }

        public CompaniesSendTypeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
