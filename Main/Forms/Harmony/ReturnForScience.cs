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
    public partial class ReturnForScience : RASF.General.Forms.Base.DockContentForm
    {
        public ReturnForScience()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                try
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.findContractNoList1.Fill(Parameter);

                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.returnForScienceList1.Fill(Parameter1);
                    this.grdParts.Refetch();
                }

                catch
                {
                    System.Windows.Forms.MessageBox.Show("اطلاعات وارد شده صحیح نمی یاشد");
                }
            }
        }

        private void grdParts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdParts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Parts_Master CurrentRow = (RASF.General.Data.Parts_Master)this.grdParts.SelectedItems[0].GetRow().DataRow;
                CurrentRow.RowState = General.Enums.RowState.Updated;
                this.returnForScienceList1.Update();
            }
           
        }
    }
}
