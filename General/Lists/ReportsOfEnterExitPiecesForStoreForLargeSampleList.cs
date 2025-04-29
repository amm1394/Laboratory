using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForStoreForLargeSampleList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreLargeSample>
    {
        public ReportsOfEnterExitPiecesForStoreForLargeSampleList()
        {
            this.spName = "ReportsOfEnterExitPiecesForStoreForLargeSample";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStoreLargeSample>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForStoreLargeSample>();
        }

        public ReportsOfEnterExitPiecesForStoreForLargeSampleList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

