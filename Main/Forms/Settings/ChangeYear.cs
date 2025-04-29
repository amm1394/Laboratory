using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Settings
{
    public partial class ChangeYear : RASF.General.Forms.Base.DockContentForm
    {
        public event System.EventHandler ChangedYead;

        public ChangeYear()
        {
            InitializeComponent();
            this.ShowpnlButton = false;
        }

        
        private void grdYear_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Classes.Global.FinancialYear =(int)this.grdYear.CurrentRow.Cells["ContractYear"].Value;

            System.Windows.Forms.MessageBox.Show(string.Format( "سال جاری به {0}تغییر یافت", RASF.General.Classes.Global.FinancialYear.ToString()));

            if (this.ChangedYead != null)
            {
                this.ChangedYead(this, new EventArgs());
            }
            this.Close();
        }

        private void ChangeYear_Load(object sender, EventArgs e)
        {
            this.changeYearList1.Fill();

            this.grdYear.Refetch();
                                    
        }
    }
}
