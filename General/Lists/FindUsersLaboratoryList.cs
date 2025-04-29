using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class FindUsersLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindUsersLaboratory>
    {
        public FindUsersLaboratoryList()
        {
            this.spName = "FindUsersLaboratory";
            this.list = new List<RASF.General.Data.FindUsersLaboratory>();
            this.deletedlist = new List<RASF.General.Data.FindUsersLaboratory>();
        }

        public FindUsersLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
