using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RASF.Main.Forms.Financial
{
    public partial class KolCredit : RASF.General.Forms.Base.DockContentForm
    {
        Int64 Karkard;
        Int64 Pardakhti;
        Int64 Mande;
        decimal Darsad;
        public KolCredit()
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
            Darsad = (decimal)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyDarsad_Select");
            labDarsad.Text = Darsad.ToString();

            Karkard = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanydebtor_Select");
            labkarkard.Text=Karkard.ToString("N0");

            Mande = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyTotalRemind_Select");
            labMande.Text = Mande.ToString("N0");

            Pardakhti = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyCredit_Select");
            labPardakhti.Text = Pardakhti.ToString("N0");

          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Darsad = (decimal)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyDarsad_Select");
            labDarsad.Text = Darsad.ToString();

            Karkard = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanydebtor_Select");
            labkarkard.Text = Karkard.ToString("N0");

            Mande = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyTotalRemind_Select");
            labMande.Text = Mande.ToString("N0");

            Pardakhti = (Int64)RASF.General.Lists.BanksList.FillScalar("SumOfCreditCompanyCredit_Select");
            labPardakhti.Text = Pardakhti.ToString("N0");

        }
    }
}
