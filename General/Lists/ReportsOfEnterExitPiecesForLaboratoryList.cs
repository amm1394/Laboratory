using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForLaboratoryList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratory>
    {
        public ReportsOfEnterExitPiecesForLaboratoryList()
        {
            this.spName = "ReportsOfEnterExitPiecesForLaboratory";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratory>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratory>();
        }

        public ReportsOfEnterExitPiecesForLaboratoryList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

