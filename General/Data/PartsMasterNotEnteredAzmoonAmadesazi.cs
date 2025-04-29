using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class PartsMasterNotEnteredAzmoonAmadesazi : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
        public RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi> TestNameNotEntered { get; set; }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Boolean Check
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid ContractsBaseCode
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid Parts_Master_Code
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute("تنوع", "")]
         public int PartNumber
         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نمونه", "")]
         public string Name
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("پایه آهنی", "")]
        public string FeBase
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تخریب", "")]
        public string Destruct
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("جحیم بودن", "")]
        public string IsLarge
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

//        public PartsMasterNotEntered()
//        {
////            this.RowState = RASF.General.Enums.RowState.Original;
//        }
    }
}
