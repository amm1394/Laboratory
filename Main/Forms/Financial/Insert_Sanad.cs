using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class Insert_Sanad : RASF.General.Forms.Base.DockContentForm
    {
        DateTime BillDate = DateTime.MinValue;
        public Insert_Sanad()
        {
            InitializeComponent();
        }

        private void pickDateFrom1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            this.BillDate = e.From;
            Parameter.Add(new System.Data.SqlClient.SqlParameter("BillDate", this.BillDate));
            this.insert_SandList1.Fill(Parameter);

            this.grdSanad.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.BillDate != DateTime.MinValue)
            {
                this.insert_SandList1.Update(this.BillDate);
                this.BillDate = DateTime.MinValue;
            }
        }
    }
}
