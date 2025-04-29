using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.InterFaces
{
    [System.ComponentModel.Category("RASF")]
    interface IRow
    {
        RASF.General.Enums.RowState RowState { get; set; }
    }
}
