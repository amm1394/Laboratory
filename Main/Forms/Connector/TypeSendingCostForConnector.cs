using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.Connector
{
    public partial class TypeSendingCostForConnector : RASF.General.Forms.Base.DockContentForm
    {
        private DateTime from;
        private DateTime to;
        public TypeSendingCostForConnector()
        {
            InitializeComponent();
            this.reportSendingEmailList1.spName = "ReportSendingEmailForConnector";
            FillGrid(new General.Events.ReturnSelectedDatesEventArgs(DateTime.Now, DateTime.Now));

        }

        private void pickDate1_DateSelected(General.Events.ReturnSelectedDatesEventArgs e)
        {
            FillGrid(e);
        }

        private void FillGrid(General.Events.ReturnSelectedDatesEventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", e.From));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", e.To));
            this.reportSendingEmailList1.Fill(Parameter);
            this.grdcost.Refetch();

            from = e.From;
            to = e.To;
        }

        private void TypeSendingCost_Load(object sender, EventArgs e)
        {
            this.typesOfCostStatementsList1.Fill();

            General.Classes.Utility.Create_DropDown(this.grdcost.RootTable.Columns["SendingTypeCode"], this.typesOfCostStatementsList1, "Code", "TypeOfCost");
            this.grdcost.RootTable.Columns["SendingTypeCode"].DefaultValue = this.typesOfCostStatementsList1[2].Code;
        }

        private void grdcost_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", to));
            this.reportSendingEmailList1.Fill(Parameter);
            this.grdcost.Refetch();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (RASF.General.Data.ReportSendingInPerson rowUser in reportSendingEmailList1)
            {
                rowUser.UserId = RASF.General.Classes.Global.CurrentUserCode;
            }

            foreach (RASF.General.Data.ReportSendingInPerson rowUser in reportSendingEmailList1.Where(row => row.EmailAddFaxNo != null && row.SendingTypeCode != 0))
            {
                this.reportSendingEmailList1.Update();
            }
            List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
            Parameter.Add(new System.Data.SqlClient.SqlParameter("From", from));
            Parameter.Add(new System.Data.SqlClient.SqlParameter("To", to));
            this.reportSendingEmailList1.Fill(Parameter);
            this.grdcost.Refetch();

        }
    }
}
