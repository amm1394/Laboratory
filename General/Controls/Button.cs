using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
   public class Button : Janus.Windows.EditControls.UIButton
    {
       [System.ComponentModel.Category("RASF")]
       public Button()
           :base()
       {
           this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
       }
    }
}
   