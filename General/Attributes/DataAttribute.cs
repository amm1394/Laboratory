using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Attributes
{
    public class DataAttribute : System.Attribute
    {
        [System.ComponentModel.Category("RASF")]
        public String Caption;
        [System.ComponentModel.Category("RASF")]
        public String DataType;
        [System.ComponentModel.Category("RASF")]
        public Boolean Visibale;
        [System.ComponentModel.Category("RASF")]
        public Boolean IsUnique;
        [System.ComponentModel.Category("RASF")]
        public RASF.General.Enums.BookMark SetBookMark;


        public DataAttribute()
        {
            this.Caption = "";
            this.Visibale = false;
            this.IsUnique = false;
            this.DataType = String.Empty;
            this.SetBookMark = Enums.BookMark.AddState;
        }
        public DataAttribute(RASF.General.Enums.BookMark setBookMark)
        {
            this.Caption = "";
            this.Visibale = false;
            this.IsUnique = false;
            this.DataType = String.Empty;
            this.SetBookMark = setBookMark;
        }

        public DataAttribute(String caption,String dataType)
        {
            this.Caption = caption;
            this.Visibale = true;
            this.IsUnique = false;
            this.DataType = dataType;
            this.SetBookMark = Enums.BookMark.AddState;
        }

        public DataAttribute(Boolean isUnique)
        {
            this.Caption = "";
            this.Visibale = false;
            this.IsUnique = isUnique;
            this.DataType = String.Empty;
            this.SetBookMark = Enums.BookMark.AddState;
        }
        public DataAttribute(String caption, Boolean visibale, String dataType)
        {
            this.Caption = caption;
            this.Visibale = visibale;
            this.DataType = dataType;
            this.SetBookMark = Enums.BookMark.AddState;
        }
    }
}
