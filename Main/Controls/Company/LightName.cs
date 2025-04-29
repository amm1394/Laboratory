using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Company
{
    public partial class LightName : UserControl
    {
        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler SelectedValueChanged
        {
            add { this.drpName.SelectedValueChanged += value; }
            remove { this.drpName.SelectedValueChanged -= value; }
        }

        public Byte LightCode
        {
            get { return (Byte)drpName.SelectedValue; }
        }
        public String LightName1
        {
            get { return drpName.Text; }
        }
        public LightName()
        {
            InitializeComponent();
        }

        private void OfficesName_Load(object sender, EventArgs e)
        {
            this.lightDescList1.Fill();
            General.Classes.Utility.CreateDropDow(drpName, "Description", "Code", lightDescList1);
            this.drpName.SelectedIndex = 0;
        }

          
    }
}
