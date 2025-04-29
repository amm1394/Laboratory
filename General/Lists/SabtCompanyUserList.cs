using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class SabtCompanyUserList : RASF.General.Lists.Base.BaseList<RASF.General.Data.USER>
    {
        public SabtCompanyUserList()
        {
            this.spName = "SabtCompanyUser";
            this.list = new List<RASF.General.Data.USER>();
            this.deletedlist = new List<RASF.General.Data.USER>();

        }

        public SabtCompanyUserList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
