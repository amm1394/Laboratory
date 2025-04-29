using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Complaint
{
    public partial class SabtComplaintForm : RASF.General.Forms.Base.DockContentForm
    {
        public SabtComplaintForm()
        {
            InitializeComponent();
        }

        private void splitContainer12_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SabtComplaintForm_Load(object sender, EventArgs e)
        {
            this.complaintTypeList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdCompany.RootTable.Columns["ComplaintTypeCode"], this.complaintTypeList1, "TypeComplaintCode", "Type");
            this.grdCompany.RootTable.Columns["ComplaintTypeCode"].DefaultValue = this.complaintTypeList1[0].TypeComplaintCode;

            FillGrid();
        }

        private void FillGrid()
        {
            this.sabtComplaintList1.Fill();
            this.grdCompany.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdCompany.SelectedItems.Count > 0)
            {
                RASF.General.Data.Complaint Current_Row = (RASF.General.Data.Complaint)this.grdCompany.SelectedItems[0].GetRow().DataRow;
                if ((Current_Row != null) && (String.IsNullOrWhiteSpace(Current_Row.Description) == false))
                {
                    Current_Row.RowState = General.Enums.RowState.Added;
                    Current_Row.RecieptUser = RASF.General.Classes.Global.CurrentUserName;
                    if (this.letter_Scan1.Document != null)
                    {
                        Current_Row.Letter = this.letter_Scan1.Document;
                    }
                    this.sabtComplaintList1.Update();
                    FillGrid();
                    this.checkBox1.Checked = false;
                    this.checkBox2.Checked = false;
                    this.checkBox3.Checked = false;
                    this.checkBox4.Checked = false;
                    this.checkBox5.Checked = false;
                    this.checkBox6.Checked = false;
                    this.checkBox7.Checked = false;
                    this.checkBox8.Checked = false;
                    this.checkBox9.Checked = false;
                    this.checkBox10.Checked = false;
                    this.checkBox11.Checked = false;
                    this.checkBox12.Checked = false;
                    this.checkBox13.Checked = false;
                    this.checkBox14.Checked = false;
                    this.checkBox15.Checked = false;
                    this.checkBox16.Checked = false;
                    this.checkBox17.Checked = false;
                    this.checkBox18.Checked = false;
                    this.checkBox19.Checked = false;
                    this.checkBox20.Checked = false;
                    this.checkBox21.Checked = false;
                    this.textBox1.Text = string.Empty;
                    this.letter_Scan1.Document = null;

                }
            }

            
        }

        private void SabtComplaintForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.letter_Scan1.Dispose();

        }

        private void grdCompany_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.Complaint CurrentCompany = (RASF.General.Data.Complaint)this.grdCompany.CurrentRow.DataRow;
            this.sabtComplaintList1.list[0].CompaniesCode = CurrentCompany.CompaniesCode;
            this.grpcompany.Text = "نام شرکت :" + CurrentCompany.CompanyName;
        }
    }
}
