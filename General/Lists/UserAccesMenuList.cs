using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class UserAccesMenuList : RASF.General.Lists.Base.BaseList<RASF.General.Data.UsersMenu>
    {
        public UserAccesMenuList()
        {
            this.spName = "UserAccesMenu";
            this.list = new List<RASF.General.Data.UsersMenu>();
            this.deletedlist = new List<RASF.General.Data.UsersMenu>();
        }

        public UserAccesMenuList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
