using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Was.Forms
{
    public partial class Insert_Was : Form
    {
        public event System.EventHandler ReturnWas;
        public String FileName { get; set; }
        public Insert_Was()
        {
            InitializeComponent();
        }

        private void Insert_Arl_Load(object sender, EventArgs e)
        {
            this.WasList1.Fill();
            this.grid3.Refetch();
        }

        private void grid3_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.ReturnWas != null)
            {
                this.ReturnWas(this.grid3.CurrentRow.DataRow, new EventArgs());
            }
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
