using RASF.Main.Forms.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class EditPiecesName : RASF.General.Forms.Base.DockContentForm
    {
        protected RASF.General.Data.Parts_Master Parts_Master;
        private Byte[] Pic_Array;
        private Byte[] Pic_Array2;
        public EditPiecesName(Guid contractid)
        {
            InitializeComponent();
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsBaseCode", contractid));
            this.partsMasterList1.Fill(Parameter);

       }

        private void EditPiecesName_Load(object sender, EventArgs e)
        {
            this.grdPartsMaster.Refetch();

            this.yes_NoList1.Fill();
            this.yes_NoForDestructList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Destruct"], this.yes_NoForDestructList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["FeBase"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["Void"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["IsLarge"], this.yes_NoList1, "Code", "YesNo");
            General.Classes.Utility.Create_DropDown(this.grdPartsMaster.RootTable.Columns["TestLocation"], this.yes_NoList1, "Code", "YesNo");

            this.grdPartsMaster.RootTable.Columns["Destruct"].DefaultValue = this.yes_NoList1[1].Code;
            this.grdPartsMaster.RootTable.Columns["FeBase"].DefaultValue = this.yes_NoList1[1].Code;
            this.grdPartsMaster.RootTable.Columns["IsLarge"].DefaultValue = this.yes_NoList1[0].Code;
            this.grdPartsMaster.RootTable.Columns["TestLocation"].DefaultValue = this.yes_NoList1[0].Code;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.partsMasterList1.Update();

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@ContractsCode", this.partsMasterList1.list[0].ContractsBaseCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@EditUser", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.Base.BaseList<Object>.FillScalar("EditedContractBase_Update", Parameter);

            this.Close();

            if (chkPrint.Checked == true)
            {

                if (this.partsMasterList1.list[0].Executers == new Guid("0E413A74-4D22-43F8-949D-6EACFDB9EEA2") || this.partsMasterList1.list[0].Executers == new Guid("14C97ABF-4D63-4B1E-9906-9D8EA588EF7C") || this.partsMasterList1.list[0].Executers == new Guid("92BC9808-464B-484E-A48E-27E96E1B5B47"))
                {
                    report.Load(String.Format("{0}\\Report\\SpecialExecuters.mrt", Application.StartupPath));
                    report["@Code"] = this.partsMasterList1.list[0].ContractsBaseCode;
                    report.Show();

                }
                else
                {
                    report.Load(String.Format("{0}\\Report\\Report1.mrt", Application.StartupPath));
                    report["@Code"] = this.partsMasterList1.list[0].ContractsBaseCode;
                    report.Show();
                }
            }
           
          
        }

        private void grdPartsMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
                Parts_Master = (RASF.General.Data.Parts_Master)this.grdPartsMaster.SelectedItems[0].GetRow().DataRow;
           switch (e.Column.Key)
            {
                case "SmallPicture":
                    if (dlgSelectPic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Parts_Master != null)
                        {
                            Parts_Master.Picture = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                            Parts_Master.SmallPicture = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 48);
                            if (Parts_Master.RowState != General.Enums.RowState.Added)
                            {
                                Parts_Master.RowState = General.Enums.RowState.Updated;
                            }
                        }
                        else
                        {
                            this.Pic_Array = RASF.General.Classes.Utility.ReadPic(dlgSelectPic.FileName, 480);
                        }
                    }
                    break;
                case "SmallPicture2":
                    if (dlgSelectPic2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (Parts_Master != null)
                        {
                            Parts_Master.Picture2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 480);
                            Parts_Master.SmallPicture2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 48);
                            if (Parts_Master.RowState != General.Enums.RowState.Added)
                            {
                                Parts_Master.RowState = General.Enums.RowState.Updated;
                            }
                        }
                        else
                        {
                            this.Pic_Array2 = RASF.General.Classes.Utility.ReadPic(dlgSelectPic2.FileName, 480);
                        }
                    }
                    break;
            }
        }

        private void grdPartsMaster_RecordAdded(object sender, EventArgs e)
        {

        }
    }
}
