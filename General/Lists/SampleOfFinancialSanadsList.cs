using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SampleOfFinancialSanadsList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SampleOfFinancialSanads>
    {
        public SampleOfFinancialSanadsList()
        {
            this.spName = "SampleOfFinancialSanads";
            this.list = new List<RASF.General.Data.SampleOfFinancialSanads>();
            this.deletedlist = new List<RASF.General.Data.SampleOfFinancialSanads>();
        }

        public SampleOfFinancialSanadsList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

