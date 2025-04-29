using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class MasterTarrif : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
        public Guid MasterCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{10}")]
        [RASF.General.Attributes.DataAttribute("قیمت واحد آزمون برای آزمایشگاه ", "Number0")]
        public int LabInCome
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("[0-9]{10}")]
        [RASF.General.Attributes.DataAttribute("قیمت واحد مبلغ درآمد", "Number0")]
        public int InvoicePrice
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

        public MasterTarrif()
        {
          //  this.RowState = RASF.General.Enums.RowState.Original;
        }
    }
}
