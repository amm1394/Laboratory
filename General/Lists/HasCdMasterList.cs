using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class HasCdMasterList : RASF.General.Lists.Base.BaseList<RASF.General.Data.HasCdMaster>
    {
        public HasCdMasterList()
        {
            this.spName = "HasCdMaster";
            this.list = new List<RASF.General.Data.HasCdMaster>();
            this.deletedlist = new List<RASF.General.Data.HasCdMaster>();
        }

        public HasCdMasterList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill()
        {
            base.Fill();

            RASF.General.Lists.HasCdDetailList HasCdDetailList = new Lists.HasCdDetailList();
            HasCdDetailList.Fill();

            foreach (RASF.General.Data.HasCdMaster Master in this)
            {
                RASF.General.Lists.HasCdDetailList Detail = new RASF.General.Lists.HasCdDetailList();
                Detail.AddRange((from Cd in HasCdDetailList where Cd.ContractCode == Master.ContractsCode select Cd).ToList<RASF.General.Data.HasCdDetail>());

                Master.HasCdDetail = Detail;
            }

            return this.list.Count;
        }

        public override void Update()
        {
            foreach (RASF.General.Data.HasCdMaster Master in this)
            {

                Master.HasCdDetail.Update();
                
            }
        }
    }
    
}
