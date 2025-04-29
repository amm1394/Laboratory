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
    public partial class CompaniesEnglishReport : RASF.General.Forms.Base.GeneralForm
    {
        private Guid EnglishCode;
        public CompaniesEnglishReport()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
        }

         public CompaniesEnglishReport(Guid CompaniesReportCode)
             :this()
        {
             EnglishCode = CompaniesReportCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RASF.Main.Forms.Reception.CompaniesEnglishReport CompaniesEnglishReport = new Forms.Reception.CompaniesEnglishReport(EnglishCode);

            try
            {
                   RASF.General.Data.Companies_English Current_Row = (RASF.General.Data.Companies_English)this.grdEnglish.CurrentRow.DataRow;
                if (Current_Row != null)
                {
                    List<System.Data.SqlClient.SqlParameter> Parameter = new List<System.Data.SqlClient.SqlParameter>();
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@EnglishCode",EnglishCode));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@EnglishName", ((RASF.General.Data.Companies_English)this.grdEnglish.CurrentRow.DataRow).EnglishName));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@EnglishAddress", ((RASF.General.Data.Companies_English)this.grdEnglish.CurrentRow.DataRow).EnglishAddress));
                    Parameter.Add(new System.Data.SqlClient.SqlParameter("@PostCode", ((RASF.General.Data.Companies_English)this.grdEnglish.CurrentRow.DataRow).PostCode));
                    RASF.General.Lists.Base.BaseList<Object>.FillScalar("Companies_English_Insert", Parameter);
                    
                }
                //else
                //{
                //    this.Close();
                //    List<System.Data.SqlClient.SqlParameter> Parameter2 = new List<System.Data.SqlClient.SqlParameter>();
                //    Parameter2.Add(new System.Data.SqlClient.SqlParameter("CompaniesReportCode", EnglishCode));
                //    Int16 Result = Convert.ToInt16(RASF.General.Lists.BanksList.FillScalar("EnglishName_Select", Parameter2));

                //    if (Result == 0)
                //    {
                //        this.Close();
                //        this.Visible = false;
                //        this.ShowDialog();
                //    }
                //}
            }

            catch
            {

            }

            
        }

        private void CompaniesEnglishReport_Load(object sender, EventArgs e)
        {
        }
    }
}
