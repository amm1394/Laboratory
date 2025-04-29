using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SpecialCustomerReport : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public SpecialCustomerReport()
        {
            InitializeComponent();
            this.companiesBaseList1.spName = "Companies_Base_SpecialCustomer";
        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void grdIsHold_SelectionChanged(object sender, EventArgs e)
        {
            //if ((this.grdBills.CurrentRow != null) && (this.grdBills.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            //{
            //    this.grpGrid.Text = "قرارداد" + " " + this.grdBills.CurrentRow.Cells["ContractNo"].Value.ToString();
            //}
            //else
            //{
            //    this.grpGrid.Text = "";
            //}
           
        }

        private void FillGrid()
        {
          

            this.companiesBaseList1.Fill();
            this.grdcompanies.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           this.companiesBaseList1.Update();
            FillGrid();
        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
               
            FillGrid();
        }


    }
}
