using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Arl_Eleman : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("نام عنصر", "")]
        public string Name { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute("مقدار", "")]
        public string Value { get; set; }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public Arl_Eleman()
        {
            this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
