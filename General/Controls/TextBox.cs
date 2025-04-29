using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
   public class TextBox : Janus.Windows.GridEX.EditControls.EditBox
    {
       [System.ComponentModel.Category("RASF")]
       public  TextBox() 
           :base()
       {
           this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
       }
    }
}
