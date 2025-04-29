using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SentPartToContractorsForVoid : RASF.General.Forms.Base.DockContentForm
    {
        private Guid Code = Guid.Empty;
        public SentPartToContractorsForVoid()
        {
            InitializeComponent();
            this.ShowpnlButton = false; 
        }

        private void SentPartToContractorsForVoid_Load(object sender, EventArgs e)
        {
            this.sentPartToContractorsForVoidList1.Fill();
            this.grdVoid.Refetch();
        }

        private void grdVoid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdVoid.SelectedItems.Count > 0)
            {
                RASF.General.Data.SentPartToContractors Current_Contract = (RASF.General.Data.SentPartToContractors)this.grdVoid.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {

                    ((RASF.General.Data.SentPartToContractors)this.grdVoid.SelectedItems[0].GetRow().DataRow).RowState = General.Enums.RowState.Updated;
                    this.sentPartToContractorsForVoidList1.Update();
                }
            }

            this.sentPartToContractorsForVoidList1.Fill();
            this.grdVoid.Refetch();
            MessageBox.Show("باطل شد");
        }

    }
}
