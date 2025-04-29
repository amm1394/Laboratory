using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class AccessUser : RASF.General.Forms.Base.DockContentForm
    {
        private RASF.General.Data.UsersMenu LastRow;
        public AccessUser()
        {
            InitializeComponent();
        }

        private void AccessUser_Load(object sender, EventArgs e)
        {
            this.userAccesMenuList1.Fill();

            RASF.General.Data.UsersMenu CurrentRow = this.userAccesMenuList1.Where(row => row.UserId == new Guid("DB95A451-1371-4218-8201-AD1A42609067")).SingleOrDefault();
            if (CurrentRow != null)
            {
                this.treMenu.Nodes.AddRange(RASF.Main.Classes.MakeMenu.TreeNode(CurrentRow.XmlMenu));
                this.userAccesMenuList1.Remove(CurrentRow);
                this.userAccesMenuList1.deletedlist.Clear();
            }
            this.grdUser.Refetch();
        }

        private void grdUser_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdUser.CurrentRow != null) && (this.grdUser.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                if (LastRow != null)
                {
                    LastRow.XmlMenu = RASF.Main.Classes.MakeMenu.SaveNode(this.treMenu);
                    LastRow.RowState = General.Enums.RowState.Updated;
                }
                RASF.General.Data.UsersMenu CurrentRow = (RASF.General.Data.UsersMenu)this.grdUser.CurrentRow.DataRow;
                this.grpAccesUser.Text = String.Format("دسترسی کاربر {0}", CurrentRow.UserName);
                RASF.Main.Classes.MakeMenu.SelectNode(CurrentRow.XmlMenu, this.treMenu);
                LastRow = CurrentRow;
            }
            else
            {
                this.grpAccesUser.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LastRow != null)
            {
                LastRow.XmlMenu = RASF.Main.Classes.MakeMenu.SaveNode(this.treMenu);
                LastRow.RowState = General.Enums.RowState.Updated;
            }
            this.userAccesMenuList1.Update();
        }
    }
}
