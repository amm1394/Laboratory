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
    public partial class PickDate : UserControl
    {
        public event RASF.General.Events.ReturnSelectedDates DateSelected;
        public PickDate()
        {
            InitializeComponent();

            pickdateFrom.IsNull = true;
            pickDateTo.IsNull = true;

            pickdateFrom.SelectedDateTime = System.DateTime.Now.AddDays(0);
            pickDateTo.SelectedDateTime = System.DateTime.Now.AddDays(0);

            pickdateFrom.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(System.DateTime.Now).ToString("yyyy/mm/dd");
            pickDateTo.Text = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(System.DateTime.Now).ToString("yyyy/mm/dd");

            //pickdateFrom.UpdateTextValue();
            //pickDateTo.UpdateTextValue();
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {

            if (new DateTime(pickdateFrom.SelectedDateTime.Year, pickdateFrom.SelectedDateTime.Month, pickdateFrom.SelectedDateTime.Day) <= new DateTime(pickDateTo.SelectedDateTime.Year, pickDateTo.SelectedDateTime.Month, pickDateTo.SelectedDateTime.Day))
            {
                if (DateSelected != null)
                {
                    DateSelected(new General.Events.ReturnSelectedDatesEventArgs(pickdateFrom.SelectedDateTime, pickDateTo.SelectedDateTime));
                }
            }
            else 
            {
                MessageBox.Show("محدوده انتخاب شده صحیح نمی باشد.", "", MessageBoxButtons.OK);
            }
        }
    }
}
