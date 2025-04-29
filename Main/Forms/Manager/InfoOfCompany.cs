using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASF.Main.Forms.Manager
{
    public partial class InfoOfCompany : RASF.General.Forms.Base.DockContentForm
    {
        public InfoOfCompany()
        {
            InitializeComponent();
            this.companiesBaseList1.spName = "InfoOfCompany";
            this.ShowpnlExit = false;
           // this.ShowpnlSave = false;
            
        }

        private void InfoOfCompany_Load(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.grid1.Refetch();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.companiesBaseList1.Fill();
            this.grid1.Refetch();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.grid1.ExportToExcel("اطلاعات شرکت ها");
        }
    }
}
