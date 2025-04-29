using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms
{
    [System.ComponentModel.Category("RASF")]
    public partial class MACHINS : RASF.General.Forms.Base.DockContentForm
    {
        public MACHINS()
        {
            InitializeComponent();
        }

        private void MACHINS_Load(object sender, EventArgs e)
        {
            this.machinslist1.Fill();
            this.labList1.Fill();
            this.activeNonActiveList1.Fill();
            this.userList1.Fill();
            this.laboratoryMachinList1.Fill();


            this.grdMACHINS.Refetch();

            this.grdMACHINS.RemoveBindingContextChanged();

            General.Classes.Utility.Create_DropDown(this.grdMACHINS.RootTable.Columns["UserID"], this.userList1, "UserId", "UserName");
            General.Classes.Utility.Create_DropDown(this.grdMACHINS.RootTable.Columns["Status"], this.activeNonActiveList1, "Code", "ActOrNonAct");
            General.Classes.Utility.Create_DropDown(this.grdMACHINS.RootTable.Columns["LaboratoryCode_Machin"], this.labList1, "LaboratoryCode", "LaboratoryName");
            General.Classes.Utility.Create_DropDown(this.grdMACHINS.RootTable.Columns["MachinNameID"], this.laboratoryMachinList1, "Code", "MachinName");


            this.grdMACHINS.RootTable.Columns["UserID"].DefaultValue = this.userList1[0].UserId;
            this.grdMACHINS.RootTable.Columns["Status"].DefaultValue = this.activeNonActiveList1[0].Code;
            this.grdMACHINS.RootTable.Columns["LaboratoryCode_Machin"].DefaultValue = this.labList1[0].LaboratoryCode;
            this.grdMACHINS.RootTable.Columns["MachinNameID"].DefaultValue = this.laboratoryMachinList1[0].Code;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.machinslist1.Update();
        }

       
    }
}
