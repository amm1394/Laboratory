using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{
    [System.ComponentModel.Category("RASF")]
    public class UserList : RASF.General.Lists.Base.BaseList<RASF.General.Data.USER>
    {
        public UserList()
        {
            this.spName = "Users";
            this.list = new List<RASF.General.Data.USER>();
            this.deletedlist = new List<RASF.General.Data.USER>();

        }

        public UserList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

       
    }    
}
