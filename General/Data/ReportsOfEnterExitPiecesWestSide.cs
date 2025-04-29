using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class ReportsOfEnterExitPiecesWestSide : RASF.General.InterFaces.IRow
    {
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreWestSide> ReportsOfEnterExitPiecesForStoreWestSide { get; set; }
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryWestSide> ReportsOfEnterExitPiecesForLaboratoryWestSide { get; set; }
        


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid Parts_Master_Code
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام نمونه","")]
        public String Name
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شماره تنوع","")]
        public int PartNumber
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public ReportsOfEnterExitPiecesWestSide()
        {

        }
    }
}
