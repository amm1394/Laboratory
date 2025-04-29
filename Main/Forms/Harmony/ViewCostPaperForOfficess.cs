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
    public partial class ViewCostPaperForOfficess : RASF.General.Forms.Base.DockContentForm
    {
        public ViewCostPaperForOfficess()
        {
            InitializeComponent();
            this.companiesCostPaperList1.spName = "CompaniesCostPaperForOffice";
            this.masterTestListCostPaperList1.spName = "MasterTestListCostPaperForOffices";
            this.sendMessageList1.spName = "SendMessageForOffices";
            this.part_PicList1.spName = "Part_PicForOffices";
            this.ShowpnlButton = false;
            this.grdMaterList.GroupByBoxVisible = true;
        }

        public ViewCostPaperForOfficess(Guid ContractsCode, int ContractNo)
            :this()
        {
            this.searchContractcsForAll1.ContractNo = ContractNo;
            this.searchContractcsForAll1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
        }

        private void ViewCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();
            this.letter_Scan2.Dispose();
          //  this.letter_Scan3.Dispose();
        //    this.letter_Scan4.Dispose();
            this.letter_Scan5.Dispose();
         //   this.letter_Scan6.Dispose();
        }

        private void grdMaterList_FormattingRow(object sender, Janus.Windows.GridEX.RowLoadEventArgs e)
        {

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {

            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            //  DateTime t1 = DateTime.Now;
            this.companiesCostPaperList1.Fill(Parameter);
            // DateTime t2 = DateTime.Now;

            List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter1.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.part_PicList1.Fill(Parameter1);

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.masterTestListCostPaperList1.Fill(Parameter2);

            List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            Parameter3.Add(new System.Data.SqlClient.SqlParameter("currentUser", RASF.General.Classes.Global.CurrentUserCode));
            this.sendMessageList1.Fill(Parameter3);

            if (this.companiesCostPaperList1.Count() > 0)
            {
                this.letter_Scan2.Document = this.companiesCostPaperList1[0].Letter;
             //   this.letter_Scan3.Document = this.companiesCostPaperList1[0].CostPaper;
             //   this.letter_Scan4.Document = this.companiesCostPaperList1[0].EditedReport;
             //   this.letter_Scan6.Document = this.companiesCostPaperList1[0].Attachment;
                this.letter_Scan1.Genrate_PartPic_Pdf(this.part_PicList1);
                this.letter_Scan5.Genrate_PartPic2_Pdf(this.part_Pic2Lis1);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("این قرارداد متعلق به دفتر دیگری می باشد");
            }
            this.grdCompanisInvoice.Refetch();
            this.grdMaterList.Refetch();
            this.grdMessage.Refetch();


            this.grdMaterList.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed;
        }
    }
}
