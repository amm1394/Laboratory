using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

     public class MasterTest : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute(true)]
         public Guid MasterTestCode
        {
            get;
            set;
        }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
         [RASF.General.Attributes.DataAttribute("نام آزمون", "")]
         public String MainTestName
         {
             get;
             set;
         }

         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
         [RASF.General.Attributes.DataAttribute("نام آزمایشگاه", "")]
         public String LaboratoryName
         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("نام آزمایش", "")]
         public String MasterName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("تعداد تنوع", "Number0")]
        public int TemplateCount
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public int MasterNanoId
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public string NanoDesc
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"^[0-9\u0600-\u06FF\s]+$")]
        [RASF.General.Attributes.DataAttribute("توضیحات", "")]
        public string Description
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("قابلیت چاپ", "")]
        public byte Printable
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اولویت چاپ", "Number0")]
        public int Priority
        {
            get;
            set;
        }
        //اولویت پذیرش
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اولویت", "Number0")]
        public int PriorityRec
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("Lable چاپ", "")]
        public Boolean PrintLable
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("دانشجو", "")]
        public Boolean Student
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid MainTestCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("وضعیت", "")]
        public byte Status
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("دانش بنیان", "")]
        public Boolean DaneshBonyan
        {
            get;
            set;
        }


        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("دانش بنیان اولیه", "")]
        public Boolean FirstDaneshBonyan
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("قابل انجام در بنیاد", "")]
        public Boolean CarriedoutintheBonyad
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تعرفه پرکاربرد", "")]
        public Boolean ComonTarrifs
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

        public MasterTest()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
