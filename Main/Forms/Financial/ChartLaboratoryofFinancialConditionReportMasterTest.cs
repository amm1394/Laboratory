using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class ChartLaboratoryofFinancialConditionReportMasterTest : RASF.General.Forms.Base.GeneralForm
    {
        private DateTime From, To;
        private Guid MainTestCode ;
        public ChartLaboratoryofFinancialConditionReportMasterTest(Guid mainTestCode, DateTime FromMain,DateTime ToMain)
        {
            InitializeComponent();
            this.ShowpnlButton = false; 
            From = FromMain ; 
            To = ToMain ;
            MainTestCode = mainTestCode;
        }

      
        private void FinancialOffices_Load(object sender, EventArgs e)
        {
           
            List<System.Data.SqlClient.SqlParameter> Parameters1 = new List<System.Data.SqlClient.SqlParameter>();
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("From", From));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("To", To));
            Parameters1.Add(new System.Data.SqlClient.SqlParameter("MainCode", MainTestCode));
            this.chartLaboratoryofFinancialConditionReportMasterTestList1.Fill(Parameters1);
            this.grdTotal.Refetch();
            this.chartTotal.DrawBarChart("Remind", "Mastername", "test");

        }

            
        }


      
    }

