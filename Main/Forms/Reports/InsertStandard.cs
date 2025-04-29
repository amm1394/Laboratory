using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reports
{
    public partial class InsertStandard : RASF.General.Forms.Base.DockContentForm
    {
        public InsertStandard()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void InsertStandard_Load(object sender, EventArgs e)
        {
            this.insertStandardList1.Fill();
            this.grdStandard.Refetch();
        }

        private void grdStandard_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Guid Code = (Guid)this.grdStandard.CurrentRow.Cells["Code"].Value;

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("StandardNameCode", Code));
            this.standardDataList1.Fill(Parameter);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
