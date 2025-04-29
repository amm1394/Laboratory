using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class LaboratoryUser : RASF.General.Forms.Base.DockContentForm
    {
        private Guid LaboratoryCode = Guid.Empty;
        private Guid GroupId = Guid.Empty;

        public LaboratoryUser()
        {
            InitializeComponent();
        }

        private void LaboratoryUser_Load(object sender, EventArgs e)
        {
            this.laboratoryList1.Fill();

            this.grdLaboratory.Refetch();

        }

        private void grdLaboratory_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdLaboratory.CurrentRow != null) && (this.grdLaboratory.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpLaboratory.Text = String.Format("آزمایشگاه {0}", this.grdLaboratory.CurrentRow.Cells["LaboratoryName"].Value);
            }
            else
            {
                this.grpLaboratory.Text = "";
            }

            if (this.grdLaboratory.SelectedItems.Count > 0)
            {
                RASF.General.Data.Laboratory Current_Lab = (RASF.General.Data.Laboratory)this.grdLaboratory.SelectedItems[0].GetRow().DataRow;

                if (Current_Lab != null)
                {

                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", Current_Lab.LaboratoryCode));
                    this.findUsersLaboratoryList1.Fill(Parameter);

                    this.grdUser.Refetch();
                }
               
            }
                      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //GroupId = Current_Lab.LaboratoryCode;
            this.findUsersLaboratoryList1.Update();
        }

        private void grdUser_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {


        }
    }
}
