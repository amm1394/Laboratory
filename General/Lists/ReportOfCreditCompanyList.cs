using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportOfCreditCompanyList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportOfCreditCompany>
    {
        public ReportOfCreditCompanyList()
        {
            this.spName = "ReportOfCreditCompany";
            this.list = new List<RASF.General.Data.ReportOfCreditCompany>();
            this.deletedlist = new List<RASF.General.Data.ReportOfCreditCompany>();
        }

        public ReportOfCreditCompanyList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

