using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
    public class RadioButton : Janus.Windows.EditControls.UIRadioButton
    {
        [System.ComponentModel.Category("RASF")]
        public RadioButton()
            : base()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }
    }
}
