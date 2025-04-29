using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Arl_Elements : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("تاریخ", "")]
        public String Date { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public String Task { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("پایه", "")]
        public String Base { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام", "")]
        public String Name { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public List<RASF.General.Data.Arl_Eleman> Eleman { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public Arl_Elements()
        {
            this.RowState = RASF.General.Enums.RowState.Original;
            this.Eleman = new List<Arl_Eleman>();
        }
    }
}
