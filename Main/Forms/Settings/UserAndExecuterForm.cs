using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class UserAndExecuterForm : RASF.General.Forms.Base.DockContentForm
    {
        //private Guid LaboratoryCode = Guid.Empty;
        //private Guid GroupId = Guid.Empty;

        public UserAndExecuterForm()
        {
            InitializeComponent();
            this.executersList1.spName = "AccessToExecuters";
            this.findUsersLaboratoryList1.spName = "FindUsersForExecuter";
        }

        private void LaboratoryUser_Load(object sender, EventArgs e)
        {

           
            this.activeNonActiveList1.Fill();
            this.executersList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdUser.RootTable.Columns["ExecuterId"], this.executersList1, "UserId", "UserName");
            this.grdUser.RootTable.Columns["ExecuterId"].DefaultValue = this.executersList1[1].UserId;

            General.Classes.Utility.Create_DropDown(this.grdUser.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");

            this.findUsersLaboratoryList1.Fill();
            this.grdUser.Refetch();
           // this.userAccesMenuList1.Fill();

           // this.grdExecuters.Refetch();

        }

        private void grdLaboratory_SelectionChanged(object sender, EventArgs e)
        {
            //if ((this.grdExecuters.CurrentRow != null) && (this.grdExecuters.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            //{
            //    this.grpLaboratory.Text = String.Format("مسئول اجرایی : {0}", this.grdExecuters.CurrentRow.Cells["UserName"].Value);
            //}
            //else
            //{
            //    this.grpLaboratory.Text = "";
            //}

            //if (this.grdExecuters.SelectedItems.Count > 0)
            //{
            //    RASF.General.Data.Executers Current_Lab = (RASF.General.Data.Executers)this.grdExecuters.SelectedItems[0].GetRow().DataRow;

                //if (Current_Lab != null)
                //{

                   // List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                   // Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", Current_Lab.UserId));
                    //this.findUsersLaboratoryList1.Fill();

                    //this.grdUser.Refetch();
            //    }
               
            //}
                      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //GroupId = Current_Lab.LaboratoryCode;
            this.findUsersLaboratoryList1.Update();
        }

        private void grdUser_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
