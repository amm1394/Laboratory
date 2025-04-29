using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class KolCash : RASF.General.Forms.Base.DockContentForm
    {
        Int64 Karkard;
        Int64 Pardakhti;
        Int64 Mande;
        decimal Darsad;
        public KolCash()
        {
            InitializeComponent();
            this.ShowpnlExit = false;
            this.ShowpnlSave = false;
            labkarkard.Text = "";
            labMande.Text = "";
            labPardakhti.Text = "";
            labDarsad.Text = "";

        }

        private void KolCredit_Load(object sender, EventArgs e)
        {
            Darsad = (decimal)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyDarsad_Select");
            labDarsad.Text = Darsad.ToString();

            Karkard = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanydebtor_Select");
            labkarkard.Text=Karkard.ToString("N0");

            Mande = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyTotalRemind_Select");
            labMande.Text = Mande.ToString("N0");

            Pardakhti = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyCredit_Select");
            labPardakhti.Text = Pardakhti.ToString("N0");

          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Darsad = (decimal)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyDarsad_Select");
            labDarsad.Text = Darsad.ToString();

            Karkard = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanydebtor_Select");
            labkarkard.Text = Karkard.ToString("N0");

            Mande = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyTotalRemind_Select");
            labMande.Text = Mande.ToString("N0");

            Pardakhti = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCashCompanyCredit_Select");
            labPardakhti.Text = Pardakhti.ToString("N0");

        }
    }
}
