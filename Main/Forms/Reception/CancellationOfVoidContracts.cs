using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class CancellationOfVoidContracts : RASF.General.Forms.Base.DockContentForm
    {
        public CancellationOfVoidContracts()
        {
            InitializeComponent();
        }

        private void CancellationOfVoidContracts_Load(object sender, EventArgs e)
        {
            FillContract();
        }

        private void grdVoidContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (this.grdVoidContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.ShowVoidContracts Current_Contract = (RASF.General.Data.ShowVoidContracts)this.grdVoidContracts.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.Description) == false))
                {
                    Current_Contract.RowState = General.Enums.RowState.Updated;
                    this.showVoidContractsList1.Update();

                    FillContract();

                
                }
            }
        }
        private void FillContract()
        {
            this.showVoidContractsList1.Fill();

            this.grdVoidContracts.Refetch();
        }
    }
}
