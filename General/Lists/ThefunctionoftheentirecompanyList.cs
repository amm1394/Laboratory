using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ThefunctionoftheentirecompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesOfDontGoBonyad2Month>
    {
        public ThefunctionoftheentirecompanyList()
        {
            this.spName = "Thefunctionoftheentirecompany";
            this.list = new List<RASF.General.Data.CompaniesOfDontGoBonyad2Month>();
            this.deletedlist = new List<RASF.General.Data.CompaniesOfDontGoBonyad2Month>();
        }

        public ThefunctionoftheentirecompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

