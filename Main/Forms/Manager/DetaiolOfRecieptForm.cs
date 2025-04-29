using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class DetaiolOfRecieptForm : RASF.General.Forms.Base.DockContentForm
    {
        private string Id;
        public DetaiolOfRecieptForm()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = false;
        }

        public DetaiolOfRecieptForm(string ID)
            :this()
        {
           Id =ID;
        }

        private void DetaiolOfRecieptForm_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@No", Id));
            this.detaiolOfRecieptList1.Fill(Parameter);
            this.grdRec.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdRec.ExportToExcel("");
        }
    }
}
