using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ShowSaveCostPaperList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ShowSaveCostPaper>
    {
        public ShowSaveCostPaperList()
        {
            this.spName = "ShowSaveCostPaper";
            this.list = new List<RASF.General.Data.ShowSaveCostPaper>();
            this.deletedlist = new List<RASF.General.Data.ShowSaveCostPaper>();
        }

        public ShowSaveCostPaperList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

