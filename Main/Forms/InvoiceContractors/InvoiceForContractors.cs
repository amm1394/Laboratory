using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace RASF.Main.Forms.InvoiceContractors
{
    public partial class InvoiceForContractors : RASF.General.Forms.Base.DockContentForm
    {
        public InvoiceForContractors()
        {
            InitializeComponent();
        }

        private void InvoiceForContractors_Load(object sender, EventArgs e)
        {
            this.profileOfContractorsList1.Fill();
            this.grdcontractors.Refetch();
        }

        private void grdcontractors_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grdcontractors.SelectedItems.Count > 0)
            {
                RASF.General.Data.ProfileOfContractors Current_Contract = (RASF.General.Data.ProfileOfContractors)this.grdcontractors.SelectedItems[0].GetRow().DataRow;

                if (Current_Contract != null)
                {
                    List<System.Data.SqlClient.SqlParameter> Parameters = new List<System.Data.SqlClient.SqlParameter>();
                    //Parameters.Add(new System.Data.SqlClient.SqlParameter("FinancialYear", RASF.General.Classes.Global.FinancialYear));
                    Parameters.Add(new System.Data.SqlClient.SqlParameter("ContractorCode", Current_Contract.ContractorCode));
                    this.detailOfProfileContractorsList1.Fill(Parameters);
                    this.grdDetail.Refetch();
                }
                else
                {
                    this.detailOfProfileContractorsList1.Clear();
                    this.grdDetail.Refetch();
                }
            }
            else
            {
                this.detailOfProfileContractorsList1.Clear();
                this.grdDetail.Refetch();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //RASF.General.Data.ProfileOfContractors CurrentRow = (RASF.General.Data.ProfileOfContractors) this.grdcontractors.SelectedItems[0].GetRow().DataRow;
            //if (CurrentRow.MasterAmount >0)
            //{
            //    Int64 Invoce;
            //    List<System.Data.SqlClient.SqlParameter> Param = new List<System.Data.SqlClient.SqlParameter>();
            //    Param.Add(new System.Data.SqlClient.SqlParameter("@Amount", CurrentRow.MasterAmount));
            //    Param.Add(new System.Data.SqlClient.SqlParameter("@ContractorCode", CurrentRow.countractorsCode));
            //    Invoce = (Int64)RASF.General.Lists.Base.BaseList<Object>.FillScalar("ProfileOfContractors_Update", Param);

            //    foreach (RASF.General.Data.ProfileOfContractors detail in detailOfProfileContractorsList1.Where(row => row.DetailAmount>0))
            //    {
            //        detail.InvoiceCode = Invoce;
            //        this.detailOfProfileContractorsList1.Update();
            //    }

            //}


        }

        private void grdcontractors_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            RASF.General.Data.ProfileOfContractors CurrentRow = (RASF.General.Data.ProfileOfContractors)this.grdcontractors.SelectedItems[0].GetRow().DataRow;
            if (CurrentRow.MasterAmount > 0)
            {
                Int64 Invoce;
                List<System.Data.SqlClient.SqlParameter> Param = new List<System.Data.SqlClient.SqlParameter>();
                Param.Add(new System.Data.SqlClient.SqlParameter("@Amount", CurrentRow.MasterAmount));
                Param.Add(new System.Data.SqlClient.SqlParameter("@ContractorCode", CurrentRow.ContractorCode));
                Invoce = Convert.ToInt64(RASF.General.Lists.Base.BaseList<Object>.FillScalar("ProfileOfContractors_Update", Param));

                foreach (RASF.General.Data.ProfileOfContractors detail in detailOfProfileContractorsList1.Where(row => row.DetailAmount > 0))
                {
                    detail.InvoiceCode = Invoce;
                    this.detailOfProfileContractorsList1.Update();
                }

           }
        }
    }
}
