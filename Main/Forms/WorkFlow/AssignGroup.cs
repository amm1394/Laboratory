using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.WorkFlow
{
    public partial class AssignGroup : RASF.General.Forms.Base.DockContentForm
    {
        public AssignGroup()
        {
            InitializeComponent();
        }
        private RASF.General.Data.Laboratory Laboratory;
        private Byte[] Pic_Array;

        private void AssignGroup_Load(object sender, EventArgs e)
        {
            this.assignGroupList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdAssign.RootTable.Columns["CreatorID"], this.assignGroupList1, "GroupId", "GroupName");
            General.Classes.Utility.Create_DropDown(this.grdAssign.RootTable.Columns["ExpertID"], this.assignGroupList1, "GroupId", "GroupName");
            General.Classes.Utility.Create_DropDown(this.grdAssign.RootTable.Columns["TecnicalManagerID"], this.assignGroupList1, "GroupId", "GroupName");
            General.Classes.Utility.Create_DropDown(this.grdAssign.RootTable.Columns["SientificManagerID"], this.assignGroupList1, "GroupId", "GroupName");

            this.grdAssign.RootTable.Columns["CreatorID"].DefaultValue = this.assignGroupList1[0].GroupId;
            this.grdAssign.RootTable.Columns["ExpertID"].DefaultValue = this.assignGroupList1[0].GroupId;
            this.grdAssign.RootTable.Columns["TecnicalManagerID"].DefaultValue = this.assignGroupList1[0].GroupId;
            this.grdAssign.RootTable.Columns["SientificManagerID"].DefaultValue = this.assignGroupList1[0].GroupId;

            this.laboratoryForWorkFlowList1.Fill();
            this.grdAssign.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.laboratoryForWorkFlowList1.Update();

            this.laboratoryForWorkFlowList1.Fill();
            this.grdAssign.Refetch();
        }

        private void grdAssign_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Laboratory = (General.Data.Laboratory)this.grdAssign.CurrentRow.DataRow;
            switch (e.Column.Key)
            {
                case "Sgin1":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Laboratory != null)
                        {
                            Laboratory.Sgin1 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
//                            Laboratory.Sgin1 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Laboratory.RowState = General.Enums.RowState.Updated;
                          
                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                        }
                    }
                    break;
                case "Sgin2":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Laboratory != null)
                        {
                            Laboratory.Sgin2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
  //                          Laboratory.Sgin2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Laboratory.RowState = General.Enums.RowState.Updated;

                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                        }
                    }
                    break;
                case "Sgin3":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Laboratory != null)
                        {
                            Laboratory.Sgin3 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                            //                            Laboratory.Sgin1 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Laboratory.RowState = General.Enums.RowState.Updated;

                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                        }
                    }
                    break;
                case "Sgin4":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Laboratory != null)
                        {
                            Laboratory.Sgin4 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                            //                          Laboratory.Sgin2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Laboratory.RowState = General.Enums.RowState.Updated;

                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 500);
                        }
                    }
                    break;
            }
        }
    }
}
