using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class EnterForm : RASF.General.Forms.Base.DockContentForm
    {
        private Janus.Windows.GridEX.GridEXFormatStyle StepByStepFormat;
        public EnterForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;

            this.StepByStepFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.StepByStepFormat.BackColor = Color.Blue;
            this.StepByStepFormat.ForeColor = Color.Black;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            FillContracts();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.contractsNotEnteredList1.Update();

            FillContracts();
        }

        private void FillContracts()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.contractsNotEnteredList1.Fill(Parameter);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContracts();
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ContractsNotEntered CurrentRow = (RASF.General.Data.ContractsNotEntered)this.grdContracts.CurrentRow.DataRow;
            RASF.Main.Forms.Laboratory.ViewCostPaperLaboratory CostPaper = new Laboratory.ViewCostPaperLaboratory(CurrentRow.ContractsCode, CurrentRow.ContractNo);
            CostPaper.Show();
        }

        private void grdContracts_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            //if (e.Row.Cells["StepByStep"].Value != null)
            //{
            //    if (Convert.ToString(e.Row.Cells["StepByStep"].Value) == "بله")
            //    {
            //        e.Row.Cells["StepByStep"].FormatStyle = this.StepByStepFormat;
            //    }
            //}
        }
    }
}
