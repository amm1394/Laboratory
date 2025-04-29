using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class EditRecieptionList : RASF.General.Lists.Base.BaseList<RASF.General.Data.EditRecieption>
    {
        public EditRecieptionList()
        {
            this.spName = "EditRecieption";
            this.list = new List<RASF.General.Data.EditRecieption>();
            this.deletedlist = new List<RASF.General.Data.EditRecieption>();
        }

        public EditRecieptionList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    
}
