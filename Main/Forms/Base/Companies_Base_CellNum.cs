using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Base
{
    public partial class Companies_Base_CellNum : RASF.General.Forms.Base.DockContentForm
    {
        private Guid CoId;
        public Companies_Base_CellNum()
        {
            InitializeComponent();
            this.companies_MobileNumList1.spName = "Companies_MobileNum_Telegram";
            this.companies_MobileNumList2.spName = "Companies_MobileNum_Whatsapp";
            this.companies_MobileNumList3.spName = "Companies_MobileNum_Password";
            this.companies_MobileNumList4.spName = "ReportOfTelNo";

        }

        private void Companies_Base_CellNum_Load(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.companies_MobileNumList1.Fill();
            this.companies_MobileNumList2.Fill();
            this.companies_MobileNumList3.Fill();
            this.companies_MobileNumList4.Fill();

            this.grdCompanyBase.Refetch();
            this.grdTelegram.Refetch();
            this.grdWhatsapp.Refetch();
            this.grdPassword.Refetch();
            this.grdReport.Refetch();

            this.grdCompanyBase.RemoveBindingContextChanged();

            this.grdCompanyBase.SelectionChanged += new System.EventHandler(this.grdCompanyBase_SelectionChanged);
            this.grdCompanyBase_SelectionChanged(sender, e);
        }

        private void grdCompanyBase_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdCompanyBase.SelectedItems[0].Position > -1)
            {
                CoId = ((RASF.General.Data.Companies_Base)grdCompanyBase.CurrentRow.DataRow).CompaniesCode;

            }

            this.grdTelegram.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdTelegram.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdTelegram.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdWhatsapp.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdWhatsapp.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdWhatsapp.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));

            this.grdPassword.RootTable.Columns["CompanyCode"].DefaultValue = CoId;
            this.grdPassword.RootTable.ApplyFilter(new Janus.Windows.GridEX.GridEXFilterCondition(this.grdPassword.RootTable.Columns["CompanyCode"], Janus.Windows.GridEX.ConditionOperator.Equal, CoId));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdCompanyBase.SelectedItems.Count > 0)
            {
                this.companies_MobileNumList1.Update();
                this.companies_MobileNumList2.Update();
                this.companies_MobileNumList3.Update();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.companies_MobileNumList1.Fill();
            this.companies_MobileNumList2.Fill();
            this.companies_MobileNumList3.Fill();
            this.companies_MobileNumList4.Fill();

            this.grdCompanyBase.Refetch();
            this.grdTelegram.Refetch();
            this.grdWhatsapp.Refetch();
            this.grdPassword.Refetch();
            this.grdReport.Refetch();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.grdReport.ExportToExcel("");
        }
    }
}
