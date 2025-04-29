using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class FollowUpIsHoldContractForView : RASF.General.Forms.Base.DockContentForm
    {
        private Guid contractid;
        public FollowUpIsHoldContractForView(Guid contractid)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            
            //List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameters2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractid));
            //this.followUpIsHoldContractForViewList1.Fill(Parameters2);

            this.contractid = contractid;

        }
        

        private void FollowUpIsHoldContractForView_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", contractid));
            this.followUpIsHoldContractForViewList1.Fill(Parameters2);
            this.grdFollow.Refetch();


        }
    }
}

