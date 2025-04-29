using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterPrintRecieptPicList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterPrintReport>
    {
        public PartsMasterPrintRecieptPicList()
        {
            this.spName = "PartsMasterPrintRecieptPic";
            this.list = new List<RASF.General.Data.PartsMasterPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterPrintReport>();
        }

        public PartsMasterPrintRecieptPicList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            RASF.General.Data.PartsMasterPrintReport PartsMasterPrintReport = new Data.PartsMasterPrintReport();
            List<System.Data.SqlClient.SqlParameter> MasterTest_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            MasterTest_Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", parameters[1].Value));
            RASF.General.Lists.MasterTestPrintReportRecieptPicList MasterTestPrintReportList = new MasterTestPrintReportRecieptPicList();
            MasterTestPrintReportList.Fill(MasterTest_Parameters);

            foreach (RASF.General.Data.PartsMasterPrintReport Parts in this)
            {
                RASF.General.Lists.MasterTestPrintReportRecieptPicList Master = new RASF.General.Lists.MasterTestPrintReportRecieptPicList();
                Master.AddRange((from m in MasterTestPrintReportList where m.PartsMasterCode == Parts.PartsMasterCode && m.ReportType == Parts.ReportType select m).ToList<RASF.General.Data.MasterTestPrintReport>());

                Parts.MasterTestPrintReport = Master;
            }

            PartsMasterPrintReportList row = new PartsMasterPrintReportList();
            row.AddRange((from m in this where m.MasterTestPrintReport.Count() == 0 select m).ToList<RASF.General.Data.PartsMasterPrintReport>());
            foreach (RASF.General.Data.PartsMasterPrintReport Parts in row)
            {
                this.Remove(Parts);
            }
            return this.list.Count;
        }
    }
    
}
