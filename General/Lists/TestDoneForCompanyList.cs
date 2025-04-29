using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class TestDoneForCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.FindLetterNoPartsName>
    {
        public TestDoneForCompanyList()
        {
            this.spName = "TestDoneForCompany";
            this.list = new List<RASF.General.Data.FindLetterNoPartsName>();
            this.deletedlist = new List<RASF.General.Data.FindLetterNoPartsName>();
        }

        public TestDoneForCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

