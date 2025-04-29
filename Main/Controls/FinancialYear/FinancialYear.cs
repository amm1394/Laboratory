using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.FinancialYear
{
    public partial class FinancialYear : UserControl
    {
        [System.ComponentModel.Category("RASF")]
        public event System.EventHandler SelectedValueChanged
        {
            add { this.drpYear.SelectedValueChanged += value; }
            remove { this.drpYear.SelectedValueChanged -= value; }
        }

        //public Guid OfficesCode
        //{
           // get { return (Guid)drpYear.SelectedValue; }
        //}
        public int ContractYear
        {
            get { return Convert.ToInt32(drpYear.Text); }
        }
        public FinancialYear()
        {
            InitializeComponent();
        }

        private void OfficesName_Load(object sender, EventArgs e)
        {
            this.changeYearList1.Fill();
            General.Classes.Utility.CreateDropDow(drpYear, "ContractYear", "", changeYearList1);
            this.drpYear.SelectedIndex = 0;
        }

          
    }
}
