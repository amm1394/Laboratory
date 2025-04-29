using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class ShowDeliveryDateChange : RASF.General.Forms.Base.DockContentForm
    {
        public ShowDeliveryDateChange()
        {
            InitializeComponent();
            this.ShowpnlSave = false;
            
        }

        private void searchContract1_ReturnContractsCode(RASF.General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.showDeliveryDateChangeList1.Fill(Parameter);

            grdChangeDelivery.Refetch();
        }
    }
}
