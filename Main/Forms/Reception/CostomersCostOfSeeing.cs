using SendSMS;
using Stimulsoft.Report.Dictionary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RASF.Main.Forms.Financial
{
    public partial class CostomersCostOfSeeing : RASF.General.Forms.Base.DockContentForm
    {
        public CostomersCostOfSeeing()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
        }

        private void CostomersCost_Load(object sender, EventArgs e)
        {
            this.costomersCostGridList1.Fill();

            this.grdCostomerCost.Refetch();

            this.chkParts.Checked = true;
        }

        private void grdCostomerCost_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            ContractInfoList ContractInfo = new ContractInfoList();
            ContractInfo.Fill(RASF.General.Classes.Global.FinancialYear, (int)this.grdCostomerCost.CurrentRow.Cells["ContractNo"].Value);

            PartsInfoList PartsInfo = new PartsInfoList();
            PartsInfo.Fill(RASF.General.Classes.Global.FinancialYear, (int)this.grdCostomerCost.CurrentRow.Cells["ContractNo"].Value);

            TestInfoList TestInfo = new TestInfoList();
            TestInfo.Fill(RASF.General.Classes.Global.FinancialYear, (int)this.grdCostomerCost.CurrentRow.Cells["ContractNo"].Value);

            SendSMS.Classes.EmailOfCostDetail EmailOfCostDetail = new SendSMS.Classes.EmailOfCostDetail();
            EmailOfCostDetail.ContractNo = (int)this.grdCostomerCost.CurrentRow.Cells["ContractNo"].Value;
            EmailOfCostDetail.FinancialYear = RASF.General.Classes.Global.FinancialYear;
            SendSMS.Classes.MakeCostDetailHtml MakeCostDetailHtml = new SendSMS.Classes.MakeCostDetailHtml();
            MakeCostDetailHtml.MakeHtml(ContractInfo, PartsInfo, TestInfo);

            //byte[] buffer = File.ReadAllBytes(MakeCostDetailHtml.MakeHtml(ContractInfo, PartsInfo, TestInfo));
            //XmlDocument doc = new XmlDocument();
            //using (MemoryStream output = new MemoryStream())
            //{
            //    using (MemoryStream ms = new MemoryStream(buffer))
            //    {
            //        //doc.Load(ms);
            //        Main.Forms.Reports.ViewReport ViewReport = new Main.Forms.Reports.ViewReport(ms, false);
            //        ViewReport.MdiParent = this.MdiParent;
            //        ViewReport.Show();
            //    }
            //   // doc.Save(output);
           
              
            //}
        }

      
    }
}
