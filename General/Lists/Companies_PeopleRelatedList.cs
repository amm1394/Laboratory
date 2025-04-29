using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Companies_PeopleRelatedList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Companies_PeopleRelated>
    {
        public Companies_PeopleRelatedList()
        {
            this.spName = "Companies_PeopleRelated";
            this.list = new List<RASF.General.Data.Companies_PeopleRelated>();
            this.deletedlist = new List<RASF.General.Data.Companies_PeopleRelated>();
        }

        public Companies_PeopleRelatedList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

