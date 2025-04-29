using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Payment_AssignmentList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Payment_Assignment>
    {
        public Payment_AssignmentList()
        {
            this.spName = "Payment_Assignment";
            this.list = new List<RASF.General.Data.Payment_Assignment>();
            this.deletedlist = new List<RASF.General.Data.Payment_Assignment>();
        }

        public Payment_AssignmentList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

