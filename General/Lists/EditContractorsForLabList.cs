using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EditContractorsForLabList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractors>
    {
        public EditContractorsForLabList()
        {
            this.spName = "EditContractorsForLab";
            this.list = new List<RASF.General.Data.SentPartToContractors>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractors>();
        }

        public EditContractorsForLabList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

