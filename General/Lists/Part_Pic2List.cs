using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class Part_Pic2Lis : RASF.General.Lists.Base.BaseList<RASF.General.Data.Part_Pic>
    {
        public Part_Pic2Lis()
        {
            this.spName = "Part_Pic2";
            this.list = new List<RASF.General.Data.Part_Pic>();
            this.deletedlist = new List<RASF.General.Data.Part_Pic>();
        }

        public Part_Pic2Lis(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

