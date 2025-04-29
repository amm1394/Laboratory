using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASF.General.Lists
{

    [System.ComponentModel.Category("RASF")]
    public class ContractsNotEnteredList : RASF.General.Lists.Base.BaseList<RASF.General.Data.ContractsNotEntered>
    {
        public ContractsNotEnteredList()
        {
            this.spName = "Contracts_NotEntered";
            this.list = new List<RASF.General.Data.ContractsNotEntered>();
            this.deletedlist = new List<RASF.General.Data.ContractsNotEntered>();
        }

        public ContractsNotEnteredList(System.ComponentModel.IContainer container)
            : this()
        {
            container.Add(this);
        }

        public override int Fill(List<System.Data.SqlClient.SqlParameter> parameters)
        {
            List<SqlParameter> p1 = new List<SqlParameter>();
            p1.Add(new SqlParameter("@userId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.PartsMasterNotEnteredList PartsMasterNotEntered_List = new PartsMasterNotEnteredList();
            PartsMasterNotEntered_List.Fill(p1);

            List<SqlParameter> p2 = new List<SqlParameter>();
            p2.Add(new SqlParameter("@userId", RASF.General.Classes.Global.CurrentUserCode));
            RASF.General.Lists.TestNameNotEnteredlist TestNameNotEntered_list = new Lists.TestNameNotEnteredlist();
            TestNameNotEntered_list.Fill(p2);

            base.Fill(parameters);

            // لیست نهایی قراردادهای معتبر
            var validContracts = new ContractsNotEnteredList();

            /* this      → ContractsNotEnteredList
             * parts list / tests list → کالکشن‌های سفارشی
             */

            foreach (var contract in this.Cast<RASF.General.Data.ContractsNotEntered>())
            {
                // ────── Part های مربوط به قرارداد ──────
                var partsQuery = PartsMasterNotEntered_List
                                 .Where(p => p.ContractsBaseCode == contract.ContractsCode)
                                 .ToList();                     // ← تبدیل به List<T>

                if (partsQuery.Count == 0)      // هیچ Part یافت نشد
                    continue;                   // قرارداد نامعتبر

                var partsList = new PartsMasterNotEnteredList();
                partsList.AddRange(partsQuery);

                // ────── برای هر Part، تست‌هایش را بیاب و ست کن ──────
                foreach (var part in partsList.ToList())        // کپی برای حذف امن
                {
                    var testsQuery = TestNameNotEntered_list
                                     .Where(t => t.PartsMasterCode == part.Parts_Master_Code)
                                     .ToList();                 // ← List<T>

                    if (testsQuery.Count == 0)                  // این Part تست ندارد
                    {
                        partsList.Remove(part);                 // حذفش می‌کنیم
                        continue;
                    }

                    var testsList = new TestNameNotEnteredlist();
                    testsList.AddRange(testsQuery);
                    part.TestNameNotEntered = testsList;
                }

                if (partsList.Count() == 0)                       // همه‌ی Partها حذف شدند
                    continue;                                   // قرارداد مردود

                contract.PartsMasterNotEntered = partsList;     // لیست Partهای معتبر
                validContracts.Add(contract);
            }

            /* جایگزینی لیست اصلی با موارد معتبر */
            this.Clear();
            this.AddRange(validContracts.ToList());

            //foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            //{
            //    RASF.General.Lists.PartsMasterNotEnteredList ContractsParts = new RASF.General.Lists.PartsMasterNotEnteredList();
            //    ContractsParts.AddRange((from Part in PartsMasterNotEntered_List where Part.ContractsBaseCode == Contracts.ContractsCode select Part).ToList<RASF.General.Data.PartsMasterNotEntered>());
            //    foreach (RASF.General.Data.PartsMasterNotEntered Parts in ContractsParts)
            //    {
            //        RASF.General.Lists.TestNameNotEnteredlist PartsTest = new Lists.TestNameNotEnteredlist();
            //        PartsTest.AddRange((from Test in TestNameNotEntered_list where Test.PartsMasterCode == Parts.Parts_Master_Code select Test).ToList<RASF.General.Data.TestNameNotEntered>());
            //        Parts.TestNameNotEntered = PartsTest;
            //    }
            //    Contracts.PartsMasterNotEntered = ContractsParts;
            //}

            return this.list.Count;
        }

        public override void Update()
        {
            foreach (RASF.General.Data.ContractsNotEntered Contracts in this)
            {
                foreach (RASF.General.Data.PartsMasterNotEntered Parts in Contracts.PartsMasterNotEntered)
                {
                    Parts.TestNameNotEntered.Update();
                }
            }
        }
    }

}
