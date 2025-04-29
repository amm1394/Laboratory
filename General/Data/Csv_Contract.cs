using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Csv_Contract : RASF.General.InterFaces.IRow
    {
        public Csv_Contract()
        {
            this.Csv_DataList = new List<Csv_Data>();
        }

        [System.ComponentModel.Category("RASF")]
        public List<Csv_Data> Csv_DataList
        {
            get;
            set;
        }
  
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام نمونه", "")]
        public String Name 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("پایه", "")]
        public String Base 
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ", "")]
        public String Date
        {
            get;
            set;
        }

        public Enums.RowState RowState
        {
            get;
            set;
        }
    }
}
