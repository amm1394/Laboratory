using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Store
{
    public partial class DontWaste : RASF.General.Forms.Base.DockContentForm
    {
        public DontWaste()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void DontWaste_Load(object sender, EventArgs e)
        {
            this.wastePartsList1.Fill();
            this.grid1.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.wastePartsList1.Fill();
            this.grid1.Refetch();
        }

        private void grid1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grid1.SelectedItems.Count > 0)
            {
                RASF.General.Data.DeliveryDay Current_Contract = (RASF.General.Data.DeliveryDay)this.grid1.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null))
                {
                    Current_Contract.RowState = General.Enums.RowState.Added;
                    Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
                    this.wastePartsList1.Update();
                }
            }
            this.wastePartsList1.Fill();
            this.grid1.Refetch();
        }
    }
}
