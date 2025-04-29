using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Laboratory_UserList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Laboratory_User>
    {
        public Laboratory_UserList()
        {
            this.spName = "Laboratory_User";
            this.list = new List<RASF.General.Data.Laboratory_User>();
            this.deletedlist = new List<RASF.General.Data.Laboratory_User>();
        }

        public Laboratory_UserList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill()
        {
            base.Fill();
            base.Remove(this.list.Where(row => row.UserId == RASF.General.Classes.Global.CurrentUserCode).SingleOrDefault());
            return this.list.Count;
        }
    }
}

