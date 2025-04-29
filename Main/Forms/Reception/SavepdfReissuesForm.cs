using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Export;
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
    public partial class SavepdfReissuesForm : RASF.General.Forms.Base.DockContentForm
    {
        private Guid ContractsCode = Guid.Empty;
        private Boolean InformalFactor;
        public SavepdfReissuesForm()
        {
            InitializeComponent();
            this.pnlButton.Visible = true;
            this.contractsReissuesList1.spName = "SavepdfContracts_Reissues";
           
            }

        private void ReissuesForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
           
        }

        private void RefreshGrid()
        {

            this.contractsReissuesList1.Fill();
            this.grdContracts.Refetch();
        }

        private void grdContracts_SelectionChanged(object sender, EventArgs e)
        {
            if ((this.grdContracts.CurrentRow != null) && (this.grdContracts.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record))
            {
                this.grpContracts.Text = String.Format("قرارداد {0}", this.grdContracts.CurrentRow.Cells["ContractNo"].Value);
            }
            else
            {
                this.grpContracts.Text = "";
            }


            if (this.grdContracts.SelectedItems.Count > 0)
            {
                RASF.General.Data.Contracts_Base_Edit Current_Contract = (RASF.General.Data.Contracts_Base_Edit)this.grdContracts.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {
                    InformalFactor = Current_Contract.InformalFactor;
                    this.ContractsCode = Current_Contract.ContractsCode;
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Current_Contract.ContractsCode));
                    this.billReissuesList1.Fill(Parameters);

                    this.grdBill.Refetch();
                }
                else
                {
                    this.billReissuesList1.Clear();
                    // this.grdBill.Refetch();
                    this.ContractsCode = Guid.Empty;
                }
            }
            else
            {
                this.billReissuesList1.Clear();
                this.grdBill.Refetch();
                this.ContractsCode = Guid.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          
           // if (ContractsCode != Guid.Empty)
          //  {

                foreach (RASF.General.Data.Contracts_Base_Edit Contracts_Base_Edit in this.contractsReissuesList1)
                {
                    if (Contracts_Base_Edit.IsCompleted == true)
                    {
                        List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                        Parameters.Add(new System.Data.SqlClient.SqlParameter("Code", Contracts_Base_Edit.ContractsCode));
                        this.billReissuesList1.Fill(Parameters);
                        this.grdBill.Refetch();
                        this.billReissuesList1.Update();

                        ////if (this.InformalFactor == false)
                        ////{
                        Report2.Load(String.Format("{0}\\Report\\BillReissues - Copy.mrt", Application.StartupPath));
                        ////}
                        ////else
                        ////{
                        ////    Report2.Load(String.Format("{0}\\Report\\BillReissues-Informal.mrt", Application.StartupPath));
                        ////}
                        ContractsCode = Contracts_Base_Edit.ContractsCode;
                        string FolderPath = @"D:\\Users\\knabavi\\Desktop\\pdf\\";
                        Report2["@Code"] = ContractsCode;
                        Report2["@FinancialYear"] = RASF.General.Classes.Global.FinancialYear;
                        Report2.Render();
                        StiPdfExportSettings pdfSettings = new StiPdfExportSettings();
                        Report2.ExportDocument(StiExportFormat.Pdf, FolderPath + "\\" + Contracts_Base_Edit.BillNo + ".pdf");
                        //   Report2.Save(FolderPath + "\\" + 100 + ".pdf");

                      //  List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                       // Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractYear", RASF.General.Classes.Global.FinancialYear));
                        this.billReissuesList1.Clear();
                        
                    }
                }
            }
       // }


        private void grdBill_CurrentCellChanged(object sender, EventArgs e)
        {
            this.billReissuesList1.UpdateRow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}

