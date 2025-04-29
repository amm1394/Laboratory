using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class EnterFormAmadesazi : RASF.General.Forms.Base.DockContentForm
    {
        private FarsiLibrary.Win.Controls.FADatePicker FADatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
        public EnterFormAmadesazi()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlUpdate = true;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            this.testExecutersAmadesaziList1.Fill();
            General.Classes.Utility.Create_DropDown(this.grdContracts.Tables[2].Columns["TestExecutersCodeEnter"], this.testExecutersAmadesaziList1, "UserId", "UserName");
            this.grdContracts.Tables[2].Columns["TestExecutersCodeEnter"].DefaultValue = this.testExecutersAmadesaziList1[1].UserId;

            this.standardsList1.Fill();
            General.Classes.Utility.Create_DropDownWithParameter(this.grdContracts.Tables[2].Columns["Standard"], this.standardsList1, "StandardCode", "StandardsName", this.grdContracts.Tables[2].Columns["MasterTestCode"]);
          //  this.grdContracts.Tables[2].Columns["Standard"].DefaultValue = this.standardsList1[0].MasterTestCode;

            FADatePicker.SelectedDateTime = DateTime.Now;

            FillContracts();
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi> test = new RASF.General.Lists.Base.BaseList<RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi>();
           
            //if (test.list[0].TestExecutersCodeEnter != Guid.Empty )
            //{
                this.contractsNotEnteredAzmoonAmadesaziList1.Update();

                FillContracts();
            //}
            //else
            //{
            //    MessageBox.Show("مسئول تست را وارد نمایید");
            //}

        }

        private void FillContracts()
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("UserId", RASF.General.Classes.Global.CurrentUserCode));
            this.contractsNotEnteredAzmoonAmadesaziList1.Fill(Parameter);
            this.grdContracts.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillContracts();
        }

        private void grdContracts_EndCustomEdit(object sender, Janus.Windows.GridEX.EndCustomEditEventArgs e)
        {
            e.DataChanged = true;
            FarsiLibrary.Utils.PersianDate temp = FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(FADatePicker.SelectedDateTime);
            ((RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi)e.Row.DataRow).DateOfTestString =Convert.ToDateTime(temp);
            e.Value = temp.ToString("yyyy/MM/dd");
        }

        private void grdContracts_InitCustomEdit(object sender, Janus.Windows.GridEX.InitCustomEditEventArgs e)
        {

            if ((RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi)e.Row.DataRow == null)
            {
                FADatePicker.SelectedDateTime = DateTime.Now;
            }
            else
            {
                if (((RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi)e.Row.DataRow).DateOfTest > DateTime.MinValue)
                {
                    FADatePicker.SelectedDateTime = ((RASF.General.Data.TestNameNotEnteredAzmoonAmadesazi)e.Row.DataRow).DateOfTest;
                }
            }
            e.EditControl = FADatePicker;
        }
    }
}
