using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Reception
{
    public partial class AddTest : Form
    {
        public AddTest()
        {
            InitializeComponent();
            List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
            Parameters.Add(new System.Data.SqlClient.SqlParameter("FINANCAILYEAR", RASF.General.Classes.Global.FinancialYear));
            this.new_ReceiptList1.Fill(Parameters);
            this.grid1.Refetch();
        }

        public List<General.Data.New_Receipt> GetTest()
        {
            return (from row in this.new_ReceiptList1 where row.IsChecked == true select row).ToList();
        }

        public void SetTest(List<General.Data.MasterTestStatus> list)
        {
            foreach (General.Data.MasterTestStatus Test in list)
            {
                RASF.General.Data.New_Receipt row = this.new_ReceiptList1.Where(r => r.MasterTestCode == Test.MasterTestCode).SingleOrDefault();
                if (row != null)
                {
                    row.Number = Test.NumberOfTests;
                    row.RowState = Test.RowState;
                    row.IsChecked = true;
                }
            }
            this.grid1.Refetch();
        }

        public void SetTest(General.Data.MasterTestStatus Test)
        {
            RASF.General.Data.New_Receipt row = this.new_ReceiptList1.Where(r => r.MasterTestCode == Test.MasterTestCode).SingleOrDefault();
            if (row != null)
            {
                row.Number = Test.NumberOfTests;
                row.RowState = Test.RowState;
                row.IsChecked = true;
            }
            this.grid1.Refetch();
        }

        public void Reset()
        {
            foreach(General.Data.New_Receipt Test in this.new_ReceiptList1)
            {
                Test.RowState = General.Enums.RowState.Original;
                Test.IsChecked = false;
                Test.Number = 1;
            }
            this.grid1.Refetch();
        }
    }
}
