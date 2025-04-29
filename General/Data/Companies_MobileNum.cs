using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{

    public class Companies_MobileNum : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
        public Guid MobileNumCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid CompanyCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("تلفن همراه", "")]
        public string MobileNum
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("شرکت", "")]
        public string CompanyName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("تلفن همراه", "")]
        public string TelegramNum
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("تلفن همراه", "")]
        public string WhatsappNum
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]")]
        [RASF.General.Attributes.DataAttribute("تلفن همراه", "")]
        public string PasswordNum
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

        public Companies_MobileNum()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
