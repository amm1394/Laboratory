using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class Companies_English : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public Guid EnglishCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"([A-Z|a-z| ]*) ([A-Z|a-z]*) ([\d|A-Z]*)")]
        [RASF.General.Attributes.DataAttribute("نام شرکت", "")]
         public String EnglishName
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator(@"([A-Z|a-z| ]*) ([A-Z|a-z]*) ([\d|A-Z]*)")]
        [RASF.General.Attributes.DataAttribute("آدرس", "")]
        public string EnglishAddress
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{10}")]
        [RASF.General.Attributes.DataAttribute("کد پستی", "Number0")]
        public int PostCode
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

        public Companies_English()
        {
           // this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
    
}
