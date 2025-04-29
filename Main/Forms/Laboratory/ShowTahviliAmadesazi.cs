using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class ShowTahviliAmadesazi : RASF.General.Forms.Base.DockContentForm
    {
        public ShowTahviliAmadesazi()
        {
            InitializeComponent();
        }

        private void ShowTahviliAmadesazi_Load(object sender, EventArgs e)
        {
            this.showTahviliAmadesaziList1.Fill();
            this.grid1.Refetch();
        }

        private void grid1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }
    }
}
