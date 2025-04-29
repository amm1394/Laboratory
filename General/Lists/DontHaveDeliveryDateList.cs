using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DontHaveDeliveryDateList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DetailOfReception>
    {
        public DontHaveDeliveryDateList()
        {
            this.spName = "DontHaveDeliveryDate";
            this.list = new List<RASF.General.Data.DetailOfReception>();
            this.deletedlist = new List<RASF.General.Data.DetailOfReception>();
        }

        public DontHaveDeliveryDateList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

