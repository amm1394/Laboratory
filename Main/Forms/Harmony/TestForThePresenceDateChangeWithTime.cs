using FarsiLibrary.Win.Controls;
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
    public partial class TestForThePresenceDateChangeWithTime : RASF.General.Forms.Base.DockContentForm
    {
        private FarsiLibrary.Win.Controls.FADatePicker FADatePicker = new FarsiLibrary.Win.Controls.FADatePicker();

        public TestForThePresenceDateChangeWithTime()
        {
            InitializeComponent();

        }

        private void IsHoldForm_Load(object sender, EventArgs e)
        {
            //DatePickertxtTest.IsNull = true;
            //FillGrid();
            FADatePicker.SelectedDateTime = DateTime.Now;
        }     

        private void FillGrid()
        {
            //List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
            //this.testForThePresenceDateChangeList1.Fill(Parameter);
            //this.grdTest.Refetch();
           
        }
     
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (this.grdTest.SelectedItems.Count > 0)
            //{
            //    RASF.General.Data.DeliveryDateChange Current_Contract = (RASF.General.Data.DeliveryDateChange)this.grdTest.SelectedItems[0].GetRow().DataRow;

            //    if ((Current_Contract != null))
            //    {
            //        Current_Contract.RowState = General.Enums.RowState.Updated;
            //        Current_Contract.UserName = RASF.General.Classes.Global.CurrentUserName;
            //        Current_Contract.UserID = RASF.General.Classes.Global.CurrentUserCode;
            //        this.testForThePresenceDateChangeList1.Update();

            //        FillGrid();

                  
            //    }
            //}
        
        }

        private void grdDelivery_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdTest.CurrentRow != null) && (this.grdTest.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpGrid.Text = "قرارداد" + " " + this.grdTest.CurrentRow.Cells["ContractNo"].Value.ToString();
            }
            else
            {
                this.grpGrid.Text = "";
            }

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.registerMarkingList1.Fill(Parameter);
            this.grdTest.Refetch();

        }

        private void grdTest_EndCustomEdit(object sender, Janus.Windows.GridEX.EndCustomEditEventArgs e)
        {
            e.DataChanged = true;
            FarsiLibrary.Utils.PersianDate temp = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(FADatePicker.SelectedDateTime);
            e.Value = temp.ToString("yyyy/MM/dd");
        }

        private void grdTest_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
        {
            if ((RASF.General.Data.RegisterMarking)e.Row.DataRow == null)
            {
                FADatePicker.SelectedDateTime = DateTime.Now;
            }
            else
            {
                if (((RASF.General.Data.RegisterMarking)e.Row.DataRow).DateofTest > DateTime.MinValue)
                {
                    FADatePicker.SelectedDateTime = ((RASF.General.Data.RegisterMarking)e.Row.DataRow).DateofTest;
                }
            }
            e.EditControl = FADatePicker;
        }
                   
    }
}
