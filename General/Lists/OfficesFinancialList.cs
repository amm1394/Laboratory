using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class OfficesFinancialList : RASF.General.Lists.Base.BaseList<RASF.General.Data.OfficesFinancial>
    {
        public OfficesFinancialList()
        {
            this.spName = "OfficesFinancial";
            this.list = new List<RASF.General.Data.OfficesFinancial>();
            this.deletedlist = new List<RASF.General.Data.OfficesFinancial>();
        }

        public OfficesFinancialList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            base.Fill(parameters);
            if (this.Count() > 0)
            {
                Data.OfficesFinancial OfficesFinancial = new Data.OfficesFinancial();
                OfficesFinancial.Debtor = this.list.Sum(row => row.Debtor);
                OfficesFinancial.AgencyName = "جمع کل";
                this.list.Add(OfficesFinancial);

                List<RASF.General.Data.OfficesFinancial> OfficesFinancialList = (from row in this.list orderby row.Debtor descending select row).ToList();
                this.list.Clear();
                this.list.AddRange(OfficesFinancialList);
            }
            return this.list.Count;
        }
    }
}
