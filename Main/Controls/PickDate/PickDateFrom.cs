using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.PickDate
{
    public partial class PickDateFrom : UserControl
    {
        public event RASF.General.Events.ReturnSelectedDates DateSelected;
        public PickDateFrom()
        {
            InitializeComponent();

            pickDate.IsNull = true;

            pickDate.SelectedDateTime = System.DateTime.Now.AddDays(0);
            
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            if (DateSelected != null)
            {
                DateSelected(new General.Events.ReturnSelectedDatesEventArgs(pickDate.SelectedDateTime, pickDate.SelectedDateTime));
            }
            else
            {
                MessageBox.Show("محدوده انتخاب شده صحیح نمی باشد.", "", MessageBoxButtons.OK);
            }
        }
    }
}
