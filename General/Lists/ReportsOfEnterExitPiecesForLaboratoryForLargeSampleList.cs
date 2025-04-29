using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample>
    {
        public ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList()
        {
            this.spName = "ReportsOfEnterExitPiecesForLaboratoryForLargeSample";
            this.list = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample>();
            this.deletedlist = new List<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample>();
        }

        public ReportsOfEnterExitPiecesForLaboratoryForLargeSampleList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
    }
    }

