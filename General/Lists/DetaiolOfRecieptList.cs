using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DetaiolOfRecieptList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetaiolOfReciept>
    {
        public DetaiolOfRecieptList()
        {
            this.spName = "DetaiolOfReciept";
            this.list = new List<RASF.General.Data.DetaiolOfReciept>();
            this.deletedlist = new List<RASF.General.Data.DetaiolOfReciept>();
        }

        public DetaiolOfRecieptList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

