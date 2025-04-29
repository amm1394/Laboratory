using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Laboratory
{
    public partial class ViewCostPaperLaboratory : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
        private Janus.Windows.GridEX.GridEXFormatStyle NewCustomerFormat;
        public ViewCostPaperLaboratory()
        {
            InitializeComponent();
        //    this.ShowpnlSave = false;
            this.grdMaterList.GroupByBoxVisible = true;
            this.companiesCostPaperList1.spName = "CompaniesCostPaperLaboratory";
      //      this.showSaveCostPaperList1.spName = "ShowSavedAttachmentFile";

            this.NewCustomerFormat = new Janus.Windows.GridEX.GridEXFormatStyle();
            this.NewCustomerFormat.BackColor = Color.Plum;
            this.NewCustomerFormat.ForeColor = Color.Black;
        }

        public ViewCostPaperLaboratory(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContractcsForAll1.ContractNo = ContractNo;
            this.searchContractcsForAll1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
      
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
          
        }

        private void ViewCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
            this.letter_Scan2.Dispose();
            this.letter_Scan3.Dispose();
            this.letter_Scan4.Dispose();
            this.letter_Scan5.Dispose();
            this.letter_Scan6.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.letter_Scan2.Document != null)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", this.ContractsCode));
                Parameter.Add(new System.Data.SqlClient.SqlParameter("Letter", this.letter_Scan2.Document));
                RASF.General.Lists.Base.BaseList<Object>.FillScalar("Contracts_Leter_Update", Parameter);
            }

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            DateTime t1 = DateTime.Now;
            this.companiesCostPaperList1.Fill(Parameter);
            DateTime t2 = DateTime.Now;

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.part_PicList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter4 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter4.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.part_Pic2Lis1.Fill(Parameter4);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.masterTestListCostPaperList1.Fill(Parameter2);

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.sendMessageList1.Fill(Parameter3);

            //List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            //this.showWorkFlowDescriptionList1.Fill(Parameter6);
            //this.grdWorkFlow.Refetch();

            //List<System.Data.SqlClient.SqlParameter> Parameter7 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter7.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            //this.showSaveCostPaperList1.Fill(Parameter7);
            //if (this.showSaveCostPaperList1.list.Count > 0)
            //{
            //    this.letter_Scan6.Document = this.showSaveCostPaperList1.list[0].CostPaper;
            //}

            this.letter_Scan2.Document = this.companiesCostPaperList1[0].Letter;
            this.letter_Scan3.Document = this.companiesCostPaperList1[0].CostPaper;
            this.letter_Scan4.Document = this.companiesCostPaperList1[0].EditedReport;
            this.letter_Scan6.Document = this.companiesCostPaperList1[0].Attachment;
            this.letter_Scan1.Genrate_PartPic_Pdf(this.part_PicList1);
            this.letter_Scan5.Genrate_PartPic2_Pdf(this.part_Pic2Lis1);
            this.grdCompanisInvoice.Refetch();
            this.grdMaterList.Refetch();
            this.grdMessage.Refetch();
            

            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
        }

        private void ViewCostPaper_Load(object sender, EventArgs e)
        {
           // this.letter_Scan3.Intial_Watcher();
        }

        private void grdMaterList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.MasterTestListCostPaper CurrentRow = (RASF.General.Data.MasterTestListCostPaper)this.grdMaterList.CurrentRow.DataRow;
            RASF.Main.Forms.WorkFlow.showWorkFlowDescription showWorkFlowDescription = new RASF.Main.Forms.WorkFlow.showWorkFlowDescription(CurrentRow.PartsTestMasterCode);
            showWorkFlowDescription.Show();
        }

        private void grdMaterList_SelectionChanged(object sender, EventArgs e)
        {
            //ارور وقتی گروه بندی براساس آزمایشگاه انجام می شود
            //List<System.Data.SqlClient.SqlParameter> Parameter5 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter5.Add(new System.Data.SqlClient.SqlParameter("PartTestMasterCode", ((RASF.General.Data.MasterTestListCostPaper)this.grdMaterList.CurrentRow.DataRow).PartsTestMasterCode));
            //this.showWorkFlowDescriptionList1.Fill(Parameter5);
            //this.grdDesc.Refetch();
        }

        private void grdCompanisInvoice_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
            if (Convert.ToInt16(e.Row.Cells["Morajeat"].Value) <= 10 && Convert.ToInt16(e.Row.Cells["Morajeat"].Value) > 0)
            {
                e.Row.Cells["CompanyName_Invoice"].FormatStyle = this.NewCustomerFormat;
            }
        }

      
    }
}
