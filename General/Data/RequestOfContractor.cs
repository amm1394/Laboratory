using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
     public class RequestOfContractor : RASF.General.InterFaces.IRow
    {
         [System.ComponentModel.Category("RASF")]
         [RASF.General.Attributes.DataAttribute()]
         public bool Check

         {
             get;
             set;
         }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
         public Guid PartsTestMasterCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public String MasterName
        {
            get;
            set;
        }
                
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ContractorCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid LaboratoryCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public string DateOfRequest
        {
            get;
            set;
        }
         
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public string DateOfSend
        {
            get;
            set;
        }

             
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public Enums.RowState RowState
        {
            get;
            set;
        }

        public RequestOfContractor()
        {

        }
    }
}
