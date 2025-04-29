using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReceiveChequeList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReceiveCheque>
    {
        public ReceiveChequeList()
        {
            this.spName = "ReceiveCheque";
            this.list = new List<RASF.General.Data.ReceiveCheque>();
            this.deletedlist = new List<RASF.General.Data.ReceiveCheque>();
        }

        public ReceiveChequeList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

