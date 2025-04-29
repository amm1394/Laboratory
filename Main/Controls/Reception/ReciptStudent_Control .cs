using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Controls.Reception
{
    public partial class ReciptStudent_Control  : UserControl
    {
        public event EventHandler AddClick
        {
            add { this.btnAdd.Click += value; }
            remove { this.btnAdd.Click -= value; }
        }

        public Object DataSource { 
            get
            {
                return this.grid1.DataSource;
            }
            set
            {
                this.grid1.DataSource = value;
                this.grid1.Refetch();
            }
        }

        public ReciptStudent_Control()
        {
            InitializeComponent();
        }

        public void AddTest(RASF.General.Data.New_Receipt row)
        {
            RASF.General.Data.New_Receipt Row = ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Where(r => r.MasterTestCode == row.MasterTestCode).SingleOrDefault();
            switch (row.RowState)
            {
                case General.Enums.RowState.Added:
                    {
                        row.IsChecked = true;
                        if (Row == null)
                        {
                            ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Add(row);
                        }
                        else
                        {
                            Row.Number = row.Number;
                        }
                    }
                    break;
                case General.Enums.RowState.Deleted:
                    {
                        ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Remove(Row);
                    }
                    break;
                case General.Enums.RowState.Updated:
                    {
                        row.IsChecked = true;
                        if (((RASF.General.Lists.ReceiptStudentList)this.DataSource).Count(r => r.MasterTestCode == row.MasterTestCode) == 0)
                        {
                            ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Add(row);
                        }
                    }
                    break;
                case General.Enums.RowState.Original:
                    {
                        row.IsChecked = true;
                        ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Add(row);
                    }
                    break;
            }
            this.grid1.Refetch();
        }

        public void RestTest()
        {
            if (((RASF.General.Lists.ReceiptStudentList)this.DataSource) != null)
            {
                ((RASF.General.Lists.ReceiptStudentList)this.DataSource).Clear();
                this.grid1.Refetch();
            }
        }

    }
}
