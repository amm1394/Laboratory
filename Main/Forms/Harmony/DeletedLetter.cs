using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Harmony
{
    public partial class DeletedLetter : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
        public DeletedLetter()
        {
            InitializeComponent();
        }

        private void DeletedLetter_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            this.hasContracsLetterList1.Fill();
            this.grdLetter.Refetch();

            this.hasSaveCostPaperList1.Fill();
            this.grdCostpaper.Refetch();

            this.hasSaveEditedReportList1.Fill();
            this.grdEditReport.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("@FinancialYear",RASF.General.Classes.Global.FinancialYear));
            this.deleteParts_Picture2List1.Fill(Parameter);
            this.grdPartPic2.Refetch();
        }

        private void grdEditReport_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if(grdEditReport.SelectedItems.Count>0)
            {
                this.grpEditReport.Text = this.grdEditReport.CurrentRow.Cells["ContractNo"].Value.ToString();
                RASF.General.Data.HasContracsLetter EditRepor = (RASF.General.Data.HasContracsLetter)this.grdEditReport.SelectedItems[0].GetRow().DataRow;
                EditRepor.RowState = RASF.General.Enums.RowState.Updated;
                EditRepor.Username = RASF.General.Classes.Global.CurrentUserName;
                this.hasSaveEditedReportList1.Update();

           }
            FillGrid();
        }

        private void grdCostpaper_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (grdCostpaper.SelectedItems.Count > 0)
            {
                this.grpcostpaper.Text = this.grdCostpaper.CurrentRow.Cells["ContractNo"].Value.ToString();
                RASF.General.Data.HasContracsLetter Costpaper = (RASF.General.Data.HasContracsLetter)this.grdCostpaper.SelectedItems[0].GetRow().DataRow ;
                Costpaper.RowState = RASF.General.Enums.RowState.Updated;
                Costpaper.Username = RASF.General.Classes.Global.CurrentUserName;
                this.hasSaveCostPaperList1.Update();

            }
            FillGrid();
        }

        private void grdLetter_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (grdLetter.SelectedItems.Count > 0)
            {
                this.grpLetter.Text = this.grdLetter.CurrentRow.Cells["ContractNo"].Value.ToString();
                RASF.General.Data.HasContracsLetter Letter =  (RASF.General.Data.HasContracsLetter)this.grdLetter.SelectedItems[0].GetRow().DataRow;
                Letter.RowState = RASF.General.Enums.RowState.Updated;
                Letter.Username = RASF.General.Classes.Global.CurrentUserName;
                this.hasContracsLetterList1.Update();

            }
            FillGrid();
        }

        private void grdPartPic2_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (grdPartPic2.SelectedItems.Count > 0)
            {
                this.groupBox1.Text = this.grdLetter.CurrentRow.Cells["ContractNo"].Value.ToString();
                RASF.General.Data.Parts_Master PartPic2 = (RASF.General.Data.Parts_Master)this.grdPartPic2.SelectedItems[0].GetRow().DataRow;
                PartPic2.RowState = RASF.General.Enums.RowState.Updated;
                PartPic2.Username = RASF.General.Classes.Global.CurrentUserName;
                this.deleteParts_Picture2List1.Update();

            }
            FillGrid();
        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.deleteAttachmentOfReportsList1.Fill(Parameter);

            this.grdAttachments.Refetch();
        }

        private void grdAttachments_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (grdAttachments.SelectedItems.Count > 0)
            {
                RASF.General.Data.HasContracsLetter Attach = (RASF.General.Data.HasContracsLetter)this.grdAttachments.SelectedItems[0].GetRow().DataRow;
                Attach.RowState = RASF.General.Enums.RowState.Updated;
                Attach.Username = RASF.General.Classes.Global.CurrentUserName;
                this.deleteAttachmentOfReportsList1.Update();

            }

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
            this.deleteAttachmentOfReportsList1.Fill(Parameter);
            this.grdAttachments.Refetch();
        }

     
    }
}
