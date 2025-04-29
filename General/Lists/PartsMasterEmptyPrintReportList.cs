using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class PartsMasterEmptyPrintReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.PartsMasterEmptyPrintReport>
    {
        public PartsMasterEmptyPrintReportList()
        {
            this.spName = "PartsMasterEmptyPrintReport";
            this.list = new List<RASF.General.Data.PartsMasterEmptyPrintReport>();
            this.deletedlist = new List<RASF.General.Data.PartsMasterEmptyPrintReport>();
        }

        public PartsMasterEmptyPrintReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }
        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            RASF.General.Data.PartsMasterEmptyPrintReport PartsMasterPrintReport = new Data.PartsMasterEmptyPrintReport();
            List<System.Data.SqlClient.SqlParameter> MasterTest_Parameters = new List<System.Data.SqlClient.SqlParameter>();
            MasterTest_Parameters.Add(new System.Data.SqlClient.SqlParameter("@ContractCode", parameters[0].Value));
            RASF.General.Lists.MasterTestPrintReportList MasterTestPrintReportList = new MasterTestPrintReportList();
            MasterTestPrintReportList.Fill(MasterTest_Parameters);

            foreach (RASF.General.Data.PartsMasterEmptyPrintReport Parts in this)
            {
                RASF.General.Lists.MasterTestPrintReportList Master = new RASF.General.Lists.MasterTestPrintReportList();
                Master.AddRange((from m in MasterTestPrintReportList where m.PartsMasterCode == Parts.PartsMasterCode select m).ToList<RASF.General.Data.MasterTestPrintReport>());

                Parts.MasterTestPrintReport = Master;
            }

            PartsMasterEmptyPrintReportList row = new PartsMasterEmptyPrintReportList();
            row.AddRange((from m in this where m.MasterTestPrintReport.Count() == 0 select m).ToList<RASF.General.Data.PartsMasterEmptyPrintReport>());
            foreach (RASF.General.Data.PartsMasterEmptyPrintReport Parts in row)
            {
                this.Remove(Parts);
            }
            return this.list.Count;
        }
    }
    
}
