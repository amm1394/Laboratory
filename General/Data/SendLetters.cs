using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class SendLetters : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid SendLettersCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شماره نامه","")]
        public int LettersNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("گروه بندی واحدها","")]
        public int GroupingCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("گروه بندی واحدها", "")]
        public string GroupingNme
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("موضوع", "")]
        public string SubjectOfLetters
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نوع ارسال", "")]
        public int SendType
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نوع ارسال", "")]
        public string SendTypeName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اقدام کننده", "")]
        public int ActingGroupCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("اقدام کننده", "")]
        public string ActingGroupName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("کاربر ثبت کننده", "")]
        public string UserRegister
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("دریافت کننده", "")]
        public string Reciever
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شماره نامه شرکت", "")]
        public string CompanyLetterNo
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("توضیحات نوع ارسال", "")]
        public string DescForSendType
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نامه", "")]
        public byte[] Letter
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ ارسال", "")]
        public string StrSendDate
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("شرکت", "")]
        public string CompanyName
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

        public SendLetters()
        {

        }
    }
}
