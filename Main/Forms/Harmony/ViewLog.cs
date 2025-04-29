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
    public partial class ViewLog : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
    
        public ViewLog()
        {
            InitializeComponent();
       
            this.part_PicList1.spName = "Part_Pic_lOG";
            this.showWorkFlowDescriptionList1.spName = "DescForEditContractBase";
            this.showWorkFlowDescriptionList2.spName = "Part_Pic_lOG_Description";
           
        }

        public ViewLog(Guid ContractsCode, int ContractNo)
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
         

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            this.ContractsCode = e.ContractsCode;


            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.part_PicList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.showWorkFlowDescriptionList2.Fill(Parameter3);
            this.gridPic.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            this.showWorkFlowDescriptionList1.Fill(Parameter6);
            this.grdDesc.Refetch();

          
            this.letter_Scan1.Genrate_PartPic_Pdf(this.part_PicList1);
        

            
        }

        private void ViewCostPaper_Load(object sender, EventArgs e)
        {
          
        }

        private void grdMaterList_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {

        }

        private void grdMaterList_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void grdCompanisInvoice_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {
          
        }

        private void tabControl1_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {

        }

      
    }
}
