using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
   public class GroupBox :Janus.Windows.EditControls.UIGroupBox
    {
       [System.ComponentModel.Category("RASF")]
       public GroupBox()
           : base()
       {
           this.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
       }
    }
}
