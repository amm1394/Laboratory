using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class CompaniesOfDontGoBonyad2MonthList : RASF.General.Lists.Base.BaseList<RASF.General.Data.CompaniesOfDontGoBonyad2Month>
    {
        public CompaniesOfDontGoBonyad2MonthList()
        {
            this.spName = "CompaniesOfDontGoBonyad2Month";
            this.list = new List<RASF.General.Data.CompaniesOfDontGoBonyad2Month>();
            this.deletedlist = new List<RASF.General.Data.CompaniesOfDontGoBonyad2Month>();
        }

        public CompaniesOfDontGoBonyad2MonthList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

