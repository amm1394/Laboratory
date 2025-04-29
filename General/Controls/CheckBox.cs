using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
   public class CheckBox : Janus.Windows.EditControls.UICheckBox
    {
        [System.ComponentModel.Category("RASF")]
       public CheckBox()
           : base()
       {
           this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
       }
    }
}
