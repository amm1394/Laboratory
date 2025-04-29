using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class SentPartToContractorsReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.SentPartToContractorsReport>
    {
        public SentPartToContractorsReportList()
        {
            this.spName = "SentPartToContractorsReport";
            this.list = new List<RASF.General.Data.SentPartToContractorsReport>();
            this.deletedlist = new List<RASF.General.Data.SentPartToContractorsReport>();
        }

        public SentPartToContractorsReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        //public override int Fill()
        //{
        //    //base.Fill();
        //    //RASF.General.Lists.SentPartToContractorsDetailReportList SentPartToContractorsDetailReportList = new SentPartToContractorsDetailReportList();

        //    //foreach (RASF.General.Data.SentPartToContractorsReport SentPart in this)
        //    //{
        //    //    List<System.Data.SqlClient.SqlParameter> Code = new List<System.Data.SqlClient.SqlParameter>();
        //    //    Code.Add(new System.Data.SqlClient.SqlParameter("Code", SentPart.Code));
        //    //    SentPartToContractorsDetailReportList.Fill(Code);

        //    //    RASF.General.Lists.SentPartToContractorsDetailReportList SentPartDetail = new RASF.General.Lists.SentPartToContractorsDetailReportList();
        //    //    SentPartDetail.AddRange((from Detail in SentPartToContractorsDetailReportList where Detail.SentPartToContractorsCode == SentPart.Code select Detail).ToList<RASF.General.Data.SentPartToContractorsDetailReport>());

        //    //    SentPart.SentPartToContractorsDetailReport = SentPartDetail;
        //    //}

        //    return this.list.Count;
        //}
    }
    }

