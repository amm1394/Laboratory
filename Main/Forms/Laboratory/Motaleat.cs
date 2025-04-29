using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class Motaleat :RASF.General.Forms.Base.DockContentForm
    {
        public Motaleat()
        {
            InitializeComponent();
        }

        private void Motaleat_Load(object sender, EventArgs e)
        {
            this.motaleatList1.Fill();
            this.grid1.Refetch();
        }
    }
}
