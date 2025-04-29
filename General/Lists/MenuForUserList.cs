using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class MenuForUserList : RASF.General.Lists.Base.BaseList<RASF.General.Data.UsersMenu>
    {
        public MenuForUserList()
        {
            this.spName = "UsersMenu";
            this.list = new List<RASF.General.Data.UsersMenu>();
            this.deletedlist = new List<RASF.General.Data.UsersMenu>();
        }

        public MenuForUserList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
}
