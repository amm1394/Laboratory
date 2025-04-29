using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForStoreList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForStore>
    {
        public ReportsOfEnterExitPiecesForStoreList()
        {
            this.spName = "ReportsOfEnterExitPiecesForStore";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStore>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStore>();
        }

        public ReportsOfEnterExitPiecesForStoreList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

