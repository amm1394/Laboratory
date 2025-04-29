using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SentPartToContractorsForVoidList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public SentPartToContractorsForVoidList()
        {
            this.spName = "SentPartToContractorsForVoid";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public SentPartToContractorsForVoidList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

