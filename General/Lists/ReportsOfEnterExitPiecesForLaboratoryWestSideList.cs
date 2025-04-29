using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForLaboratoryWestSideList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide>
    {
        public ReportsOfEnterExitPiecesForLaboratoryWestSideList()
        {
            this.spName = "ReportsOfEnterExitPiecesForLaboratoryForWestSide";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide>();
        }

        public ReportsOfEnterExitPiecesForLaboratoryWestSideList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

