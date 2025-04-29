using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesWestSideList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreWestSide>
    {
        public ReportsOfEnterExitPiecesWestSideList()
        {
            this.spName = "ReportsOfEnterExitPiecesWestSide";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStoreWestSide>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStoreWestSide>();
        }

        public ReportsOfEnterExitPiecesWestSideList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

