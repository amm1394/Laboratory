using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Controls
{
    public class StatusBar : Janus.Windows.UI.StatusBar.UIStatusBar
    {
        [System.ComponentModel.Category("RASF")]
        public StatusBar()
            : base()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }
    }
}
