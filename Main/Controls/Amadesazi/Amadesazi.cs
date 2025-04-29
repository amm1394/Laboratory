using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Amadesazi
{
    public partial class Amadesazi : UserControl
    {

        public event System.EventHandler GetData;
        private Janus.Windows.GridEX.GridEXFormatStyle TakhirFormat;
        private Janus.Windows.GridEX.GridEXFormatStyle TEstFormat;


        public string UserName
        {
            get { return this.label1.Text; }
            set { this.label1.Text = value; }
        }

        public string CNKol
        {
            get { return this.label8.Text; }
            set { this.label8.Text = value; }
        }

        public string CNTakhiri
        {
            get { return this.label2.Text; }
            set { this.label2.Text = value; }
        }


        public List<RASF.General.Data.TahviliAmadesazi> DataSource
        {
            get { return this.tahviliAmadesaziList1.list; }
            set
            {
                if (value != null)
                {

                    this.tahviliAmadesaziList1.list.Clear();
                    this.tahviliAmadesaziList1.list.AddRange(value);

                    Int16 i = 1;
                    foreach (RASF.General.Data.TahviliAmadesazi row in this.tahviliAmadesaziList1.list)
                    {
                        row.Radif = i++;
                    }

                    this.label3.Text = this.tahviliAmadesaziList1.Count().ToString();
                    this.label6.Text = this.tahviliAmadesaziList1.Where(row => row.Takhiri == true).Count().ToString();

                    this.SetData();
                }
            }
        }

        public Amadesazi()
        {
            InitializeComponent();
            this.TakhirFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TakhirFormat.BackColor = Color.DarkRed;
            this.TakhirFormat.ForeColor = Color.White;

            this.TEstFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.TEstFormat.BackColor = Color.Gold;
            this.TEstFormat.ForeColor = Color.Black;
        }

        private void SetData()
        {
            List<RASF.General.Data.TahviliAmadesazi> data = (from row in this.tahviliAmadesaziList1 select row).Take(23).ToList<RASF.General.Data.TahviliAmadesazi>();
            this.tahviliAmadesaziList1.list.RemoveRange(0, data.Count());
            this.grid1.DataSource = data;
            this.grid1.Refetch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.tahviliAmadesaziList1.list.Count == 0)
            {
                if (this.GetData != null)
                {
                    this.GetData(this, new EventArgs());
                }
            }
            else
            {
                this.SetData();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.panel9.Width = (this.panel9.Width + this.panel6.Width) / 2;
        }

        private void grid1_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToBoolean(e.Row.Cells["Marking"].Value) == true)
            {
                e.Row.Cells["MarkingImage"].Image = global::Main.Properties.Resources.Marking;
            }


            if (Convert.ToBoolean(e.Row.Cells["Amadesazi"].Value) == true)
            {
                e.Row.Cells["AmadesaziImage"].Image = global::Main.Properties.Resources.user;
            }
            
            if (Convert.ToBoolean(e.Row.Cells["Takhiri"].Value) == true)
            {
                e.Row.Cells["DateOfTest"].FormatStyle = this.TakhirFormat;
            }

            if (Convert.ToBoolean(e.Row.Cells["TestPresence"].Value) == true)
            {
                e.Row.Cells["MasterName"].FormatStyle = this.TEstFormat;
            }

        }

        private void grid1_SizeChanged(object sender, EventArgs e)
        {
           
            foreach(Janus.Windows.GridEX.GridEXColumn col in this.grid1.RootTable.Columns)
            {
                if (col.Visible == true)
                {
                    col.Width = (int)((Convert.ToInt16(col.Tag) / 100f) * (this.grid1.Width - 20));
                }
            }
        }
    }
}
