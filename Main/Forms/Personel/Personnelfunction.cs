using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Personel
{
    public partial class Personnelfunction : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime From;
        private DateTime To;

        public Personnelfunction()
        {
            this.InitializeComponent();
            this.To = this.From = DateTime.Now;
            this.outPutExecutersDetailList1.spName = "Personnelfunction";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grdPersonel.ExportToExcel("کارکرد پرسنل کل");
            this.grdDetailOutput.ExportToExcel("کارکرد پرسنل جزئیات");
        }

        //private void pickDate1_DateSelected(ReturnSelectedDatesEventArgs e)
        //{
        //    this.From = e.From;
        //    this.To = e.To;
        //    //  this.fill();
        //}


        private void Personnelfunction_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void laboratoryName1_SelectedValueChanged(object sender, EventArgs e)
        {
          // this.fill();
        }

   

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            Parameters.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", laboratoryName1.LabCode));
            this.outPutExecutersDetailList1.Fill(Parameters);
            this.grdPersonel.Refetch();
            this.From = e.From;
            this.To = e.To;
        }

        private void grdPersonel_SelectionChanged(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", this.From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", this.To));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("LaboratoryCode", laboratoryName1.LabCode));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("UserId", this.grdPersonel.CurrentRow.Cells["UserId"].Value.ToString()));
            this.outPutExecutersDetailFormanagerList1.Fill(Parameters1);
            this.grdDetailOutput.Refetch();
        }
    }
}
