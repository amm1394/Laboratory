using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ShowDescDeliveryReport : Form
    {
        private Guid contractcode;
        public ShowDescDeliveryReport(Guid code)
        {
            InitializeComponent();
            this.contractcode = code; 
        }

        private void ShowDescDeliveryReport_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Param = new List<System.Data.SqlClient.SqlParameter>();
            Param.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", this.contractcode));
            this.textBox1.Text = RASF.General.Lists.Base.BaseList<Object>.FillScalar("ShowDescDeliveryReportThetNotIsCompleted", Param).ToString();
        }
    }
}
