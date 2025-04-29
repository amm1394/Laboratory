using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class ReportsOfEnterExitPiecesWestSideForm : RASF.General.Forms.Base.DockContentForm
    {
       // public Guid ContractsCodeForEnterExitPiecesForm = Guid.Empty;
        public ReportsOfEnterExitPiecesWestSideForm()
        {
            InitializeComponent();
            this.ShowpnlSave = false;
        }

      
        private void RefechGrids()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", RASF.General.Classes.Global.ContractsCode));
            this.reportsOfStoreWestSideList1.Fill(Parameter);

            this.grdParts.Refetch();
        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            RASF.General.Classes.Global.ContractsCode = e.ContractsCode;
            RefechGrids();
        }

      }
}
