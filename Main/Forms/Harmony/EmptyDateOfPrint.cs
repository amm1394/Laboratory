using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class EmptyDateOfPrint : RASF.General.Forms.Base.DockContentForm
    {

        public EmptyDateOfPrint()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

       

        private void grdMaster_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

            RASF.General.Data.PartsMasterEmptyPrintReport Current_Contract = (RASF.General.Data.PartsMasterEmptyPrintReport)this.grdMaster.SelectedItems[0].GetRow().DataRow;

                if ((Current_Contract != null))
                {
                    Current_Contract.RowState = General.Enums.RowState.Updated;
                    this.partsMasterEmptyPrintReportList1.Update();
              

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                this.partsMasterEmptyPrintReportList1.Fill(Parameter1);
                this.grdMaster.Refetch();
                    
                        

                 }
    }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            //this.partsMasterEmptyPrintReportList1.spName = "ContractsEmptyPrintReport";
            if (String.IsNullOrWhiteSpace(this.txtSearch.Text) == false)
            {
                try
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtSearch.Text));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.findContractNoList1.Fill(Parameter);

                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.contractsEmptyPrintReportList1.Fill(Parameter1);
                    this.grdContracts.Refetch();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("اطلاعات وارد شده صحیح نمی یاشد");
                }

            }
        }

        private void grdContracts_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
           // this.partsMasterEmptyPrintReportList1.spName = "ContractsEmptyPrintReport";
            RASF.General.Data.PartsMasterEmptyPrintReport Current_Contract = (RASF.General.Data.PartsMasterEmptyPrintReport)this.grdContracts.SelectedItems[0].GetRow().DataRow;

            if ((Current_Contract != null))
            {
                Current_Contract.RowState = General.Enums.RowState.Updated;
                this.contractsEmptyPrintReportList1.Update();


                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                this.contractsEmptyPrintReportList1.Fill(Parameter1);
                this.grdContracts.Refetch();



            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(this.txtFind.Text) == false)
            {
                try
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractNo", this.txtFind.Text));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    this.findContractNoList1.Fill(Parameter);

                    List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", findContractNoList1[0].ContractsCode));
                    this.partsMasterEmptyPrintReportList1.Fill(Parameter1);
                    this.grdMaster.Refetch();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("اطلاعات وارد شده صحیح نمی یاشد");
                }

            }
        }

    }

}
