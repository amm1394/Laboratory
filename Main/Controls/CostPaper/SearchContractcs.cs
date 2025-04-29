using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls
{
    public partial class SearchContract : UserControl
    {
        public event RASF.General.Events.ReturnContractsCode ReturnContractsCode;
        public int ContractNo { set { this.numContractNo.Value = value; } }
        public SearchContract()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            if (numContractNo.Text == "0" || numContractNo.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("لطفا شماره قرارداد را وارد نمایید");
            }
            if (this.ReturnContractsCode != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.numContractNo.Value));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
                this.findContractsCodeList1.Fill(Parameter);

                if (this.findContractsCodeList1.Count() > 0)
                {
                    this.ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(this.findContractsCodeList1[0].ContractsCode));
                }
                else
                {
                    MessageBox.Show("قرارداد مورد نظر یافت نشد.", "", MessageBoxButtons.OK);
                }
            }
        }

        private void numContractNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch_Click(sender, new EventArgs());
            }
        }
    }
}
