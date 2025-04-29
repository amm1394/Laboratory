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
    public partial class DescriptionForSendTestContractors : RASF.General.Forms.Base.DockContentForm
    {
        public DescriptionForSendTestContractors()
        {
            InitializeComponent();
            this.editContractorsForLabList1.spName = "ViewDescriptionOfConstrators";
        }

       
        private void RequestOfConstractors_Load(object sender, EventArgs e)
        {
            this.notRecieveFromContractorsList1.Fill();
            this.grdrecieve.Refetch();

            this.descriptionForSendTestContractorsList1.Fill();
            this.grdcontractors.Refetch();
                      

          // this.recieveExperimentFromContractorList1.Fill();
            //this.grdrecieve.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.SentPartToContractors SentPartToContractors in this.descriptionForSendTestContractorsList1)
            {
                if (SentPartToContractors.Check == true && SentPartToContractors.DescriptionsHarmony != null)
                {
                    this.descriptionForSendTestContractorsList1.Update();
                }

                if (SentPartToContractors.CheckForEdit == true )
                {
                    this.recieveExperimentFromContractorList1.Update();
                }

            }

            this.notRecieveFromContractorsList1.Update();


            this.descriptionForSendTestContractorsList1.Fill();
            this.grdcontractors.Refetch();

            this.notRecieveFromContractorsList1.Fill();
            this.grdrecieve.Refetch();
        }

        private void grdcontractors_SelectionChanged(object sender, EventArgs e)
        {
            if (grdcontractors.CurrentRow.Cells["code"].Value !=null)
            {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("code", this.grdcontractors.CurrentRow.Cells["code"].Value));
            this.editContractorsForLabList1.Fill(Parameter);
            this.GrdEdit.Refetch();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            grdrecieve.ExportToExcel("");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
