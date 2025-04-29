using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class DailyProcessReportList : RASF.General.Lists.Base.BaseList<RASF.General.Data.DailyProcessReport>
    {
        public DailyProcessReportList()
        {
            this.spName = "DailyProcessReport";
            this.list = new List<RASF.General.Data.DailyProcessReport>();
            this.deletedlist = new List<RASF.General.Data.DailyProcessReport>();
        }

        public DailyProcessReportList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);

            if (this.list.Count > 0)
            {
                List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                Parameter.Add(new System.Data.SqlClient.SqlParameter("From", parameters[0].Value));
                Int64 RemindNaghd = (Int64)RASF.General.Lists.BanksList.FillScalar("RemindNaghd_Select", Parameter);

                List<System.Data.SqlClient.SqlParameter> Parameter1 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter1.Add(new System.Data.SqlClient.SqlParameter("From", parameters[0].Value));
                Int64 RemindEtebari = (Int64)RASF.General.Lists.BanksList.FillScalar("RemindEtebari_Select", Parameter1);

                List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                Parameter2.Add(new System.Data.SqlClient.SqlParameter("From", parameters[0].Value));
                Int64 Debtor = (Int64)RASF.General.Lists.BanksList.FillScalar("Debtor_Select", Parameter2);

                this.list[0].RemindEtebari +=RemindEtebari;
                this.list[0].RemindNaghd += RemindNaghd;
                this.list[0].Debtor += Debtor + this.list[0].Bill_Amount;
               // this.list[0].Darsad =Convert.ToDecimal( Convert.ToDecimal((this.list[0].RemindEtebari + this.list[0].RemindNaghd) * 100.0) / this.list[0].Debtor);


                if (this.list.Count > 1)
                {
                    for (int i = 1; i < this.list.Count; i++)
                    {
                        this.list[i].RemindEtebari += this.list[i - 1].RemindEtebari;
                        this.list[i].RemindNaghd += this.list[i - 1].RemindNaghd;
                        this.list[i].Debtor += (this.list[i - 1].Debtor + this.list[i].Bill_Amount);
                      //  this.list[i].Darsad =Convert.ToDecimal(Convert.ToDecimal((this.list[i].RemindEtebari + this.list[i].RemindNaghd) * 100.0) / this.list[i].Debtor);

                    }
                }
            }
            return this.list.Count;
        }
    }
}