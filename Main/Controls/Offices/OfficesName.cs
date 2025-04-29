using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Offices
{
    public partial class OfficesName : UserControl
    {
        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler SelectedValueChanged
        {
            add { this.drpName.SelectedValueChanged += value; }
            remove { this.drpName.SelectedValueChanged -= value; }
        }

        public Guid OfficesCode
        {
            get { return (Guid)drpName.SelectedValue; }
        }
        public String OfficeName
        {
            get { return drpName.Text; }
        }
        public OfficesName()
        {
            InitializeComponent();
        }

        private void OfficesName_Load(object sender, EventArgs e)
        {
            this.companiesAgencyListList1.Fill();
            General.Classes.Utility.CreateDropDow(drpName, "AgencyName", "AgencyCode", companiesAgencyListList1);
            this.drpName.SelectedIndex = 0;
        }

          
    }
}
