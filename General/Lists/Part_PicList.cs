using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Part_PicList : RASF.General.Lists.Base.BaseList<RASF.General.Data.Part_Pic>
    {
        public Part_PicList()
        {
            this.spName = "Part_Pic";
            this.list = new List<RASF.General.Data.Part_Pic>();
            this.deletedlist = new List<RASF.General.Data.Part_Pic>();
        }

        public Part_PicList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

