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
    public partial class AssignExecuters : RASF.General.Forms.Base.DockContentForm
    {
        private RASF.General.Data.AssignExecuters Executer;
        private Byte[] Pic_Array;
        public AssignExecuters()
        {
            InitializeComponent();
        }

        private void AssignExecuters_Load(object sender, EventArgs e)
        {
            this.assignGroupList1.Fill();
           
            General.Classes.Utility.Create_DropDown(this.grdExecuters.RootTable.Columns["TecnicalManagerID"], this.assignGroupList1, "GroupId", "GroupName");
            General.Classes.Utility.Create_DropDown(this.grdExecuters.RootTable.Columns["SientificManagerID"], this.assignGroupList1, "GroupId", "GroupName");


            this.grdExecuters.RootTable.Columns["TecnicalManagerID"].DefaultValue = this.assignGroupList1[0].GroupId;
            this.grdExecuters.RootTable.Columns["SientificManagerID"].DefaultValue = this.assignGroupList1[0].GroupId;

            this.assignExecutersList1.Fill();
            this.grdExecuters.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.assignExecutersList1.Update();

            this.assignExecutersList1.Fill();
            this.grdExecuters.Refetch();
        }

        private void grdExecuters_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            Executer = (RASF.General.Data.AssignExecuters)this.grdExecuters.CurrentRow.DataRow;
            switch (e.Column.Key)
            {
                case "Sgin1":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Executer != null)
                        {
                            Executer.Sgin1 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                            Executer.Sgin1 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Executer.RowState = General.Enums.RowState.Updated;

                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                        }
                    }
                    break;
                case "Sgin2":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Executer != null)
                        {
                            Executer.Sgin2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                            Executer.Sgin2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            Executer.RowState = General.Enums.RowState.Updated;

                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                        }
                    }
                    break;
            }
        }
    }
}
