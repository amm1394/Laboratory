using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SentPartToContractorsForBillList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public SentPartToContractorsForBillList()
        {
            this.spName = "SentPartToContractorsForBill";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public SentPartToContractorsForBillList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

