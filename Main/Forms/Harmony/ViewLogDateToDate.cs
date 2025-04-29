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
    public partial class ViewLogDateToDate : RASF.General.Forms.Base.DockContentForm
    {
        Guid ContractsCode;
    
        public ViewLogDateToDate()
        {
            InitializeComponent();
       
       
            this.showWorkFlowDescriptionList1.spName = "DescForEditContractBaseDatetodate";
            this.showWorkFlowDescriptionList2.spName = "Part_Pic_lOG_DescriptionDateToDate";
           
        }

        public ViewLogDateToDate(Guid ContractsCode, int ContractNo)
            :this()
        {
            //this.searchContractcsForAll1.ContractNo = ContractNo;
            //this.searchContractcsForAll1_ReturnContractsCode(new General.Events.ReturnContractsCodeEventArgs(ContractsCode));
      
        }

        private void searchContract1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
          
        }

        private void ViewCostPaper_FormClosing(object sender, FormClosingEventArgs e)
        {
         

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

        }

        private void searchContractcsForAll1_ReturnContractsCode(General.Events.ReturnContractsCodeEventArgs e)
        {
            //this.ContractsCode = e.ContractsCode;


            //List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter1.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            //this.part_PicList1.Fill(Parameter1);

            //List<System.Data.SqlClient.SqlParameter> Parameter3 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter3.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            //this.showWorkFlowDescriptionList2.Fill(Parameter3);
            //this.gridPic.Refetch();

            //List<System.Data.SqlClient.SqlParameter> Parameter6 = new List<System.Data.SqlClient.SqlParameter>();
            //Parameter6.Add(new System.Data.SqlClient.SqlParameter("ContractsCode", e.ContractsCode));
            //this.showWorkFlowDescriptionList1.Fill(Parameter6);
            //this.grdDesc.Refetch();

        }

       

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.showWorkFlowDescriptionList1.Fill(Parameter);
            this.grdDesc.Refetch();

            List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter2.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.showWorkFlowDescriptionList2.Fill(Parameter2);
            this.gridPic.Refetch();
        }

      
    }
}
