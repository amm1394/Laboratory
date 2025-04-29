//using FarsiLibrary.Win.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class SentPartToContractorsForBill : RASF.General.Forms.Base.DockContentForm
    {
        private FarsiLibrary.Win.Controls.FADatePicker FADatePicker = new FarsiLibrary.Win.Controls.FADatePicker();

       // private DateTime From, To;
        public SentPartToContractorsForBill()
        {
            InitializeComponent();
            
        }

        private void SentPartToContractorsForVoid_Load(object sender, EventArgs e)
        {
          //  pickDate2_DateSelected(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));
            this.sentPartToContractorsForBillList1.Fill();
            this.grdBill.Refetch();
           
        }


        private void pickDate2_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            RefreshGrid(e);
        }
        private void RefreshGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            this.sentPartToContractorsForBillList1.Fill();
            this.grdBill.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (this.grdBill.SelectedItems.Count > 0)
            //{
            //    RASF.General.Data.SentPartToContractors Current_Contract = (RASF.General.Data.SentPartToContractors)this.grdBill.SelectedItems[0].GetRow().DataRow;

            //    if ((Current_Contract != null) && (String.IsNullOrWhiteSpace(Current_Contract.InvoiceNo) == false))
            //    {
            //        Current_Contract.RowState = General.Enums.RowState.Updated;
                    this.sentPartToContractorsForBillList1.Update();
                    this.sentPartToContractorsForBillList1.Fill();
                    this.grdBill.Refetch();
             //   }
          //  }
          //           
            //this.sentPartToContractorsForBillList1.Fill();
            //this.grdBill.Refetch();
        }

    

    }
}
