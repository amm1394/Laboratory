using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{
    public partial class showWorkFlowDescription : RASF.General.Forms.Base.DockContentForm
    {
        private Guid parttestmastercode;
        public showWorkFlowDescription(Guid PartTestMaster)
        {
            InitializeComponent();
            this.ShowpnlButton = false;
            this.showWorkFlowDescriptionList1.spName = "ShowWorkFlowDescriptionForPartTestMaster";
            this.parttestmastercode = PartTestMaster;
        }

        private void showWorkFlowDescription_Load(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter5 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter5.Add(new System.Data.SqlClient.SqlParameter("PartTestMasterCode", parttestmastercode));
            this.showWorkFlowDescriptionList1.Fill(Parameter5);
            if (showWorkFlowDescriptionList1 != null)
            {
                this.grdWorkFlow.Refetch();
            }
        }
    }
}
