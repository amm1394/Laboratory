using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class Connector_PeapleRelatedForm : RASF.General.Forms.Base.DockContentForm
    {
        public Connector_PeapleRelatedForm()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        private void Connector_PeapleRelatedForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("@ConnectorId", RASF.General.Classes.Global.CurrentUserCode));
            this.connector_PeapleRelatedList1.Fill(Parameter1);
            this.grdcompany.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void grdcompany_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdcompany.CurrentRow != null) && (this.grdcompany.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.groupBox2.Text = String.Format("شرکت {0}", this.grdcompany.CurrentRow.Cells["CompanyName"].Value);
            }
            else
            {
                this.groupBox2.Text = "";
            }

        }
        private void grdcompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            try
            {
                if (this.grdcompany.SelectedItems.Count > 0)
                {
                    RASF.General.Data.Connector_PeapleRelated Current_Contract = (RASF.General.Data.Connector_PeapleRelated)this.grdcompany.SelectedItems[0].GetRow().DataRow;
                    if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                    {
                        Current_Contract.RowState = General.Enums.RowState.Updated;
                        this.connector_PeapleRelatedList1.Update();
                      
                    }
                    FillGrid();
                }
            }
            catch
            {
            }

        }
    }
}
