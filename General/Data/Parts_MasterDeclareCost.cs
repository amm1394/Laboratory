using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Data
{
    public class Parts_MasterDeclareCost : RASF.General.InterFaces.IRow
    {
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute(true)]
        public Guid Parts_Master_Code
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute()]
        public Guid ContractsBaseCode
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute()]
        public int PartNumber
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("نام نمونه", "")]
        public string Name
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("پایه آهنی", "")]
        public byte FeBase
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute()]
        public byte Void
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("تخریب شود", "")]
        public byte Destruct
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("حجیم بودن", "")]
        public byte IsLarge
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("محل آزمون", "")]
        public byte TestLocation
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("مارکینگ در حضور", "")]
        public byte Marking
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public Guid Executers
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("عکس قطعه", "")]
        public Byte[] Picture
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("عکس قطعه", "")]
        public Byte[] SmallPicture
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("2عکس قطعه", "")]
        public Byte[] Picture2
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("عکس قطعه2", "")]
        public Byte[] SmallPicture2
        {
            get;
            set;
        }

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("نام انگلیسی نمونه", "")]
        public string Englishname
        {
            get;
            set;
        }
        
        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.Validator("")]
        [RASF.General.Attributes.DataAttribute("", "")]
        public Guid UserIdUpdate
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

        [System.ComponentModel.Category("RASF")]
        [RASF.General.Attributes.DataAttribute()]
        public RASF.General.Lists.MasterTestStatusDeclareCostList Tests
        {
            get;
            set;
        }

        public Parts_MasterDeclareCost()
        {
            this.Tests = new Lists.MasterTestStatusDeclareCostList();
            this.Englishname = String.Empty;
        }

        public void CopyTest(RASF.General.Lists.MasterTestStatusDeclareCostList tests)
        {
            foreach (RASF.General.Data.MasterTestStatus masterTestStatus in this.Tests)
            {
                RASF.General.Data.MasterTestStatus test = this.Tests.Where(row => row.MasterTestCode == masterTestStatus.MasterTestCode).FirstOrDefault();
                this.Tests.Remove(test);
            }

            foreach (RASF.General.Data.MasterTestStatus masterTestStatus in tests)
            {
                this.Tests.Add(ReturnTests(masterTestStatus));
            }
        }

        private RASF.General.Data.MasterTestStatus ReturnTests(RASF.General.Data.MasterTestStatus Row)
        {
            RASF.General.Data.MasterTestStatus NewRow = new General.Data.MasterTestStatus();
            NewRow.ContractCode = this.ContractsBaseCode;
            NewRow.DetailName = Row.DetailName;
            NewRow.InvoicePrice = Row.InvoicePrice;
            NewRow.IsCheck = Row.IsCheck;
            NewRow.LabInCome = Row.LabInCome;
            NewRow.MainTestCode = Row.MainTestCode;
            NewRow.MasterName = Row.MasterName;
            NewRow.MasterTestCode = Row.MasterTestCode;
            NewRow.NumberOfTests = Row.NumberOfTests;
            NewRow.PartsMasterCode = this.Parts_Master_Code;
            NewRow.PartsTestMasterCode = Row.PartsTestMasterCode;
            NewRow.PartsTestsDetailCode = Row.PartsTestsDetailCode;
            NewRow.Tax = Row.Tax;
            NewRow.UserIdUpdate = RASF.General.Classes.Global.CurrentUserCode;//update
            NewRow.RowState = Row.RowState;

            return NewRow;
        }

        public void SetTest(RASF.General.Data.MasterTestStatus masterTestStatus)
        {
            RASF.General.Data.MasterTestStatus test = this.Tests.Where(row => row.MasterTestCode == masterTestStatus.MasterTestCode).FirstOrDefault();
            masterTestStatus.PartsMasterCode = this.Parts_Master_Code;
            masterTestStatus.ContractCode = this.ContractsBaseCode;
            if (masterTestStatus.IsCheck == true)
            {
                if (test == null)
                {
                    RASF.General.Data.MasterTestStatus del_test = this.Tests.deletedlist.Where(row => row.MasterTestCode == masterTestStatus.MasterTestCode).FirstOrDefault();
                    if (del_test == null)
                    {
                        masterTestStatus.RowState = Enums.RowState.Added;
                        this.Tests.Add(masterTestStatus);
                    }
                    else
                    {
                        this.Tests.deletedlist.Remove(del_test);
                        masterTestStatus.RowState = Enums.RowState.Updated;
                        this.Tests.Add(masterTestStatus);
                    }
                }
                else
                {
                    masterTestStatus.PartsTestMasterCode = new Guid(test.PartsTestMasterCode.ToString());
                    masterTestStatus.RowState = test.RowState;
                    if (masterTestStatus.RowState != Enums.RowState.Added)
                    {
                        masterTestStatus.RowState = Enums.RowState.Updated;
                    }
                    this.Tests[this.Tests.list.FindIndex(row => row.MasterTestCode == masterTestStatus.MasterTestCode)] = masterTestStatus;
                }
            }
            else
            {
                if (test != null)
                {
                    this.Tests.Remove(test);
                }
            }
        }
    }
}
