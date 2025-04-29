using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    public partial class WelcomeForm : General.Forms.Base.DockContentForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
            btnExit.Visible = false;
            btnSave.Visible = false;
        }
    }
}
