using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
   public class DropDown : Janus.Windows.EditControls.UIComboBox
    {
       [System.ComponentModel.Category("RASF")]
       public DropDown()
           : base()
       {
           this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
       }
    }
}
