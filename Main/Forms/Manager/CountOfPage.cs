using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class CountOfPage : RASF.General.Forms.Base.DockContentForm
    {
        public CountOfPage()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.banksList1.spName = "CountOfPage";
        }

        private void pickDate1_DateSelected(RASF.General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.banksList1.Fill(Parameter);

            this.grdpage.Refetch();
        }
    }
}
