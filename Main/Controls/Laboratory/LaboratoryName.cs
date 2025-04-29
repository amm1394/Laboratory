using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Laboratory
{
    public partial class LaboratoryName : UserControl
    {
        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler SelectedValueChanged
        {
            add { this.drpName.SelectedValueChanged += value; }
            remove { this.drpName.SelectedValueChanged -= value; }
        }

        public Guid LabCode
        {
            get { return (Guid)drpName.SelectedValue; }
        }
        public String Lab1Name
        {
            get { return drpName.Text; }
        }
        public LaboratoryName()
        {
            InitializeComponent();
        }

        private void OfficesName_Load(object sender, EventArgs e)
        {
            this.laboratoryList1.Fill();
            General.Classes.Utility.CreateDropDow(drpName, "LaboratoryName", "LaboratoryCode", laboratoryList1);
            this.drpName.SelectedIndex = 0;
        }

          
    }
}
