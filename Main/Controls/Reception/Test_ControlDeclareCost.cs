using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RASF.Main.Controls.Reception
{
    public partial class Test_ControlDeclareCost : UserControl
    {
        public event RASF.General.Events.ReturnTest ReturnTest;

        public String TestName { get { return this.chkTestName.Text; } set { this.chkTestName.Text = value; } }
        public String labBonyadRazi { get { return this.labBonyad.Text; } set { this.labBonyad.Text = value; } }


        public Guid MainCode { get; set; }
        public RASF.General.Lists.MasterTestStatusDeclareCostList MASTERTESTSTATUSList
        {
            set
            {
                this.masterTestStatusDeclareCostList1 = value;
                this.grdMaster.DataSource = this.masterTestStatusDeclareCostList1;
                this.grdMaster.Refetch();
            }
        }

        public Test_ControlDeclareCost()
        {
            InitializeComponent();
        }

        private void chkTestName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTestName.Checked == false)
            {
                foreach (RASF.General.Data.MasterTestStatus MasterTestStatus in this.masterTestStatusDeclareCostList1.list)
                {
                    if (MasterTestStatus.IsCheck == true)
                    {
                        MasterTestStatus.IsCheck = false;
                        ReturnTests(MasterTestStatus);
                    }
                }
            }
      //      pnlGrid.Enabled = chkTestName.Checked;
        }

        private void nbCount_ValueChanged(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.MasterTestStatus MasterTestStatus in this.masterTestStatusDeclareCostList1.list)
            {
                if (MasterTestStatus.IsCheck == true)
                {
                   // MasterTestStatus.NumberOfTests = Convert.ToInt16(this.nbCount.Value);
                    ReturnTests(MasterTestStatus);
                }
            }
        }

        private void grdMaster_UpdatingCell(object sender, Janus.Windows.GridEX.UpdatingCellEventArgs e)
        {
            if (e.Column.Key == "IsCheck")
            {
                Boolean State = Convert.ToBoolean(e.Value);
                if (State == true)
                {
                    if (this.chkTestName.Checked == false)
                    {
                        this.chkTestName.Checked = true;
                    }
                    ((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow).RowState = General.Enums.RowState.Added;
                }
                ((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow).IsCheck = Convert.ToBoolean(e.Value);
            }
            else
            {
                if (((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow).RowState != General.Enums.RowState.Added)
                {
                    ((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow).RowState = General.Enums.RowState.Updated;
                }
                ((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow).NumberOfTests = Convert.ToInt32(e.Value);
            }
            ReturnTests(((RASF.General.Data.MasterTestStatus)this.grdMaster.CurrentRow.DataRow));
        }

        private void ReturnTests(RASF.General.Data.MasterTestStatus Row)
        {
            RASF.General.Data.MasterTestStatus NewRow = new General.Data.MasterTestStatus();
            NewRow.DetailName = Row.DetailName;
            NewRow.InvoicePrice = Row.InvoicePrice;
            NewRow.IsCheck = Row.IsCheck;
            NewRow.LabInCome = Row.LabInCome;
            NewRow.MainTestCode = Row.MainTestCode;
            NewRow.MasterName = Row.MasterName;
            NewRow.MasterTestCode = Row.MasterTestCode;
            NewRow.NumberOfTests = Row.NumberOfTests;
            NewRow.PartsMasterCode = Row.PartsMasterCode;
            NewRow.PartsTestMasterCode = Row.PartsTestMasterCode;
            NewRow.PartsTestsDetailCode = Row.PartsTestsDetailCode;
            NewRow.Tax = Row.Tax;
            NewRow.UserIdUpdate = RASF.General.Classes.Global.CurrentUserCode;//update
            NewRow.RowState = Row.RowState;
            if(this.ReturnTest != null)
            {
                this.ReturnTest(new General.Events.ReturnTestEventArgs(NewRow));
            }
        }

        public void Reset()
        {
            string MasterTestCode ="fe5b3b6e-1eab-41e9-9ed9-416c34fbfcfb";
            foreach (General.Data.MasterTestStatus Test in this.masterTestStatusDeclareCostList1.list)
            {
                Test.IsCheck = false;
                Test.RowState = General.Enums.RowState.Original;


                if (Convert.ToString(Test.MasterTestCode) != MasterTestCode)
                {
                    Test.NumberOfTests = 1;               
                }
                else { Test.NumberOfTests = 60; }
            }
            this.grdMaster.Refetch();
            chkTestName.Checked = false;
           
        }

        public void Set(List<General.Data.MasterTestStatus> list)
        {
            if (list.Count > 0)
            {
                chkTestName.Checked = true;
                foreach (General.Data.MasterTestStatus Test in list)
                {
                    RASF.General.Data.MasterTestStatus test = this.masterTestStatusDeclareCostList1.Where(row => row.MasterTestCode == Test.MasterTestCode).FirstOrDefault();
                    test.IsCheck = true;
                    test.NumberOfTests = Test.NumberOfTests;
                    //if ((Test.MainTestCode).ToString() == "18B12AEE-BAEA-4C30-B9D2-0A2CE0980247")
                    //{
                    //    test.NumberOfTests = 60;
                    //}
                    //else
                    //{
                    //    test.NumberOfTests = Test.NumberOfTests;
                    //}
                }
               
                this.grdMaster.Refetch();
            }
        }
    }
}

