using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class ReportsOfEnterExitPiecesLargeSample : RASF.General.InterFaces.IRow
    {
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForStoreLargeSample> ReportsOfEnterExitPiecesForStoreLargeSample { get; set; }
         public RASF.General.Lists.Base.BaseList<RASF.General.Data.ReportsOfEnterExitPiecesForLaboratoryLargeSample> ReportsOfEnterExitPiecesForLaboratoryLargeSample { get; set; }
       


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

        public ReportsOfEnterExitPiecesLargeSample()
        {

        }
    }
}
