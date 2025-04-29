using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class TempAndHumid : RASF.General.Forms.Base.DockContentForm
    {
        public TempAndHumid()
        {
            InitializeComponent();
        }
              
        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Classes.Global.temprature =Convert.ToInt16(mnbTemprature.Value);
            RASF.General.Classes.Global.humid = Convert.ToInt32(mnbHumid.Value);
        }

        private void TempAndHumid_Load(object sender, EventArgs e)
        {
            mnbTemprature.Value = RASF.General.Classes.Global.temprature;
            mnbHumid.Value = RASF.General.Classes.Global.humid;
        }
    }
}
